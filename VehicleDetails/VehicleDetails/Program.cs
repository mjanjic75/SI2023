namespace VehicleDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Car myCar = new Car();
            InputVehicleDetails(myCar);
            WriteVehicleDetails(myCar);
            Console.ReadKey();
        }


        public static void InputVehicleDetails(Car c)
        {
            Console.WriteLine("=============UNOS PODATAKA ZA AUTO===========");
            Console.WriteLine("Unesite naziv brenda: ");
            c.Brand = Console.ReadLine();
            Console.WriteLine("Unesite naziv modela: ");
            c.Model = Console.ReadLine();
            Console.WriteLine("Unesite boju: ");
            c.Color = Console.ReadLine();
            Console.WriteLine("Unesite broj vrata: ");
            c.NumberOfDoors = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesite snagu motora: ");
            c.Power = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Unesite maksimalnu brzinu: ");
            c.MaxSpeed = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Unesite ubrzanje: ");
            c.Acceleration = decimal.Parse(Console.ReadLine());
        }

        public static void WriteVehicleDetails(Car c)
        {
            Console.WriteLine("=============ISPIS PODATAKA ZA AUTO===========");
            Console.WriteLine("Brend:\t{0}\nModel:\t{1}\nBoja:\t{2}",
                c.Brand, c.Model, c.Color);
        }
    }


    public class Vehicle
    {
        public string Brand {get; set;}
        public string Model { get; set; }
        public string Color { get; set; }
        public int Power { get; set; }
        public int MaxSpeed { get; set; }
        public decimal Acceleration { get; set; }
    }

    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Car()
        {
            this.NumberOfDoors = 4;
        }
    }
}