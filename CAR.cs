using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Syntax_Cars
{
    public class CAR
    {
        private string _type;
        private string _ID;
        private string _Brand;
        private string _Model;
        private int _Price;


        public CAR(string[] car)
        {
            if (car.Length >= 5)
            {
                _type = car[0];
                _ID = car[1];
                _Brand = car[2];
                _Model = car[3];
                _Price = Convert.ToInt32(car[4]);
            }
        }

        public CAR(string Type,
            string ID, 
            string Brand,
            string Model, 
            int price)
        {
            _type = Type;
            _ID = ID;
            _Brand = Brand;
            _Model = Model;
            _Price = price;
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public string Brand
        {
            get { return _Brand; }
            set { _Brand = value; }
        }

        public string Model
        {
            get { return _Model; }
            set { _Model = value; }
        }

        public int Price
        {
            get { return _Price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Please provide a positive value for the CAR price");
                }
                else
                {
                    _Price = value;
                }
            }
        }

        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
    }

   public class Sedan : CAR
    {
        private bool _Fuel;
        private bool _Diesel;
        private int _TrunkCapacity;

        public Sedan(string[] car) : base(car)
        {

            _TrunkCapacity = Convert.ToInt32(car[0]);
            _Fuel = Convert.ToBoolean(car[1]);
            _Diesel = Convert.ToBoolean(car[2]);
        }

        public Sedan(string Type,
            string ID,
            string Brand,
            string Model,
            int Price, 
            bool Fuel,
            bool Diesel,
            int TrunkCapacity) 
            : base(Type, ID, Brand, Model, Price)
        {
            _Fuel = Fuel;
            _Diesel = Diesel;
            _TrunkCapacity = TrunkCapacity;
        }

        public bool Fuel
        {
            get { return _Fuel; }
            set
            {
                if (_Fuel == true)
                {
                    _Fuel = value;
                }
                else
                {
                    _Fuel = false;
                }
            }
        }

        public bool Diesel
        {
            get { return _Diesel; }
            set
            {
                if (_Diesel == true)
                {
                    _Diesel = value;
                }
                else
                {
                    _Diesel = false;
                }
            }
        }

        public int TrunkCapacity
        {
            get { return _TrunkCapacity; }
            set
            {
                if (value < 0 || value > 500)
                {
                    throw new ArgumentException("Please fill in the TrunkCapacity blank with right information");
                }
                else
                {
                    _TrunkCapacity = value;
                }
            }
        }


    }

    public class Hybrid : CAR
    {
        private int _BatteryRange;
        private int _ChargingTime;
        private bool _RoofWindow;

        public Hybrid(string[] car) : base(car)
        {
            _BatteryRange = Convert.ToInt32(car[0]);
            _ChargingTime = Convert.ToInt32(car[1]);
            _RoofWindow = Convert.ToBoolean(car[2]);
        }

        public Hybrid(string Type,
            string ID,
            string Brand,
            string Model,
            int Price, 
            int BatteryRange,
            int ChargingTime, 
            bool RoofWindow) 
            : base(Type, ID, Brand, Model, Price)
        {
            _BatteryRange = BatteryRange;
            _ChargingTime = ChargingTime;
            _RoofWindow = RoofWindow;
        }

        public int BatteryRange
        {
            get { return _BatteryRange; }
            set
            {
                if (value < 0 || value > 5000)
                {
                    throw new ArgumentException("Please fill in the BatteryRange blank with right information");
                }
                else
                {
                    _BatteryRange = value;
                }
            }
        }

        public int ChargingTime
        {
            get { return _ChargingTime; }
            set
            {
                if (value < 0 || value > 20)
                {
                    throw new ArgumentException("Please fill in the ChargingTime blank with right information");
                }
                else
                {
                    _ChargingTime = value;
                }
            }
        }

        public bool RoofWindow
        {
            get { return _RoofWindow; }
            set
            {
                if (_RoofWindow == true)
                {
                    _RoofWindow = value;
                }
                else
                {
                    _RoofWindow = false;
                }
            }
        }


    }

    public class Sport : CAR
    {
        private int _Acceleration;
        private int _TopSpeed;
        private string _EngineSpecs;

        public Sport(string[] car) : base(car)
        {
            _Acceleration = Convert.ToInt32(car[0]);
            _TopSpeed = Convert.ToInt32(car[1]);
            _EngineSpecs = car[2];
        }

        public Sport(string Type,
            string ID,
            string Brand,
            string Model,
            int Price,
            int Acceleration,
            int TopSpeed,
            string EngineSpecs) 
            : base(Type, ID, Brand, Model, Price)
        {
            _Acceleration = Acceleration;
            _TopSpeed = TopSpeed;
            _EngineSpecs = EngineSpecs;
        }

        public int Acceleration
        {
            get { return _Acceleration; }
            set
            {
                if (value < 0 || value > 20)
                {
                    throw new ArgumentException("Please fill in the Acceleration blank with right information");
                }
                else
                {
                    _Acceleration = value;
                }
            }

        }

        public int TopSpeed
        {
            get { return _TopSpeed; }
            set
            {
                if (value < 0 || value > 400)
                {
                    throw new ArgumentException("Please fill in the TopSpeed blank with right information");
                }
                else
                {
                    _TopSpeed = value;
                }
            }
        }

        public string EngineSpecs
        {
            get { return _EngineSpecs; }
            set { _EngineSpecs = value; }
        }
    }
}
