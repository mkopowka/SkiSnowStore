import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import {IProduct} from './models/product';
import { IPagination } from './models/pagination';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'Ski Snow Store';
  products: IProduct[] = []
  constructor(private http:HttpClient) {}

  ngOnInit(): void {
    this.http.get<IPagination<IProduct[]>>('https://localhost:5001/api/products?pageSize=50').subscribe({
      next: (response: any) => this.products = response.data,
      error: error => console.log(error),
      complete: () => {
        console.log('request completed');
        console.log('extra statement');
      }
    })
  }
}
