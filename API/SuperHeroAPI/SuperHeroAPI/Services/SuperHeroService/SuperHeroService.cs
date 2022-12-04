using Microsoft.EntityFrameworkCore;
using SuperHeroAPI.Data;
using SuperHeroAPI.Models;

namespace SuperHeroAPI.Services.SuperHeroService
{
    public class SuperHeroService : ISuperHeroService
    {

        private readonly DataContext _superHeroContext;

        private static List<SuperHero> superHeroes = new List<SuperHero>
        {
            new SuperHero{ Id = 1, Name ="Spider Man", FirsName ="Peter", LastName ="Parker", Place = "New York City"},
            new SuperHero{ Id = 2, Name ="Iron Man", FirsName ="Tony", LastName ="Stark", Place = "Malibu"}

        };

        public SuperHeroService(DataContext superHeroContext)
        {
            _superHeroContext = superHeroContext;
        }

        public async Task<List<SuperHero>> AddHero(SuperHero hero)
        {
            _superHeroContext.Add(hero);
            await _superHeroContext.SaveChangesAsync();
            return await _superHeroContext.SuperHeroes.ToListAsync();
        }

        public async Task<List<SuperHero>?> DeleteHero(int id)
        {
            var hero = await _superHeroContext.SuperHeroes.FindAsync(id);
            if (hero is null)
                return null;

            _superHeroContext.Remove(hero);
            await _superHeroContext.SaveChangesAsync();
            return await _superHeroContext.SuperHeroes.ToListAsync();
        }

        public async Task<List<SuperHero>> GetAllHeroes()
        {
            var heroes = await _superHeroContext.SuperHeroes.ToListAsync();
            return heroes;
        }

        public async Task<SuperHero?> GetSingleHero(int id)
        {
            var hero = await _superHeroContext.SuperHeroes.FindAsync(id);
            if (hero is null)
                return null;
            return hero;

        }

        public async Task<List<SuperHero>?> UpdateHero(int id, SuperHero request)
        {
            var hero = await _superHeroContext.SuperHeroes.FindAsync(id);
            if (hero is null)
                return null;
            hero.Id = id;
            hero.Name = request.Name;
            hero.FirsName = request.FirsName;
            hero.LastName = request.LastName;
            hero.Place = request.Place;

            await _superHeroContext.SaveChangesAsync();

            return await _superHeroContext.SuperHeroes.ToListAsync();

        }
    }
}
