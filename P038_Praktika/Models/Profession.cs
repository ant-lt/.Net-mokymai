using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P038_Praktika.Models
{
    public class Profession
    {
        public Profession()
        {

        }
        public Profession(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
        public string Text { get; set; }
        public string TextLt { get; set; }

        public void EncodeCsv(string value)
        {
            var arr = value.Split(",");
            if (arr.Length < 3)
            {
                return;
            }
            if (!int.TryParse(arr[0], out int id))
            {
                return;
            }

            Id = id;
            Text = arr[1];
            TextLt = arr[2];

        }
    }
}
