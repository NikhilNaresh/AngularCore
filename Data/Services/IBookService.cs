namespace AngularCore.Data
{
    public interface IBookService
    {
        List<Book> GetAllBooks();

        Book GetBookById(int id);

        void UpdateBook(int id, Book newBook);

        void DeleteBook(int id);

        void AddNewBook(Book newBook);
    }
}