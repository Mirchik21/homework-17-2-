namespace Homework_17_2zad_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our 18th building Avangard, to your attention we present our - the best elevator -");
            Elevator my_elevator = new Elevator();
        }
    }
    class Elevator
    {
        int currentFloor;
        int capacity;
        int maxFloor;
        string move;
        string capweigth;

        public Elevator()
        {
            Random rand = new Random();
            currentFloor = rand.Next(1, 18 + 1);
            Printfloor(currentFloor); 
            maxFloor = 18;
            capacity = 200;
            for (int i = currentFloor; i < maxFloor; i++)
            {
                MoveToFloor();
            }
            

        }
        public void MoveToFloor()
        {
            int userFloor;
            int userCapacity;
            Console.WriteLine("To select a floor press from 1 to 18, the moves floor is: ");
            userFloor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("To select a weight press from 1 to 200, the weight is: ");
            userCapacity = Convert.ToInt32(Console.ReadLine());

            if (userFloor < currentFloor) 
            {
                for (int i = currentFloor; i > userFloor; i--)
                {
                    Printfloor(i);
                }
                Printfloor(userFloor);
                currentFloor = userFloor;
               
            }
            if (userFloor > currentFloor)
            {
                for (int i = currentFloor; i < userFloor; i++)
                {
                    Printfloor(i);
                }
                Printfloor(userFloor);
                currentFloor = userFloor;

            }


         

            IsAllowableFloor(currentFloor);
            IsAllowableWeight(userCapacity);


        }
        public void IsAllowableWeight(int weight)
        {
            bool cap = false;
            if (weight <= capacity)
            {
                cap = true;
                Console.WriteLine(cap);
            }
            else
            { 
                cap = false;
                Console.WriteLine(cap);
            }        
        }
        public void IsAllowableFloor(int floors)
        {
            bool maxFlor= false;
            if (floors <= maxFloor)
            {
                maxFlor = true;
                Console.WriteLine(maxFlor);
            }
            else
            {
                maxFlor = false;
                Console.WriteLine(maxFloor);
            }
        }
        static void Printfloor(int number)
        {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("This is 1 floor");
                        break;
                    case 2:
                        Console.WriteLine("This is 2 floor");
                        break;
                    case 3:
                        Console.WriteLine("This is 3 floor");
                        break;
                    case 4:
                        Console.WriteLine("This is 4 floor");
                        break;
                    case 5:
                        Console.WriteLine("This is 5 floor");
                        break;
                    case 6:
                        Console.WriteLine("This is 6 floor");
                        break;
                    case 7:
                        Console.WriteLine("This is 7 floor");
                        break;
                    case 8:
                        Console.WriteLine("This is 8 floor");
                        break;
                    case 9:
                        Console.WriteLine("This is 9 floor");
                        break;
                    case 10:
                        Console.WriteLine("This is 10 floor");
                        break;
                    case 11:
                        Console.WriteLine("This is 11 floor");
                        break;
                    case 12:
                        Console.WriteLine("This is 12 floor");
                        break;
                    case 13:
                        Console.WriteLine("This is 13 floor");
                        break;
                    case 14:
                        Console.WriteLine("This is 14 floor");
                        break;
                    case 15:
                        Console.WriteLine("This is 15 floor");
                        break;
                    case 16:
                        Console.WriteLine("This is 16 floor");
                        break;
                    case 17:
                        Console.WriteLine("This is 17 floor");
                        break;
                    case 18:
                        Console.WriteLine("This is 18 floor");
                        break;
                    default:
                        Console.WriteLine("Please enter the correct floor number, select from 1 to 18.");
                        break;
                }
            
        }


    }
}