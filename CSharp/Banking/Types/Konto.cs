using System;

namespace Banking.Types
{
    public class Konto
    {
        #region Felder
        private Kunde _eigentuemer;
        #endregion
        
        #region Eigenschaften
        /// <summary>
        /// Iban des Kontos
        /// </summary>
        public Iban Iban { get; }
        /// <summary>
        /// Aktueller Kontostand
        /// </summary>
        public double Guthaben { get; protected set; }
        /// <summary>
        /// Eigentümer des Kontos
        /// </summary>
        public Kunde Eigentuemer {
            get => _eigentuemer;
            private set
            {
                if (value == null) return;
                _eigentuemer = value;
            }
        }
        /// <summary>
        /// Anzahl an Konto Instanzen
        /// </summary>
        public static int Zaehler { get; private set; } = 0;
        #endregion

        #region Konstruktoren
        public Konto(Iban iban,
            double startGuthaben,
            Kunde eigentuemer)
        {
            Iban = iban;
            Guthaben = startGuthaben;
            Eigentuemer = eigentuemer;
            Zaehler += 1;
        }
        public Konto(double startGuthaben,
            Kunde eigentuemer)
        {
            Iban = new Iban();
            Guthaben = startGuthaben;
            Eigentuemer = eigentuemer;
            Zaehler += 1;
        }
        #endregion

        #region Methoden
        /// <summary>
        /// Gibt die relevanten Klassenproperties in einem String aus
        /// </summary>
        public override string ToString()
        {
            return $"Kontoinhaber: {Eigentuemer}; IBAN: {Iban}; Kontostand: {Guthaben}€";
        }

        /// <summary>
        /// Gutschrift auf Konto buchen (Wert darf nicht negativ sein)
        /// </summary>
        /// <param name="menge">Wert der eingezahlt werden soll</param>
        public bool Einzahlen(double menge)
        {
            if (menge < 0)
            {
                Console.WriteLine("Negative Beträge dürfen nicht eingezahlt werden!");
                return false;
            }
                
            Guthaben += menge;
            Console.WriteLine($"Es wurden {menge}€ eingezahlt. Neuer Kontostand: {Guthaben}€");
            return true;
        }

        /// <summary>
        /// Auszahlung des Guthabens von Konto (ist nur möglich, wenn der Kontostand die Abbuchung decken kann)
        /// </summary>
        /// <param name="menge">Wert der abgebucht werden soll</param>
        /// <returns>Gibt zurück ob die Transaktion erfolgreich war</returns>
        public virtual bool Auszahlen(double menge)
        {
            if (Guthaben - menge < 0 || menge < 0)
            {
                Console.WriteLine($"Kontostand ist nicht ausreichend um den Betrag {menge}€ abzuheben oder der Betrag ist negativ!");
                return false;
            }

            Guthaben -= menge;
            Console.WriteLine($"Es wurden {menge}€ abgehoben. Neuer Kontostand: {Guthaben}€");

            return true;
        }

        /// <summary>
        /// Überträgt das Eigentum eines Kontos an einen anderen Kunden
        /// </summary>
        /// <param name="kunde">Neuer Kontoinhaber</param>
        public void UebertrageEigentum(Kunde kunde)
        {
            if (kunde == null) throw new ArgumentNullException("Kunde darf nicht null sein!");
            
            Console.WriteLine($"Ändere Eigentümer von {Eigentuemer} to {kunde}!");
            Eigentuemer = kunde;
        }
        #endregion
    }
}
