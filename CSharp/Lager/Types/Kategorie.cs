using System;
using System.Collections.Generic;

namespace Lager.Types
{
    public class Kategorie
    {
        public string Kategoriename { get; set; }

        public Kategorie(string Kategoriename)
        {
            this.Kategoriename = Kategoriename;
        }

        public void addTheProdukt(Produkt dasProdukt)
        {

        }

        public void addGeschäft(Geschäft dasGeschäft)
        {
            
        }
    }
}
