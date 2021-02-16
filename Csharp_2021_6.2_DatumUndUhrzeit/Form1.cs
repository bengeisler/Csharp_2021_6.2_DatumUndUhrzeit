using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_2021_6._2_DatumUndUhrzeit
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Console.WriteLine("DateTime.Now: " + DateTime.Now);
			Console.WriteLine("DateTime.Today: " + DateTime.Today);
			Console.WriteLine("Datum kurz: " + DateTime.Today.ToShortDateString());
			Console.WriteLine("Uhrzeit kurz: " + DateTime.Now.TimeOfDay);
			Console.WriteLine("Uhrzeit kurz: " + DateTime.Now.ToShortTimeString());

			// Eigenes Datum erstellen
			DateTime meinDatum = new DateTime(2021, 02, 16);
			Console.WriteLine("Eigenes Datum anzeigen:");
			Console.WriteLine(meinDatum);
			Console.WriteLine(meinDatum.ToShortDateString());

			// Tag der Woche ausgeben
			Console.WriteLine("Tag der Woche: " + meinDatum.DayOfWeek);
			Console.WriteLine("Tag des Jahres: " +  meinDatum.DayOfYear);

			// Mit Datum & Uhrzeit rechnen
			meinDatum = meinDatum.AddHours(3);
			Console.WriteLine("Nach Addition von 3 Stunden: " + meinDatum);

			meinDatum = meinDatum.AddDays(2);
			Console.WriteLine("Nach Addition von 2 Tagen: " + meinDatum);

			meinDatum = meinDatum.AddDays(-5);
			Console.WriteLine("Nach Subtraktion von 5 Tagen: " + meinDatum);

			// Daten miteinander verrechnen
			DateTime d1 = DateTime.Now;
			DateTime d2 = new DateTime(2005, 02, 14);

			var ergebnis = d1.Subtract(d2);
			Console.WriteLine("Die Differenz der Daten beträgt: " + ergebnis);
			Console.WriteLine("Die Differenz beträgt: " +
				ergebnis.Days + " Tage, " + 
				ergebnis.Hours + " Stunden, " + 
				ergebnis.Minutes + " Minuten");


			var differenzInJahren = d1.Year - d2.Year;
			var restdifferenz = d1.Subtract(new DateTime(d1.Year, 5, 19));
			Console.WriteLine("Differenz in Jahren: " + differenzInJahren);
			Console.WriteLine("Restdifferenz: " + restdifferenz);
		}

		private void datDatum_ValueChanged(object sender, EventArgs e)
		{
			Console.WriteLine(datDatum.Value.ToShortDateString());
		}

		private void datUhrzeit_ValueChanged(object sender, EventArgs e)
		{
			Console.WriteLine(datUhrzeit.Value.ToShortTimeString());
		}
	}
}
