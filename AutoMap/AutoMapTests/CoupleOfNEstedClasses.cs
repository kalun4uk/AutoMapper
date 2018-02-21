namespace AutoMapTests
{
    public class CoupleOfNEstedClasses
    {
        /// <summary>
        /// Class with nested class and nested class: class - nested - nested
        /// </summary>
        public class Plane
        {
            public string Type { get; set; }
            public string Model { get; set; }
            public OnBoard onBoard { get; set; }

            public Plane()
            {
                onBoard = new OnBoard() {CoupleOfChairs = 0, LightObj = new OnBoard.Light() {LightPower = 0} };
            }

            public class OnBoard
            {
                public Light LightObj { get; set; }
                public int CoupleOfChairs { get; set; }

                public OnBoard()
                {
                    LightObj = new Light() {LightPower = 0};
                }

                public class Light
                {
                    public int LightPower { get; set; }
                }
            }
        }
    }
}
