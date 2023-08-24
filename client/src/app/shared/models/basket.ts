import * as cuid from "cuid";

export interface IBasketItem {
    id: number;
    productName: string;
    price: number;
    quantity: number;
    pictureUrl: string;
    brand: string;
    type: string;
}

export interface IBasket {
    id: string;
    items: IBasketItem[];
}


export class IBasket implements IBasket {
    id= cuid();
    items: IBasketItem[] = [];
}

export interface IBasketTotals {
    shipping: number;
    subtotal: number;
    total: number;
}