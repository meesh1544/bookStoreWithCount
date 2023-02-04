using System;
using System.Security.Cryptography;
using System.Transactions;

namespace bookStore
{
    class Book
    {
        private int _Id;
        private string _Title;
        private string _Author;

        private static int _transactions = 0;

        public void SetTrans()
        {
            _transactions++;
        }
        public int GetTrans()
        {
            return _transactions;
        }
        public Book()
        {
            _Id = 0;
            _Title = "";
            _Author = "";
        }
        public Book(int i, string Title, string Author)
        {
            _Id = i;
            _Title = Title;
            _Author = Author;
        }
        public string GetfullBookName()
        {
            return _Title + "" + _Author;
        }
        public int GetbookId()
        {
            return _Id;
        }
        public string GetbookName()
        {
            return _Title;
        }
        public string GetbookAuthor()
        {
            return _Author;
        }

        public void SetbookId(int identification)
        {
            _Id = identification;
        }
        public void SetbookName(string title)
        {
            _Title = title;
        }
        public void SetbookAuthor(string author)
        {
            _Author = author;
        }
    }
    class myStore
    {
        static void Main(string[] args)
        {
            Book member10 = new Book();
            member10.SetTrans();
            member10.SetbookId(10);
            member10.SetbookName("The Berenstain Bears");
            member10.SetbookAuthor("Jan and Stan Berenstain");

            Book member20 = new Book();
            Console.WriteLine("Please enter the book Id:");
            member20.SetbookId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the title of the book");
            member20.SetbookName(Console.ReadLine());
            Console.WriteLine("Please enter the author of the book");
            member20.SetbookAuthor(Console.ReadLine());

            Book member30 = new Book(30, "Green Eggs and Ham", "Dr. Seus");
            member30.SetTrans();

            Console.WriteLine("Please enter the book Id:");
            int temp_Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the title of the book");
            string temp_Title = Console.ReadLine();
            Console.WriteLine("Please enter the Author of the book");
            string temp_Author = Console.ReadLine();
            Book member40 = new Book(temp_Id, temp_Title, temp_Author);

            Console.WriteLine($"The book has {member10.GetTrans()} new members");
            displayBooks(member10);
            displayBooks(member20);
            displayBooks(member30);
            displayBooks(member40);
        }
        static void displayBooks(Book member)
        {
            Console.WriteLine("Here's your book information");
            Console.WriteLine($"Book Id: {member.GetbookId()}");
            Console.WriteLine($"Title: {member.GetbookName()}");
            Console.WriteLine($"Author: {member.GetbookAuthor()}");
            Console.WriteLine($"New Members: {member.GetTrans()}");
            //Console.WriteLine($"Book Name: {member.GetfullBookName()}");



        }



    }
}
