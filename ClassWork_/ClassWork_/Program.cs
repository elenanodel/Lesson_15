using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            List<Technical> bookList = new List<Technical>();

            bookList.Add(new Technical("space", "Hokking", "nonFiction"));
            bookList.Add(new Technical("botanica", "Hokking", "nonFiction"));
            bookList.Add(new Technical("apace", "jokking", "nonFiction"));
            bookList.Add(new Technical("jpace", "jhokking", "nonFiction"));
            bookList.Add(new Technical("dpace", "fgkking", "nonFiction"));
            bookList.Add(new Technical("lpace", "tokking", "nonFiction"));

            bookList.Sort((b1, b2) => b1.scienceArea.CompareTo(b2.scienceArea));

            foreach(Technical b in bookList)
            {
                Console.WriteLine(b.scienceArea);
            }
        }

        class Book
        {
            //  variables (public, protected, private)
            protected string _author;
            protected string _name;
            protected int _pages;

            //  constructors
            public Book()
            {
                _author = "unknown";
                _name = "unknown";
                _pages = 0;
            }
            public Book(string author, string name)
            {
                _author = author;
                _name = name;
                _pages = 0;
            }
            public Book(string author, string name, int pages)
            {
                _author = author;
                _name = name;
                _pages = pages;
            }

            //  properties
            public string author
            {
                get { return _author; }
            }

            public string name
            {
                get { return _name; }
            }

            public int pages
            {
                get { return _pages; }
            }

            //  methods
            public void Print()
            {
                Console.Write("{0} {1} {2}", author, name, pages);
            }
        }

        class Technical : Book
        {
            private string _scienceArea;

            public Technical() : base()
            {
                _scienceArea = "unknown";
            }

            public Technical(string scienceArea) : base()
            {
                _scienceArea = scienceArea;
            }

            public Technical(string scienceArea, string author, string name) : base(author, name)
            {
                _scienceArea = scienceArea;
            }

            public Technical(string scienceArea, string author, string name, int pages) : base(author, name, pages)
            {
                _scienceArea = scienceArea;
            }

            public string scienceArea
            {
                get { return _scienceArea; }
            }

            public void Print()
            {
                Console.Write("{0} {1} {2} {3}", author, name, pages, scienceArea);
            }
        }
        class Fiction : Book
        {

        }

        class Library
        {
            private List<Book> book = new List<Book>();

            public void AddBook(Book b)
            {
                book.Add(b);
            }

            public void Print()
            {
                foreach (Book i in book)
                {
                    Console.WriteLine(i);
                }
            }

            public void PrintTechnical()
            {
                foreach (Book i in book)
                {
                    if (i.name.GetType().Equals("Technical"))
                    {
                        Console.WriteLine(i + " book");
                    }
                }
            }

            public void PrintFiction()
            {
                foreach (Book i in book)
                {
                    if (i.name.GetType().Equals("Fiction"))
                    {
                        Console.WriteLine(i + " book");
                    }
                }
            }
        }
    }
}
