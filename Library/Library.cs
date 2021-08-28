using System;
namespace Library
{
   public class Library
    {
        string the_best_book;
        int  book_count;
        int table_count;
        private string librarian;
        private static int voice;
        public static void Output(Library a)
        {
            voice = 16;
            Console.WriteLine("The librarian is :"+" "+a.Librarian);
            Console.WriteLine("The best book is :"+" "+a.the_best_book);
            Console.WriteLine("The book count is :"+" "+a.book_count);
            Console.WriteLine("The table count is :"+" "+a.table_count);
            Console.WriteLine("voice :"+" "+voice);
            Console.ReadLine();
        }

        //Using encapsulation
        public string Librarian
        {
            get { return librarian; }
            set { librarian = value; }
        }
        //Defining constructors with various parameters
        public Library(string tbb,int bc,int tc)
        {
            the_best_book = tbb;
            book_count = bc;
            table_count = tc;      
        }
        public Library(string tbb, int bc) : this(tbb, bc, 0) { }
        public Library() : this("", 0, 0) { }
        public Library(int bc, int tc) : this( "", bc, tc) { }
        static void Main(string[] args)
        {
           Library myObj = new Library("The old man and the sea",300,15);
            myObj.librarian = "Kane";
            Output(myObj);
            Library myObj1 = new Library(500, 18);
            myObj1.librarian = "David";
            Output(myObj1);
            Library myObj2 = new Library();
            myObj2.librarian = "John";
            Output(myObj2);
            Library myObj3 = new Library("Animal farm", 350);
            myObj3.librarian = "Noy";
            Output(myObj3);
        }
    }
}
