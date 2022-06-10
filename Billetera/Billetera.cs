using System;
namespace Billeteras
{
	internal class Billetera
	{
        public uint BilleteDe10   { get; set; }
		public uint BilleteDe20   { get; set; }
		public uint BilleteDe50   { get; set; }
		public uint BilleteDe100  { get; set; }
		public uint BilleteDe200  { get; set; }
		public uint BilleteDe500  { get; set; }
		public uint BilleteDe1000 { get; set; }

		public Billetera(
			uint billeteDe10,
			uint billeteDe20,
			uint billeteDe50,
			uint billeteDe100,
			uint billeteDe200,
			uint billeteDe500,
			uint billeteDe1000
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

		private void VaciarBilletera()
        {
			BilleteDe10   = 0;
			BilleteDe20   = 0;
			BilleteDe50   = 0;
			BilleteDe100  = 0;
			BilleteDe200  = 0;
			BilleteDe500  = 0;
			BilleteDe1000 = 0;
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
			VaciarBilletera();
			b.VaciarBilletera();
			return nuevaBilletera;
        }
	}
}