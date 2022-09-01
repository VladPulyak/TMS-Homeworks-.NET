namespace Homework_13.Models
{
    public class BookViewModel
    {
        public BookViewModel(string bookName, string author, int countOfPages)
        {
            BookName = bookName;
            Author = author;
            CountOfPages = countOfPages;
        }

        public string BookName  { get; set; }
        public string Author { get; set; }
        public int CountOfPages { get; set; }
    }
}
