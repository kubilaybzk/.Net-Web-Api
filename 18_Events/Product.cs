using System;
namespace _18_Events
{

    public delegate void StockControl();

    public class Product
	{
		private int _stock;

		public Product(int stock){_stock = stock;}

        //Event tanımlamak için delegate olarak ve event tipinde tanımla yapabiliriz.

        public event StockControl StockControlEvent;

		public string ProductName { get; set; }

        public int Stock {

		get{return _stock;}

		set
		{
			_stock = value;
			if(value<=15 && StockControlEvent != null){
					StockControlEvent();
			}}
		}

		public void Sell(int amount)
		{
			Stock = Stock- amount;
			Console.WriteLine("{1} Stock amounth: {0}", Stock,ProductName);
		}



    }
}

