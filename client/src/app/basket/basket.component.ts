import { Component } from '@angular/core';
import { BasketService } from './basket.service';
import { IBasketItem } from '../shared/models/basket';

@Component({
  selector: 'app-basket',
  templateUrl: './basket.component.html',
  styleUrls: ['./basket.component.scss']
})
export class BasketComponent {

  constructor(public basketService: BasketService) {}

  incrementQuantity(item: IBasketItem) {
    this.basketService.addItemToBasket(item);
  }


  removeItem(id: number, quantity: number) {
    this.basketService.removeItemFormBasket(id,quantity);
  }
}
