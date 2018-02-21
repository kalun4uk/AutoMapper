namespace AutoMapTests
{
    /// <summary>
    /// Class with nested class and nested objects of that classes
    /// </summary>
    public class Car
    {
        public Car()
        {
            carWheel = new Wheel() { Size = 0, name = null };
        }

        public class Wheel
        {
            public int Size { get; set; }
            public string name { get; set; }
        }
        public int Model { get; set; }
        public string name { get; set; }
        public Wheel carWheel { get; set; }


    }

    public class Truck
    {
        public int model { get; set; }
        public string name { get; set; }
        public Wheel carWheel { get; set; }
        public class Wheel
        {
            public int Size { get; set; }
            public string name { get; set; }
        }

        public Truck()
        {
            carWheel = new Wheel() { Size = 0, name = null };
        }
    }
    }
