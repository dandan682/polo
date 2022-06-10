using System;
namespace Billetera
{
	internal class Billetera
	{
        public int BilleteDe10   { get; set; }
		public int BilleteDe20   { get; set; }
		public int BilleteDe50   { get; set; }
		public int BilleteDe100  { get; set; }
		public int BilleteDe200  { get; set; }
		public int BilleteDe500  { get; set; }
		public int BilleteDe1000 { get; set; }

		public Billetera(
			int billeteDe10,
			int billeteDe20,
			int billeteDe50,
			int billeteDe100,
			int billeteDe200,
			int billeteDe500,
			int billeteDe1000
			)
		{
			BilleteDe10   = billeteDe10;
			BilleteDe20   = billeteDe20;
			BilleteDe50   = billeteDe50;
			BilleteDe100  = billeteDe100;
			BilleteDe200  = billeteDe200;
			BilleteDe500  = billeteDe500;
			BilleteDe1000 = billeteDe1000;
		}

		public decimal Total()
        {
			return BilleteDe10   * 10
				+  BilleteDe20   * 20
				+  BilleteDe50   * 50
				+  BilleteDe100  * 100
				+  BilleteDe200  * 200
				+  BilleteDe500  * 500
				+  BilleteDe1000 * 1000;
		}

		public Billetera Combinar(Billetera b)
        {
			Billetera nuevaBilletera = new Billetera(
				BilleteDe10   + b.BilleteDe10,
				BilleteDe20   + b.BilleteDe20,
				BilleteDe50   + b.BilleteDe50,
				BilleteDe100  + b.BilleteDe100,
				BilleteDe200  + b.BilleteDe200,
				BilleteDe500  + b.BilleteDe500,
				BilleteDe1000 + b.BilleteDe1000
				);
				return nuevaBilletera;
            }
        }
	}
}

