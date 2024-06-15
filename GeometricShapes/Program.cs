namespace GeometricShapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }

        public static int mainMenu() 
        {
            Console.WriteLine("MAIN MENU");
            Console.WriteLine("1. AREA CALCULATION");
            Console.WriteLine("2. PERIMETER CALCULATION");
            Console.WriteLine("3. EXIT");
            Console.WriteLine("SELECT OPERATION ACCORDING TO FOLLOWING NUMBERS: ");
            int selectionNumber = int.Parse(Console.ReadLine());
            return selectionNumber;
        }
        public static int shapeSelectionSubMenu(int typeOfCalculationOperation)
        {
            Console.WriteLine("SHAPE SELECTION SUB MENU");
            Console.WriteLine("1. SQUARE");
            Console.WriteLine("2. RECTANGLE");
            Console.WriteLine("3. TRIANGLE");
            Console.WriteLine("4. CIRCLE");
            Console.WriteLine("5. MAIN MENU");
            if(typeOfCalculationOperation == 1)
            {
                Console.WriteLine("SELECT SHAPE TYPE FOR AREA CALCULATION: ");
            }
            else
            {
                Console.WriteLine("SELECT SHAPE TYPE FOR PERIMETER CALCULATION: ");
            }
            
            int selectionNumber = int.Parse(Console.ReadLine());
            return selectionNumber;
        }
       

        /// <summary>
        /// AREA METHODS
        /// </summary>
        /// <param name="lengthOfSide"></param>
        /// <returns></returns>
        public static double areaOfSquare()
        {
            Console.WriteLine("ENTER LENGTH OF SIDE OF SQUARE: ");
            double lengthOfSide = double.Parse(Console.ReadLine());
            return lengthOfSide*lengthOfSide;
        }
        public static double areaOfRectangle()
        {
            Console.WriteLine("ENTER LENGTH OF RECTANGLE: ");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("ENTER WIDTH OF RECTANGLE: ");
            double width = double.Parse(Console.ReadLine());
            return length * width;
        }
        public static double areaOfTriangle()
        {
            Console.WriteLine("ENTER LENGTH OF HYPOTENUSE OF TRIANGLE: ");
            double lengthOfHypotenuse = double.Parse(Console.ReadLine());
            Console.WriteLine("ENTER LENGTH OF HEIGHT OF TRIANGTLE: ");
            double height = double.Parse(Console.ReadLine());
            return (lengthOfHypotenuse * height)/2;
        }
        public static double areaOfCircle()
        {
            Console.WriteLine("ENTER RADIUS OF CIRCLE: ");
            double lengthOfRadius = double.Parse(Console.ReadLine());
            return Math.PI * lengthOfRadius * lengthOfRadius;
        }

        /// <summary>
        /// PERIMETER METHODS
        /// </summary>
        /// <param name="lengthOfSide"></param>
        /// <returns></returns>
        public static double perimeterOfSquare()
        {
            Console.WriteLine("ENTER LENGTH OF SIDE OF SQUARE: ");
            double lengthOfSide = double.Parse(Console.ReadLine());
            return lengthOfSide * 4;
        }
        public static double perimeterOfRectangle()
        {
            Console.WriteLine("ENTER LENGTH OF RECTANGLE: ");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("ENTER WIDTH OF RECTANGLE: ");
            double width = double.Parse(Console.ReadLine());
            return (length + width) * 2;
        }
        public static double perimeterOfTriangle()
        {
            Console.WriteLine("ENTER LENGTH OF HYPOTENUSE OF TRIANGLE: ");
            double lengthOfHypotenuse = double.Parse(Console.ReadLine());
            Console.WriteLine("ENTER LENGTH OF FIRST SIDE OF TRIANGTLE: ");
            double sideOneOfTriangle = double.Parse(Console.ReadLine());
            Console.WriteLine("ENTER LENGTH OF SECOND SIDE OF TRIANGTLE: ");
            double sideTwoOfTriangle = double.Parse(Console.ReadLine());

            return lengthOfHypotenuse + sideOneOfTriangle + sideTwoOfTriangle;
        }
        public static double perimeterOfCircle()
        {
            Console.WriteLine("ENTER RADIUS OF CIRCLE: ");
            double lengthOfRadius = double.Parse(Console.ReadLine());
            return Math.PI * lengthOfRadius * 2;
        }

    }
}
