using System;

namespace Banking.Types
{
    public class Sparkonto : Konto
    {
        public bool Verfuegbar { get; private set;}

        public Sparkonto(Iban iban,
            double startGuthaben,
            Kunde eigentuemer) : base(iban, startGuthaben, eigentuemer) { }
        public Sparkonto(double startGuthaben,
            Kunde eigentuemer) : base(startGuthaben, eigentuemer) { }

        public void VerfuegbarkeitUmschalten() { Verfuegbar = !Verfuegbar; }
        
        public override bool Auszahlen(double menge)
        {
            if (!Verfuegbar) return false;

            return base.Auszahlen(menge);
        }
    }
}
