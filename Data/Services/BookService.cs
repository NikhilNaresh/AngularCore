namespace AngularCore.Data
{
    public class BookService : IBookService
    {
        public void AddNewBook(Book newBook)
        {
            Data.Books.Add(newBook);
        }

        public void DeleteBook(int id)
        {
            var book = Data.Books.FirstOrDefault(x => x.Id == id);
            if (book != null)
            {
                Data.Books.Remove(book);
            }
        }

        public List<Book> GetAllBooks()
        {
            return Data.Books.ToList();
        }

        public Book GetBookById(int id)
        {
            return Data.Books.First(x => x.Id == id);
        }

        public void UpdateBook(int id, Book newBook)
        {
            var oldBook = Data.Books.FirstOrDefault(x => x.Id == id);
            if(oldBook!=null)
            {
                oldBook.Title = newBook.Title;
                oldBook.Author = newBook.Author;
                oldBook.Description = newBook.Description;
                oldBook.Rate = newBook.Rate;
                oldBook.DateStart = newBook.DateStart;
                oldBook.DateRead = newBook.DateRead;
            }
        }
    }
}