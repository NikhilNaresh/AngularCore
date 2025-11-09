import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Book } from '../Interfaces/book';

@Injectable({
  providedIn: 'root'
})
export class BookService {

  _baseURL:string = "https://localhost:7016/api/Books";
  
  constructor(private http:HttpClient) { }

  getAllBooks()
  {
    return this.http.get<Book[]>(this._baseURL+"/GetBooks");
  }

  addBook(book : Book)
  {
    return this.http.post(this._baseURL+"/AddBook/",book);
  }

  getBookById(id:number)
  {
    return this.http.get<Book>(this._baseURL+"/SingleBook/"+id);
  }
  
  updateBook(book:Book){
    return this.http.put(this._baseURL+"/UpdateBook/"+book.id,book);
  }

  DeleteBook(id:number)
  {
    return this.http.delete(this._baseURL+"/DeleteBook/"+id);
  }
}
