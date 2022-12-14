using ConsoleAppFlights.Data;
using System;

namespace ConsoleAppFlights.Ui.Commands
{
    class DestinationFlightsCommand : Command
    {
        private readonly DataContext _data;

        //ctor
        public DestinationFlightsCommand(DataContext data)
        {
            _data = data ?? throw new ArgumentNullException(nameof(data));
        }

        public override void Execute()
        {
            Console.WriteLine();
            Console.WriteLine("Введите город назначения:");

            var input = Console.ReadLine();
            var flights = _data.GetFlightsByDestination(input);

            if (flights.Count == 0)
            {
                Console.WriteLine("Извините, на данное направление рейсов нет!");
                return;
            }

            Console.WriteLine("Возможные варианты рейсов:");
            Console.WriteLine("-----------------------------");

            flights.ForEach(Console.WriteLine);

            Console.WriteLine("-----------------------------");
        }
    }
}
