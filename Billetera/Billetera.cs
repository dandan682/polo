using System;
namespace Billeteras
{
	internal class Billetera
	{
        public uint BilletesDe10   { get; set; }
		public uint BilletesDe20   { get; set; }
		public uint BilletesDe50   { get; set; }
		public uint BilletesDe100  { get; set; }
		public uint BilletesDe200  { get; set; }
		public uint BilletesDe500  { get; set; }
		public uint BilletesDe1000 { get; set; }

		public Billetera(
			uint billetesDe10,
			uint billetesDe20,
			uint billetesDe50,
			uint billetesDe100,
			uint billetesDe200,
			uint billetesDe500,
			uint billetesDe1000
			)
		{
			BilletesDe10   = billetesDe10;
			BilletesDe20   = billetesDe20;
			BilletesDe50   = billetesDe50;
			BilletesDe100  = billetesDe100;
			BilletesDe200  = billetesDe200;
			BilletesDe500  = billetesDe500;
			BilletesDe1000 = billetesDe1000;
		}

		private void VaciarBilletera()
        {
			BilletesDe10   = 0;
			BilletesDe20   = 0;
			BilletesDe50   = 0;
			BilletesDe100  = 0;
			BilletesDe200  = 0;
			BilletesDe500  = 0;
			BilletesDe1000 = 0;
		}

		public decimal Total()
        {
			return BilletesDe10   * 10
				+  BilletesDe20   * 20
				+  BilletesDe50   * 50
				+  BilletesDe100  * 100
				+  BilletesDe200  * 200
				+  BilletesDe500  * 500
				+  BilletesDe1000 * 1000;
		}

		public Billetera Combinar(Billetera b)
        {
			Billetera nuevaBilletera = new Billetera(
				BilletesDe10   + b.BilletesDe10,
				BilletesDe20   + b.BilletesDe20,
				BilletesDe50   + b.BilletesDe50,
				BilletesDe100  + b.BilletesDe100,
				BilletesDe200  + b.BilletesDe200,
				BilletesDe500  + b.BilletesDe500,
				BilletesDe1000 + b.BilletesDe1000
				);
			VaciarBilletera();
			b.VaciarBilletera();
			return nuevaBilletera;
        }
	}
}