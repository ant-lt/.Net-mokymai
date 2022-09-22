using P056_Uzduotis1_NoteBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P056_Uzduotis1_NoteBook.Database
{
    public interface INoteBookRepository
    {
        public void Create(NoteBook note);
        public IEnumerable<NoteBook> Get();
        public NoteBook Get(int notebookId);
        public int Delete(string noteBookTitle);
        public void Update (NoteBook notebook);
    }
}
