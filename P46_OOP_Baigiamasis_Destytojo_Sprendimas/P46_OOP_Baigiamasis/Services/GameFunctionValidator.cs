using P46_OOP_Baigiamasis.Interfaces;
using P46_OOP_Baigiamasis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P46_OOP_Baigiamasis.Services
{
    public class GameFunctionValidator : IGameFunctionValidator
    {
        private readonly List<IConcreteGameFunctionValidator> validators;

        public GameFunctionValidator(List<IConcreteGameFunctionValidator> validators)
        {
            this.validators = validators;
        }

        public bool Validate(string input)
        {
            foreach (var validator in validators)
            {
                if (!validator.Validate(input))
                    return false;
            }
            return true;
        }


        public class WrongPileNo : IConcreteGameFunctionValidator
        {
            private readonly Game _game;

            public WrongPileNo(Game game)
            {
                _game = game;
            }

            public bool Validate(string input)
            {
                _game.ErrText = string.Empty;
                if (!int.TryParse(input, out int x))
                    return true;

                if ((x - 1) < 0 || (x ) > _game.PilesCount)
                {
                    _game.ErrText = "Neteisingai įvestas stulpelio nr";
                    return false;
                }
                return true;
            }
        }
        public class PileContainsSmallerDisk : IConcreteGameFunctionValidator
        {
            private readonly Game _game;

            public PileContainsSmallerDisk(Game game)
            {
                _game = game;
            }

            public bool Validate(string input)
            {
                _game.ErrText = string.Empty;
                if (!int.TryParse(input, out int x))
                    return true;

                if (!_game.HasDiskInHand)
                    return true;

                if (_game.Disks.Any(d => d.X == (x - 1) && d.Size < _game.Disks.Last().Size))
                {
                    _game.ErrText = "Negalima didesnio disko dėti ant mažesnio";
                    return false;
                }
                return true;
            }
        }
        public class PileEmpty : IConcreteGameFunctionValidator
        {
            private readonly Game _game;
            public PileEmpty(Game game)
            {
                _game = game;
            }
            public bool Validate(string input)
            {
                _game.ErrText = string.Empty;
                if (!int.TryParse(input, out int x))
                    return true;

                if (_game.HasDiskInHand)
                    return true;

                if (!_game.Disks.Any(d => d.X == (x - 1) && d.Y != null))
                {
                    _game.ErrText = "Stulpelyje nėra disko";
                    return false;
                }
                return true;
            }
        }
        public class InvalidSymbol : IConcreteGameFunctionValidator
        {
            private readonly Game _game;
            private readonly string _invalidSymbols;
            public InvalidSymbol(Game game, string invalidSymbols)
            {
                _game = game;
                _invalidSymbols = invalidSymbols;
            }
            public bool Validate(string input)
            {
                _game.ErrText = string.Empty;
                if (_invalidSymbols.Contains(input.ToLower()))
                {
                    _game.ErrText = "Neteisinga įvestis";
                    return false;
                }
                return true;
            }
        }


    }
}
