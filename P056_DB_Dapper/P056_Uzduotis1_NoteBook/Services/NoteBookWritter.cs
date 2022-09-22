using P056_Uzduotis1_NoteBook.Database;
using P056_Uzduotis1_NoteBook.Database.Dapper;
using P056_Uzduotis1_NoteBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P056_Uzduotis1_NoteBook.Services
{
    public class NoteBookWritter : INoteBookWritter
    {
        private readonly DatabaseConfig _databaseConfig;
        private readonly INoteBookRepository _noteBookRepository;

        public NoteBookWritter()
        {
            _databaseConfig = new DatabaseConfig();
            _noteBookRepository = new NoteBookRepository(_databaseConfig);
        }

        public void Run()
        {
            char selection;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Add Note");
                Console.WriteLine("2. List Notes");
                Console.WriteLine("3. Remove Products with name");
                Console.WriteLine("4. Update Notebook by ID");
                Console.WriteLine("q. Quit");

                selection = Console.ReadKey().KeyChar;

                switch (selection)
                {
                    case '1':
                        AddNoteBook();
                        break;
                    case '2':
                        DisplayNoteBooks();
                        break;
                    case '3':
                        RemoveNoteBooks();
                        break;
                    case '4':
                        UpdateNotebook();
                        break;
                    case 'q':
                        return;
                    default:
                        break;
                }

                PauseScreen();
            }

        }

        public void UpdateNotebook()
        {
            Console.WriteLine("\n\nPlease select Notebook ID to update:");
            DisplayNoteBooks();

            int updateNoteBookId = Convert.ToInt32(Console.ReadLine());
            NoteBook noteBook = _noteBookRepository.Get(updateNoteBookId);

            if (noteBook == null)
            {
                Console.WriteLine("Notebook not found with");
                return;
            }

            
            Console.WriteLine("\n\nPlease enter new title of the Notebook:");
            noteBook.Title = Console.ReadLine();
            Console.WriteLine("\n\nPlease enter new description of the product:");
            noteBook.Description = Console.ReadLine();

            _noteBookRepository.Update(noteBook);

            Console.WriteLine($"\n{noteBook.Title} - {noteBook.Description} added to the database\n");

        }

        public void DisplayNoteBooks()
        {
            var notes = _noteBookRepository.Get();

            Console.WriteLine();

            foreach (var note in notes)
            {
                Console.WriteLine($"{note.Id}. {note.Title} - {note.Description}");
            }
        }

        public void AddNoteBook()
        {
            var newNoteBook = new NoteBook();
            Console.WriteLine("\n\nPlease enter title of the Notebook:");
            newNoteBook.Title = Console.ReadLine();
            Console.WriteLine("\n\nPlease enter description of the product:");
            newNoteBook.Description = Console.ReadLine();

            _noteBookRepository.Create(newNoteBook);

            Console.WriteLine($"\n{newNoteBook.Title} - {newNoteBook.Description} added to the database\n");
        }

        private void PauseScreen()
        {
            Console.WriteLine("{0}{1}Press any key to continue..", Environment.NewLine, Environment.NewLine);
            Console.ReadKey();
        }

        public void RemoveNoteBooks()
        {
            Console.WriteLine("\n\nPlease enter name of the title that should be deleted:");
            string noteTitleToDelete = Console.ReadLine();

            int noteTitlesDeletedCount = _noteBookRepository.Delete(noteTitleToDelete);

            Console.WriteLine($"\n{noteTitlesDeletedCount} called {noteTitleToDelete} were removed.\n");
        }

    }
}
