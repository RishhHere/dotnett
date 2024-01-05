using BookSection;
// using Book;

Books b = new Books();


//BorrowBook borrow = new BorrowBook(InvalidAmt.AmtDeduct);

// b.limit += Book.InvalidAmt.AmtDeduct;
b.limit += Books.Amt;
b.Borrow(6);
