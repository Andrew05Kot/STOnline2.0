import { Component, OnInit } from '@angular/core';
import {OrderService} from "../../services/order.service";

@Component({
  selector: 'app-order',
  templateUrl: './order.component.html',
  styleUrls: ['./order.component.css']
})
export class OrderComponent implements OnInit {

  constructor(private service: OrderService) { }

  ngOnInit(): void {
  }

}
