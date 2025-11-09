import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Book } from 'src/app/Interfaces/book';
import { BookService } from 'src/app/services/book.service';

@Component({
  selector: 'app-show-book',
  templateUrl: './show-book.component.html',
  styleUrls: ['./show-book.component.css']
})
export class ShowBookComponent implements OnInit {
book:Book | undefined;

constructor(private service: BookService, private route:ActivatedRoute){}

ngOnInit(): void
{
  console.log('Book ID from route:', this.route.snapshot.params.id);
  this.service.getBookById(this.route.snapshot.params.id).subscribe(data =>{
    this.book = data;
  })
}
}
