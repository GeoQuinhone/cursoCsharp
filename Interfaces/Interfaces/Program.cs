﻿using System;
using System.Globalization;
using Interfaces.Entities;
using Interfaces.Services;
namespace Interfaces
{
    class Program
    {
         static void Main(string[] args)
        {
            solucaoSemInterface();
        }

        private static void solucaoSemInterface()
        {
            Console.WriteLine("Entre com a data do aluguel: ");
            Console.Write("Modelo do carro: ");
            string model = Console.ReadLine();
            Console.Write("Data de saída (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Data de retorno (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Digite o preço por hora: ");
            double hourPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o preço por dia: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));
            RentalService rentalService = new RentalService(hourPrice, day, new BrazilTaxService());

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("Invoice: ");
            Console.WriteLine(carRental.Invoice);

        }
    }
}