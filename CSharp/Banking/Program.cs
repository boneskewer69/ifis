using System;

using Banking.Types;

namespace Banking
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Objekte (Kunden) erzeugen
            var kundeA = new Kunde("Hans", "Doppler");
            var kundeB = new Kunde("Hans", "Klon");

            // Objekte (Konten) erzeugen
            var giroKonto = new Girokonto(100.0, kundeA, 1000.0);
            var sparKonto = new Sparkonto(9000.0, kundeB);

            // Ausgabe
            Console.WriteLine("Ausgabe");
            Console.WriteLine(giroKonto); // Kontoauszug Girokonto
            Console.WriteLine(sparKonto); // Kontoauszug Sparkonto

            // Girokonto Transaktionen
            Console.WriteLine(Environment.NewLine + "Girokonto Transaktionen");
            giroKonto.Einzahlen(-120.0); // Negativen Wert auf GiroKonto einzahlen (sollte nicht klappen!)
            giroKonto.Auszahlen(120.0); // Von GiroKonto auszahlen
            giroKonto.Auszahlen(-120.0); // Von GiroKonto negativen Wert auszahlen (sollte nicht klappen!)
            giroKonto.Einzahlen(220.0); // Auf GiroKonto einzahlen

            // Sparkonto Transaktionen
            Console.WriteLine(Environment.NewLine + "Girokonto Transaktionen");
            sparKonto.Auszahlen(140.0); // Von SparKonto auszahlen
            sparKonto.VerfuegbarkeitUmschalten(); // Nicht mehr verfügbar sein
            sparKonto.Auszahlen(150.0); // Von SparKonto auszahlen (sollte nicht verfügbar sein)

            // Ausgabe vor Eigentumsveränderung
            Console.WriteLine(Environment.NewLine + "Ausgabe vor Eigentumsveränderung");
            Console.WriteLine(giroKonto);
            Console.WriteLine(sparKonto);

            // Eigentum verändern
            Console.WriteLine(Environment.NewLine + "Eigentum verändern");
            Console.WriteLine(giroKonto);
            giroKonto.UebertrageEigentum(kundeB); // Eigentümer des GiroKontos sollte jetzt kunde b sein
            sparKonto.UebertrageEigentum(kundeB); // Eigentümer des SparKontos sollte jetzt kunde b sein

            // Ausgabe nach Eigentumsveränderung
            Console.WriteLine(Environment.NewLine + "Ausgabe nach Eigentumsveränderung");
            Console.WriteLine(giroKonto);
            Console.WriteLine(sparKonto);

            // Statische Klassenelemente
            Console.WriteLine(Environment.NewLine + "Statische Klassenelemente");
            
            var zweitesGiroKonto = new Girokonto(400.0, kundeA, 1000.0);

            Console.WriteLine(giroKonto);
            Console.WriteLine(zweitesGiroKonto);

            giroKonto.SollzinsAbrechen(20, 700); // Sollzins abrechen für 20 Tage und einem Betrag von 700€ zu einem Zinssatz von 10%
            zweitesGiroKonto.SollzinsAbrechen(20, 900); // Sollzins abrechen für 20 Tage und einem Betrag von 700€ zu einem Zinssatz von 10%

            Girokonto.Zinssatz = 5.0; // Zinssatz (global) anpassen

            giroKonto.SollzinsAbrechen(20, 400); // Sollzins abrechen für 20 Tage und einem Betrag von 700€ zu einem Zinssatz von 5%
            zweitesGiroKonto.SollzinsAbrechen(20, 300); // Sollzins abrechen für 20 Tage und einem Betrag von 700€ zu einem Zinssatz von 10%

            Console.WriteLine(giroKonto);
            Console.WriteLine(zweitesGiroKonto);

            Console.WriteLine(Konto.Zaehler);
        }
    }
}
