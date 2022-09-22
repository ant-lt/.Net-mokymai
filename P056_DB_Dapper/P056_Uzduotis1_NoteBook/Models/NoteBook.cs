using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P056_Uzduotis1_NoteBook.Models
{
    public class NoteBook
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDatetime { get; set; }
        public string Priority { get; set; }
    }
}
