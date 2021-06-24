using System;

namespace Banking.Types
{
    public class Iban
    {
        private int _pruefziffer;
        private int _bankleitzahl;
        private long _kontonummer;

        public Laenderkennzeichen Laenderkennzeichen { get; }
        public int Pruefziffer
        {
            get => _pruefziffer;
            private set
            {
                if (value.ToString().Length != 2)
                    throw new ArgumentException("Die Pruefziffer muss zwei Zeichen lang sein.");
                _pruefziffer = value;
            }
        }
        public int Bankleitzahl
        {
            get => _bankleitzahl;
            private set
            {
                if (value.ToString().Length != 6)
                    throw new ArgumentException("Die Bankleitzahl muss sechs Zeichen lang sein.");
                _bankleitzahl = value;
            }
        }
        public long Kontonummer
        {
            get => _kontonummer;
            private set
            {
                if (value.ToString().Length <= 10)
                    throw new ArgumentException($"Die Kontonummer darf maximal zehn Zeichen lang sein. {value.GetType()} {value} {value.ToString().Length}");
                _kontonummer = value;
                
            }
        }
        public string VolleIban => $"{Laenderkennzeichen}{Pruefziffer}{Bankleitzahl}{Kontonummer}";

        public Iban()
        {
            var random = new Random(); // Um Bankleitzahl und Kontonummer zufällig zu generieren

            Laenderkennzeichen = Laenderkennzeichen.DE;
            Pruefziffer = 23;
            Bankleitzahl = random.Next(100000, 999999);
            Kontonummer = ((long)random.Next(100000000, 999999999));
        }
        public Iban(Laenderkennzeichen laenderkennzeichen,
            int pruefziffer,
            int bankleitzahl,
            long kontonummer)
        {
            Laenderkennzeichen = laenderkennzeichen;
            Pruefziffer = pruefziffer;
            Bankleitzahl = bankleitzahl;
            Kontonummer = kontonummer;
        }

        public override string ToString()
        {
            return VolleIban;
        }
    }
}
