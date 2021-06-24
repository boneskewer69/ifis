using System;

namespace Banking.Types
{
    public class Girokonto : Konto
    {
        public double DispoKredit { get; set; }
        private static double _zinssatz = 10.0;
        public static double Zinssatz
        {
            get => _zinssatz;
            set
            {
                Console.Write($"Zinsatz wurde von {_zinssatz}% auf {value}%");

                if (value > _zinssatz) Console.WriteLine(" erhöht.");
                else Console.WriteLine(" verringert.");

                _zinssatz = value;
            }
        }

        public Girokonto(Iban iban,
            double startGuthaben,
            Kunde eigentuemer,
            double dispoKredit) : base(iban, startGuthaben, eigentuemer) { DispoKredit = dispoKredit; }
        public Girokonto(double startGuthaben,
            Kunde eigentuemer,
            double dispoKredit) : base(startGuthaben, eigentuemer) { DispoKredit = dispoKredit; }

        public override bool Auszahlen(double menge)
        {
            if (menge < 0 || (Guthaben + DispoKredit) - menge < 0)
            {
                Console.WriteLine($"Kontostand und Dispokredit können die gewünschte Menge nicht decken oder der Betrag ist negativ.");
                return false;
            }

            Guthaben -= menge;
            Console.WriteLine($"Es wurden {menge}€ abgehoben. Neuer Kontostand: {Guthaben}€");

            return true;
        }
        
        public bool Auszahlen(double menge, double gebuehr)
        {
            if ((menge < 0 && gebuehr < 0) || (menge + gebuehr) > (Guthaben + DispoKredit))
            {
                Console.WriteLine("Kontostand kann die gewünschte Menge nicht decken oder der Betrag ist negativ.");
                return false;
            }

            Guthaben -= gebuehr;
            Console.WriteLine($"Es wurden {gebuehr}€ Gebühren abgebucht.");

            return Auszahlen(menge);
        }

        public void SollzinsAbrechen(int anzahlTage, double betrag)
        {
            var sollzinsen = Math.Round((anzahlTage * betrag * Zinssatz) / (360 * 100), 2);
            Guthaben -= sollzinsen;
            Console.WriteLine($"Sollzinsen im Umfang von {sollzinsen}€ werden abgebucht (Tage: {anzahlTage}, Betrag: {betrag}€, Zinssatz: {Zinssatz}%). Neuer Kontostand: {Guthaben}€");
        }
    }
}
