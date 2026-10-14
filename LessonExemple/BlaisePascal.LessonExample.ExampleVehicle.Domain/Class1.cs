using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Runtime.Serialization;
using System.Text;

namespace BlaisePascal.LessonExample.ExampleVehicle.Domain
{
     public class Vehicle
    {
        private int _odometerKm;
        private double _dailyRate;
        private double _fuelLevelPercentage;

        public string LicensePlate
        {
            get;
            private set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException($"value {value} cannot be whitespace or null");

                string valueNoSpace = value.Replace(" ", "").ToUpper();

                if (valueNoSpace.Length != 7)
                    throw new ArgumentException($"value {value} is not a valid license plate");
                field = valueNoSpace;
            }
        }
        public int OdometerKm
        {
            get
            { return _odometerKm; }
            private set
            {
                if (value < 0)
                    throw new ArgumentException($"value not allowed {nameof(OdometerKm)}: {value} ");

                _odometerKm = value;
            }
        }
        public double DailyRate
        {
            get
            { return _dailyRate; }
            private set
            {
                if (value < 0)
                    throw new ArgumentException($"value not allowed {nameof(DailyRate)}: {value} ");
                _dailyRate = value;
            }
        }

        public double FuelLevelPercentage
        {
            get
            { return _fuelLevelPercentage; }
            private set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException($"value not allowed {nameof(FuelLevelPercentage)}: {value} ");

                _fuelLevelPercentage = value;
            }
        }

        public Vehicle(string licensePlate)
        {
            LicensePlate = licensePlate;        
        }

        public Vehicle(string licensePlate, int odometerKm,
            double dailyRate, double fuelLevelPercentage)
        {
            LicensePlate = licensePlate;
            OdometerKm = odometerKm; 
            DailyRate = dailyRate;
            FuelLevelPercentage = fuelLevelPercentage;
        }

        public void RegisterData(int consumedKm, double consumedFuel)
        {
            if (consumedKm <= 0)
                throw new ArgumentException($"value not allowed {nameof(consumedKm)}: {consumedKm} ");
            if (consumedFuel < 0)
                throw new ArgumentException($"value not allowed {nameof(consumedFuel)}: {consumedFuel} ");

            OdometerKm += consumedKm; 
            FuelLevelPercentage -= consumedFuel; 
        }


    }
}