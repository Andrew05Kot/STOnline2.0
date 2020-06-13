import DateTimeFormat = Intl.DateTimeFormat;

export class Category {
  id : Number
  categoryName : String
}

export class Order {
  id: Number
  userId: Number
  categoryId: Number
  modelAuto: String
  autoNumber: String
  data: Date
  imageUrl: String
}
