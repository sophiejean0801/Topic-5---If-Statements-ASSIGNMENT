namespace Topic_5___If_Statements_TUTORIAL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // If Statements
            Console.WriteLine("Please enter your current weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("I have information on the following planets: ");
            Console.WriteLine("1. Venus\n2. Mars\n3. Jupiter\n4. Saturn\n5. Uranus\n6. Neptune");
            Console.WriteLine("Please enter the number of the planet you wish to visit: ");
            Console. ReadLine();
            int planetChoice;
            if (int.TryParse(Console.ReadLine(), out planetChoice))
            {
                if (planetChoice == 1)
                {
                    Console.WriteLine("Your weight on Venus would be " + weight * 0.78);
                }
                else if (planetChoice == 2)
                {
                    Console.WriteLine("Your weight on Mars would be " + weight * 0.39);
                }
                else if (planetChoice == 3)
                {
                    Console.WriteLine("Your weight on Jupiter would be " + weight * 2.65);
                }
                else if (planetChoice == 4)
                {
                    Console.WriteLine("Your weight on Saturn would be " + weight * 1.17);
                }
                else if (planetChoice ==5) 
                {
                 
                    Console.WriteLine("Your weight on Uranus would be " + weight * 1.05);
                }
                else if (planetChoice == 6)
                {
                    Console.WriteLine("Your weight on Neptune would be " + weight * 1.23);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 6.");
                }

                
                   
               
            }
            
            {
               
            }
        }
    }
}
