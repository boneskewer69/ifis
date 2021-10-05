using System;

namespace MvcExample
{
    public class View
    {
        public Model Model { get; set; }
        public Controller Controller { get; set; }

        
        public View()
        {
            
        }

        public View(Model model)
        {
            Model = model;
        }


        public void ShowMenu()
        {
            Console.WriteLine("Auswahl:");
            Console.WriteLine("<1> Neue Temperatur in Celsius eingeben");
            Console.WriteLine("<2> Neue Temperatur in Fahrenheit eingeben");
            Console.WriteLine("<3> ENDE");
        }

        public void EnterCelsius()
        {
            Console.WriteLine("Bitte die Temperatur in Celsius: ");
        }

        public void EnterFarenheit()
        {
            Console.WriteLine("Bitte die Temperatur in Fahrenheit: ");
        }

        public void RenderResult(Model model)
        {
            Console.WriteLine("TEMPERATUR-UMRECHNUNG <Version 1.0>");
            Console.WriteLine($"Temperatur in Celsius:   \t{model.TemperatureCelsius}");
            Console.WriteLine($"Temperatur in Fahrenheit:\t{model.TemperatureFarenheit}");
        }
    }
}
