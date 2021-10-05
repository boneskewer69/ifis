using System;

namespace MvcExample
{
    public class Controller
    {
        public Model Model { get; set; }
        public View View { get; set; }

        
        public Controller()
        {
            View = new View();
        }

        public Controller(Model model, View view)
        {
            Model = model;
            View = view;
        }


        public void Run()
        {
            var input = ' ';
            input = GetDesiredMenu();

            do
            {
                if (input == '1')
                    View.EnterCelsius();
                else if (input == '2')
                    View.EnterFarenheit();

                var tempString = Console.ReadLine();
                int.TryParse(tempString, out int temperature);

                if (temperature == null)
                    continue;

                Model = new Model();
                
                if (input == '1')
                    Model.TemperatureCelsius = temperature;
                else if (input == '2')
                    Model.TemperatureFarenheit = temperature;

                View.RenderResult(Model);
                
                input = GetDesiredMenu();
            } while  (input != '3');
        }

        public char GetDesiredMenu()
        {
            View.ShowMenu();
            var input = Console.ReadKey().KeyChar;
            Console.WriteLine();

            return input;
        }
    }
}
