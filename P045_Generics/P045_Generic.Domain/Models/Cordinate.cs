using P045_Generic.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P045_Generic.Domain.Models
{
    public class Cordinate<T> : ICordinate
    {
        public  T x { get; set; }
        public  T y { get; set; }

        public Cordinate()
        {

        }


        public Cordinate(T xValue, T yValue)
        {
            this.x = xValue; 
            this.y = yValue;



        }

        public string GetCordinate()
        {
            return $"X:{x.ToString()} Y: {y.ToString()}";
        }

        public void ResetCordinate()
        {
            x = default(T);
            y = default(T);
        }
    }
}
