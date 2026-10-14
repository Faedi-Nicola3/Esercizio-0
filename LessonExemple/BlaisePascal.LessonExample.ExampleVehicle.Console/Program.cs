using BlaisePascal.LessonExample.ExampleVehicle.Domain;
using System;
using System.Collections.Generic;
using System.Text;
public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Vehicle vehicle1 = new Vehicle("AA 000AA", 1, 50, 75);
            Console.WriteLine(vehicle1.LicensePlate);
            Console.WriteLine(vehicle1.OdometerKm);
            Console.WriteLine(vehicle1.DailyRate);
            Console.WriteLine(vehicle1.FuelLevelPercentage);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);

        }

        try
        {
            Vehicle vehicle = new Vehicle("abc");
            string license = vehicle.LicensePlate;
            Console.WriteLine(license);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}