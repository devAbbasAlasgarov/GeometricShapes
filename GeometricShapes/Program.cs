namespace GeometricShapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int selectionCalculationType = 0;
            int selectionFigureShape = 0;
            bool replyRecalculation = false;
            do
            {
                selectionCalculationType = mainMenu();
                
                if (selectionCalculationType == 1)
                {
                    do
                    {
                        selectionFigureShape = shapeSelectionSubMenu(selectionCalculationType);
                        switch (selectionFigureShape)
                        {
                            case 1:
                                do
                                {
                                    replyRecalculation = printResultMessage(selectionCalculationType, selectionFigureShape);
                                } while (replyRecalculation);
                               
                                break;
                            case 2:
                                do
                                {
                                    replyRecalculation = printResultMessage(selectionCalculationType, selectionFigureShape);
                                } while (replyRecalculation) ;
                                break;
                            case 3:
                                do
                                {
                                    replyRecalculation = printResultMessage(selectionCalculationType, selectionFigureShape);
                                } while (replyRecalculation) ;
                                break;
                            case 4:
                                do
                                {
                                    replyRecalculation = printResultMessage(selectionCalculationType, selectionFigureShape);
                                } while (replyRecalculation) ;
                                break;
                        }
                        

                    } while (selectionFigureShape != 5);
                }
                else if(selectionCalculationType == 2)
                {
                    do
                    {
                        selectionFigureShape = shapeSelectionSubMenu(selectionCalculationType);
                        switch (selectionFigureShape)
                        {
                            case 1:
                                do
                                {
                                    replyRecalculation = printResultMessage(selectionCalculationType, selectionFigureShape);
                                } while (replyRecalculation);
                                break;
                            case 2:
                                do
                                {
                                    replyRecalculation = printResultMessage(selectionCalculationType, selectionFigureShape);
                                } while (replyRecalculation) ;
                                break;
                            case 3:
                                do
                                {
                                    replyRecalculation = printResultMessage(selectionCalculationType, selectionFigureShape);
                                } while (replyRecalculation) ;
                                break;
                            case 4:
                                do
                                {
                                    replyRecalculation = printResultMessage(selectionCalculationType, selectionFigureShape);
                                } while (replyRecalculation) ;
                                break;
                        }
                    } while (selectionFigureShape != 5);
                }
                else if (selectionCalculationType == 3)
                {
                    exitMessage();
                }
            } while (true);
           
        }

        public static int mainMenu() 
        {
            Console.WriteLine("MAIN MENU \n1. AREA CALCULATION\n2. PERIMETER CALCULATION\n3. EXIT\nSELECT OPERATION ACCORDING TO FOLLOWING NUMBERS:");
            int selectionCalculationType = int.Parse(Console.ReadLine());
            return selectionCalculationType;
        }
        public static int shapeSelectionSubMenu(int typeOfCalculationOperation)
        {
            Console.WriteLine("SHAPE SELECTION SUB MENU\n1. SQUARE\n2. RECTANGLE\n3. TRIANGLE\n4. CIRCLE\n5. MAIN MENU");
            if(typeOfCalculationOperation == 1)
            {
                Console.WriteLine("SELECT SHAPE TYPE FOR AREA CALCULATION: ");
            }
            else
            {
                Console.WriteLine("SELECT SHAPE TYPE FOR PERIMETER CALCULATION: ");
            }
            
            int selectionFigureShape = int.Parse(Console.ReadLine());
            return selectionFigureShape;
        }
        public static void exitMessage()
        {
            Console.WriteLine("ARE YOU SURE TO EXIT? (y - FOR YES, n - FOR NO)");
            string responseForExit = Console.ReadLine();
            if (responseForExit == "y")
            {
                Console.WriteLine("CALCULATION FINISHED!");
                Environment.Exit(0);
            }
        }
        public static bool printResultMessage(int operationNumber, int figureShapeNumber)
        {
            string operationName=string.Empty;
            string shapeName;
            double result=0;
            string replyForRecalculation=string.Empty;
            bool reply = false;
            if (operationNumber == 1)
            {
                operationName = "AREA";
            }
            else if (operationNumber == 2)
            {
                operationName = "PERIMETER";
            }

            if(operationNumber==1 && figureShapeNumber == 1)
            {
                result = areaOfSquare();
            }
            else if (operationNumber == 1 && figureShapeNumber == 2)
            {
                result = areaOfRectangle();
            }
            else if (operationNumber == 1 && figureShapeNumber == 3)
            {
                result = areaOfTriangle();
            }
            else if (operationNumber == 1 && figureShapeNumber == 4)
            {
                result = areaOfCircle();
            }
            else if (operationNumber == 2 && figureShapeNumber == 1)
            {
                result = perimeterOfSquare();
            }
            else if (operationNumber == 2 && figureShapeNumber == 2)
            {
                result = perimeterOfRectangle();
            }
            else if (operationNumber == 2 && figureShapeNumber == 3)
            {
                result = perimeterOfTriangle();
            }
            else if (operationNumber == 2 && figureShapeNumber == 4)
            {
                result = perimeterOfCircle();
            }

            switch (figureShapeNumber)
            {
                case 1:
                    {
                        shapeName = "SQUARE";
                        Console.WriteLine($"THE {operationName} OF {shapeName} IS {result}.");
                        Console.WriteLine($"DO YOU WANT TO CALCULATE {operationName} FOR {shapeName}? (y - FOR YES, n - FOR NO)");
                        replyForRecalculation = Console.ReadLine();
                        reply = (replyForRecalculation == "y") ? true : false;
                    }
                    break;
                case 2:
                    {
                        shapeName = "RECTANGLE";
                        Console.WriteLine($"THE {operationName} OF {shapeName} IS {result}.");
                        Console.WriteLine($"DO YOU WANT TO CALCULATE {operationName} FOR {shapeName}? (y - FOR YES, n - FOR NO)");
                        replyForRecalculation = Console.ReadLine();
                        reply = (replyForRecalculation == "y") ? true : false;
                    }
                    break;
                case 3:
                    {
                        shapeName = "TRIANGLE";
                        Console.WriteLine($"THE {operationName} OF {shapeName} IS {result}.");
                        Console.WriteLine($"DO YOU WANT TO CALCULATE {operationName} FOR {shapeName}? (y - FOR YES, n - FOR NO)");
                        replyForRecalculation = Console.ReadLine();
                        reply = (replyForRecalculation == "y") ? true : false;
                    }
                    break;
                case 4:
                    {
                        shapeName = "CIRCLE";
                        Console.WriteLine($"THE {operationName} OF {shapeName} IS {result}.");
                        Console.WriteLine($"DO YOU WANT TO CALCULATE {operationName} FOR {shapeName}? (y - FOR YES, n - FOR NO)");
                        replyForRecalculation = Console.ReadLine();
                        reply = (replyForRecalculation == "y") ? true : false;
                    }
                    break;
            }
            return reply;
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
