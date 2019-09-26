using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        public static int select_Validation()
        {

            bool select_Validation = false;
            string user_values = "";
            while (select_Validation == false)
            {
                Console.WriteLine("1 - Get Length of the rectangle");
                Console.WriteLine("2 - Change Length of the rectangle");
                Console.WriteLine("3 - Get Width of the rectangle");
                Console.WriteLine("4 - Change Width of the rectangle");
                Console.WriteLine("5 - Area of the rectangle");
                Console.WriteLine("6 - Perimeter of the rectangle");
                Console.WriteLine("7 - Exit\n");
                Console.WriteLine("Please select one options from above, by entering a number from 1-7:\n");
                user_values = Console.ReadLine();

                if (user_values != "1" &&
                    user_values != "2" &&
                    user_values != "3" &&
                    user_values != "4" &&
                    user_values != "5" &&
                    user_values != "6" &&
                    user_values != "7")
                {
                    Console.WriteLine("Invalid option,please retry:\\n");
                }

                else
                {
                    select_Validation = true;
                }
            }

            Console.WriteLine();
            return int.Parse(user_values);
        }

        public static int Validation(string selected_option)
        {
            int Number = 1;
            bool isValid = false;

            while (isValid == false)
            {
                Console.WriteLine($"Please enter {selected_option}:");
                string user_input = Console.ReadLine();
                Console.WriteLine();

                bool result = (int.TryParse(user_input, out Number));


                if (result == false)
                {
                    Console.WriteLine("not a valid input please, please try a positive integer value.\n");
                }

                else if (Number <= 0)
                {
                    Console.WriteLine("Enter values above 0, length & width can not be zero.\n");
                }

                else if (Number > 100)
                {
                    Console.WriteLine("Please Enter The values below 100 \n");
                }

                else
                {
                    isValid = true;
                    Console.WriteLine($"Your's {selected_option} is now changed to: {Number}.\n");
                }
            }

            return Number;
        }

        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            bool initial_Selection = false;
            string initial_number;
            int select;


            while (initial_Selection == false)
            {
                Console.WriteLine("1 - Initial Default values, Length = 1 & Width = 1 rectangle\n");
                Console.WriteLine("2 - Create custom Rectangle with Length and Width\n");
                Console.WriteLine("Choose a menu Item to begin:");
                initial_number = Console.ReadLine();
                Console.WriteLine();

                if (initial_number != "1" && initial_number != "2")
                {
                    Console.WriteLine("not a valid selection, please try again with a correct value.\n");
                }
                else if (int.Parse(initial_number) == 1)
                {
                    initial_Selection = true;
                    int length = 1;
                    int width = 1;

                    Console.WriteLine($"you selected length = {length} and width = {width}.\n");
                    Rectangle defaultInputs = new Rectangle(length, width);
                    r = defaultInputs;

                }
                else if (int.Parse(initial_number) == 2)
                {
                    initial_Selection = true;

                    int length;
                    int width;

                    length = Validation("length");
                    width = Validation("width");

                    Console.WriteLine("You provided with Length = {0} and Width = {1}.\n", length, width);
                    Rectangle defaultInputs = new Rectangle(length, width);
                    r = defaultInputs;
                }
            }

            select = select_Validation();

            while (select != 7)
            {
                int result;

                switch (select)
                {
                    case 1:
                        Console.WriteLine("Rectangle's length is: {0}\n", r.GetLength());                        
                        break;
                    case 2:
                        result = Validation("length");
                        r.SetLength(result);
                        
                        break;
                    case 3:
                        Console.WriteLine(" Rectangle's width: {0}\n", r.GetWidth());
                        break;
                    case 4:
                        result = Validation("width");
                        r.SetWidth(result);
                        break;
                    case 5: 
                        Console.WriteLine(" Area of Rectangle with dimensions: {0} and  {1} and area is: {2}\n", r.GetLength(), r.GetWidth(), r.GetArea());
                        break;
                    case 6:
                        Console.WriteLine(" Perimeter of Rectangle with dimensions: {0} and  {1} and perimeter is: {2}\n", r.GetLength(), r.GetWidth(), r.GetPerimeter());
                        break;
                    default:
                        break;
                }

                select = select_Validation();

            }

        }


    }
}