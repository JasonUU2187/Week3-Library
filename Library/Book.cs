namespace Library
{
    class Book
    {
       private string Title;
       private string Author;
       private string ISBN;

        public string title
        {
            get { return Title; }
            set { Title = value; }
        }
        public string authour
        {
            get { return Author; }
            set { Author = value; }
        }
        public string isbn
        {
            get { return ISBN; }
            set { ISBN = value; }
        }

        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            Title = bookTitle;
            Author = bookAuthor;
            ISBN = bookISBN;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
        
    }
}