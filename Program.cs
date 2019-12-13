using System;

namespace ShoppingListInCSharp
{
    class Program
    {
        static void DisplayConversionChart()
        {
            /*
             C++                                                    C#
             ------------------------------------------------------------------------------------
             cout << "Hi!";                                         Console.Write("Hi!");
             cout << "Hi!" << endl;                                 Console.WriteLine("Hi!");
             
             string name; cin >> name;                              string name = Console.ReadLine();
             int age; cin >> age;                                   int age = int.Parse(Console.ReadLine());
             const int size = 3; int items[size];                   int[] items = new int[3]; // items.Length == 3 
             int items[2][3];                                       int[,] items = new int[2,3];
             int** items;                                           int[][] items = new int[2][];
            
             struct Cat { bool isCool; }; Cat cat;                  struct Cat { public bool IsCool; }; Cat cat;
             class Cat { public: bool isCool; }; Cat cat;           struct Cat { public bool IsCool; }; Cat cat;

             struct Cat { bool isCool; }; Cat* cat;                 class Cat { public bool IsCool; }; Cat cat = new Cat();
             class Cat { public: bool isCool; }; Cat* cat;          class Cat { public bool IsCool; }; Cat cat = new Cat();

             enum Buttons { Up, Down };                             // No equivalency - ALL enums are scoped in C#
             enum class Buttons { Up, Down };                       enum Buttons { Up, Down }
             enum class Buttons { Up = 1, Down };                   enum Buttons { Up = 1, Down }

             using namespace std;                                   using System;
             
             SetConsoleTextAttribute(..., color_value);             Console.ForegroundColor = ConsoleColor.[pick a name];
                                                                    Console.BackgroundColor = ConsoleColor.[pick a name];
             
             */

            //int[,] items = new int[2, 3];
            //int[][] items1 = new int[2][];

            

            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.Write("Hello ");
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("World!");

        }
        class User
        {
            public int ItemCount;
            public string[] Item;
            public string Reply;

        }
        
        static void Main()
        {
            User Shopper = new User();
           
            Shopper.ItemCount = 0;
            Shopper.Item=null;
            // Shopper.ItemName = "";

            do
            {
                AddItems(Shopper);

                DisplayMenu(Shopper);

                if (Shopper.ItemCount > 1)//if there is more than 1 item in the list
                {
                    Console.WriteLine("Do you want to delete an item?(Y/N)");
                    Shopper.Reply = Console.ReadLine();
                    if (Shopper.Reply.ToLower() == "y")
                    {
                        DeleteItem(Shopper);
                        DisplayMenu(Shopper);//show updated menu with deleted item
                    }
                }

                Console.WriteLine("Do you want to enter another item?(Y/N)");
                Shopper.Reply = Console.ReadLine();

            } while (Shopper.Reply.ToLower() == "y"); //|| Shopper.Reply == "y");
            // if user inputs, Y, it is converted to lowercase
        }
        static void DisplayMenu(User Shopper)
        {
            for (int i = 0; i < Shopper.ItemCount; i++)
            {
                // cout << "Item #" << i + 1 << ": " <<  << endl;
                Console.Write("Item # ");
                Console.Write(i+1);
                Console.Write(": ");
                Console.WriteLine(Shopper.Item[i]);
            }
        }
        static bool IsItemDuplicate(User Shopper, string TempItem)//input validation function
        {
            for(int i=0; i<Shopper.ItemCount;i++)
            {
                if(Shopper.Item[i].ToLower() == TempItem.ToLower())//lowercase function
                {
                    return true;
                }
            }
            return false;
        }
        static void DeleteItem(User Shopper)
        {
            string TempItem;
            string[] NewItemList = new string[Shopper.ItemCount-1];
            int NewItemCount = 0;

            Console.Write("Enter the name of the item you want to delete:");
            TempItem=Console.ReadLine();

            for(int i=0;i<Shopper.ItemCount;i++)
            {
                if(Shopper.Item[i] != TempItem)
                {
                    NewItemList[NewItemCount] = Shopper.Item[i];
                    NewItemCount++;
                }
            }
           // DeleteItem[] Shopper.Item;
            Shopper.Item= NewItemList;
            Shopper.ItemCount--;
        }

        static bool IsUserInputValid(string TempItem)
        {
           // string alphabet = "abcdefghijklmnopqrstuvwxyz";
            // instead of using this ^, use ascii table
            for(int i=0;i<TempItem.Length;i++)
            {
                if((TempItem[i]>=65 && TempItem[i]<=90) || (TempItem[i]>=97 && TempItem[i]<=122))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Your word is not valid! Please Enter another Item");
                    Console.WriteLine( "Press Space to continue.");
                    Console.ReadKey();
                    return false;
                }
            }
            return true;
        }

        static void AddItems(User Shopper)//naming convention for C#
        { 
            string TempItem;
            
            Console.Write("Enter item: "); //display this "... "

            string[] temp = new string[Shopper.ItemCount+1]; 

            for(int i=0;i<Shopper.ItemCount;i++) //copy old contents of array to temp
            {
                temp[i] = Shopper.Item[i];
            }
           
            Shopper.Item = temp;
            
            TempItem  = Console.ReadLine(); //enter item  name

            while(IsUserInputValid(TempItem) ==false)
            {
                TempItem = Console.ReadLine();
            }

            if (IsItemDuplicate(Shopper, TempItem) == true) //check if item user entered is a duplicate
            {
                Console.WriteLine("Item is a duplicate. Please Enter another item");

            }

            else
            {
                Shopper.Item[Shopper.ItemCount] = TempItem;
                Shopper.ItemCount++;
            }
           
        }
    }

}
