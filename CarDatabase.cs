using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Diagnostics.Eventing.Reader;


namespace Syntax_Cars
{
    public static class CarDatabase
    {
        public static Dictionary<string, List<CAR>> allCars = new Dictionary<string, List<CAR>>();
        public static List<Sedan> sedansList = new List<Sedan>();
        public static List<Hybrid> hybridsList = new List<Hybrid>();
        public static List<Sport> sportsList = new List<Sport>();

        public static C GetCars<C>(string ID, string Type) where C : CAR
        {
            

            IList<C> carList = null;

            if (Type.Trim() == "Sedan")
            {
                carList = sedansList as IList<C>;
            }
            else if (Type.Trim() == "Hybrid")
            {
                carList = hybridsList as IList<C>;
            }
            else if (Type.Trim() == "Sport")
            {
                carList = sportsList as IList<C>;
            }

            if (carList != null)
            {
                foreach (var car in carList)
                {
                    if (car.ID == ID)
                    {
                        return car;
                    }
                }
            }

            return null;
        }

        public static List<CAR> GetCarsByType(string Type)
        {
            return allCars[Type.Trim()];
        }

        public static CAR GetCars(string ID,
            string Type,
            string Model,
            string Brand, 
            int Price)
        {
            foreach (var carList in allCars.Values)
            {
                foreach (var car in carList)
                {
                    if (car.ID == ID &&
                        car.Model == Model &&
                        car.Brand == Brand &&
                        car.Price == Price &&
                        car.Type == Type)
                    {
                        return car;
                    }
                }
            }

            return null;
        }

        public static Sedan GetSedan(string ID,
            string Type,
            string Brand,
            string Model,
            int Price,
            bool Fuel,
            bool Diesel,
            int TrunkCapacity)
        {
            foreach (var carList in allCars.Values)
            {
                foreach (var car in carList)
                {
                    if (car.ID == ID &&
                        car.Model == Model &&
                        car.Brand == Brand &&
                        car.Price == Price &&
                        car.Type == Type &&
                        car is Sedan sedan &&
                            sedan.Fuel == Fuel &&
                            sedan.Diesel == Diesel &&
                            sedan.TrunkCapacity == TrunkCapacity)
                    {
                        return sedan;
                    }

                }
            }
            return null;
        }

        public static Hybrid GetHybrid(string ID,
            string Type,
            string Brand,
            string Model,
            int Price,
            int BatteryRange,
            int ChargingTime,
            bool RoofWindow)
        {
            foreach (var carList in allCars.Values)
            {
                foreach (var car in carList)
                {
                    if (car.ID == ID &&
                        car.Model == Model &&
                        car.Brand == Brand &&
                        car.Price == Price &&
                        car.Type == Type &&
                        car is Hybrid hybrid &&
                            hybrid.BatteryRange == BatteryRange &&
                            hybrid.ChargingTime == ChargingTime &&
                            hybrid.RoofWindow == RoofWindow)

                    {
                        return hybrid;
                    }

                }
            }
            return null;
        }

        public static Sport GetSport(string ID,
            string Type,
            string Brand, 
            string Model, 
            int Price, 
            int Acceleration, 
            int TopSpeed, 
            string EngineSpecs)
        {
            foreach (var carList in allCars.Values)
            {
                foreach (var car in carList)
                {
                    if (car.ID == ID &&
                        car.Model == Model &&
                        car.Brand == Brand &&
                        car.Price == Price &&
                        car.Type == Type &&
                        car is Sport sport &&
                            sport.Acceleration == Acceleration &&
                            sport.TopSpeed == TopSpeed &&
                            sport.EngineSpecs == EngineSpecs)
                    {
                        return sport;
                    }

                }
            }
            return null;
        }

        private static void AddToSpecificList<C>(C car) where C : CAR
        {
            if (car is Sedan)
            {
                sedansList.Add((Sedan)(object)car);
            }
            else if (car is Hybrid)
            {
                hybridsList.Add((Hybrid)(object)car);
            }
            else if (car is Sport)
            {
                sportsList.Add((Sport)(object)car);
            }
        }

        private static void WriteToFile<C>(C car) where C : CAR
        {
            string carData = $"{car.ID};{car.Model};{car.Brand};{car.Price};{car.Type};";

            if (car is Sedan)
            {
                Sedan sedan = car as Sedan;
                carData += $"{sedan.Fuel};{sedan.Diesel};{sedan.TrunkCapacity}";
            }
            else if (car is Hybrid)
            {
                Hybrid hybrid = car as Hybrid;
                carData += $"{hybrid.BatteryRange};{hybrid.ChargingTime};{hybrid.RoofWindow}";
            }
            else if (car is Sport)
            {
                Sport sport = car as Sport;
                carData += $"{sport.Acceleration};{sport.TopSpeed};{sport.EngineSpecs}";
            }

            using (StreamWriter sw = File.AppendText("CarDataBase.txt"))
            {
                sw.WriteLine(carData);
            }
        }

        public static void AddCars<C>(string type, C car) where C : CAR
        {
            if (!allCars.ContainsKey(type))
            {
                allCars.Add(type, new List<CAR>());
            }
            allCars[type].Add(car);

            AddToSpecificList(car);
            WriteToFile(car);
        }

        public static void ReadFromFile()
        {
            allCars.Clear();

            using (FileStream fs = new FileStream("CarDatabase.txt", FileMode.Open, FileAccess.Read))
            using (StreamReader sr = new StreamReader(fs))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine().Trim();
                    string[] splittedline = line.Split(';');
                    string type = splittedline[3];

                    if (!allCars.ContainsKey(type))
                    {
                        allCars.Add(type, new List<CAR>());
                    }

                    CAR genericCar = null;

                    switch (type.Trim())
                    {
                        case "Sedan":
                            Sedan newSedan = new Sedan(splittedline);
                            sedansList.Add(newSedan);
                            genericCar = newSedan;
                            break;
                        case "Hybrid":
                            Hybrid newHybrid = new Hybrid(splittedline);
                            hybridsList.Add(newHybrid);
                            genericCar = newHybrid;
                            break;
                        case "Sport":
                            Sport newSport = new Sport(splittedline);
                            sportsList.Add(newSport);
                            genericCar = newSport;
                            break;
                    }

                    if (genericCar != null)
                    {
                        allCars[type].Add(genericCar);
                    }
                }
            }
        }

       
    }
}
