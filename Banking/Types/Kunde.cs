using System;

namespace Banking.Types
{
    public class Kunde
    {
        #region Eigenschaften
        /// <summary>
        /// Vorname eines Kundens
        /// </summary>
        private string Vorname { get; set; }
        /// <summary>
        /// Nachname eines Kundens
        /// </summary>
        private string Nachname { get; set; }
        private string VollerName => Nachname + ", " + Vorname;
        #endregion
        
        #region Konstruktoren
        /// <summary>
        /// Standardkonstruktor
        /// </summary>
        public Kunde(string vorname, string nachname)
        {
            Vorname = vorname;
            Nachname = nachname;
        }
        #endregion

        #region Methoden
        public override string ToString()
        {
            return VollerName;
        }
        #endregion
    }
}
