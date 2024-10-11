namespace MinimalApiCqrs;

public class BookWriteRepository{

    public void Add(Book book) =>
        InMemonryDatabase.Books.Add(book.Id, book);

    public void Update(Book book){
        if ( !InMemonryDatabase.Books.TryGetValue(book.Id, out var existingBook) )
            return;

        existingBook.Title = book.Title;
        existingBook.Author = book.Author;
        existingBook.NumberOfPages = book.NumberOfPages;        
    } 

    public void Delete(Guid id) =>
        InMemonryDatabase.Books.Remove(id);
}