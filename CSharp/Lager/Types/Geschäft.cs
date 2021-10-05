using System;
using System.Collections.Generic;

namespace Lager.Types
{
    public class Geschäft
    {
        public int Geschäft_ID { get; set; }
        public Geschäft(int Geschäft_ID)
        {
            this.Geschäft_ID = Geschäft_ID;
        }

        public void addProdukt(Produkt dasProdukt)
        {

        }

        public void addKategorie(Kategorie dieKategorie)
        {
            
        }
    }
}
