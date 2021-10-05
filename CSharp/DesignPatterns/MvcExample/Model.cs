using System;

namespace MvcExample
{
    public class Model
    {
        public double TemperatureCelsius
        {
            get => (TemperatureFarenheit - 32) / 1.8;
            set { TemperatureFarenheit = value * 1.8 + 32; }
        }
        public double TemperatureFarenheit { get; set; }
        
        public Model()
        {
            TemperatureFarenheit = 0.0;
        }

        public Model(double tempF)
        {
            TemperatureFarenheit = tempF;
        }
    }
}
