using System;
using System.Collections.Generic;
using System.Linq;
namespace _2dstringarray
{
    public abstract class BookRental
    {
        public string Title { set; get; }
        public double PricePerDay { set; get; }
        public int Days { set; get; }
        public BookRental(string title, double pricePerDay, int days)
        {
            Title = title;
            PricePerDay = pricePerDay;
            Days = days;
        }

        public abstract double CalculatePrice();
        public override string ToString()
        {
            return string.Format("Title: {0}, Price: {1}",
            Title, CalculatePrice());
        }
    }

    public class RegularBookRental : BookRental
    {
        public RegularBookRental(string title, double pricePerDay, int days) : base(title, pricePerDay, days)
        {
        }

        public override double CalculatePrice()
            => PricePerDay * Days;

    }

    public class NewReleaseBookRental : BookRental
    {
        public NewReleaseBookRental(string title, double pricePerDay, int days) : base(title, pricePerDay, days)
        {
        }

        public override double CalculatePrice()
            => PricePerDay * Days * 1.1;
    }

    public class MyBookRentals
    {
        public List<BookRental> BookList { get; set; }
        public double Sum { get; set; }

        public MyBookRentals()
        {
            BookList = new List<BookRental>();
            Sum = 0;
        }

        public void Add(BookRental bookRental)
            => BookList.Add(bookRental);

        public void PrintSummary()
        {
            foreach (var b in BookList)
            {
                Sum += b.CalculatePrice();
                Console.WriteLine(b.ToString());
            }
            Console.WriteLine("Total: {0}",Sum);
                
        }
    }
}
