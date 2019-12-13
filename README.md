# Shopping List C Sharp

## Learning C# by connecting C++ and C# concepts


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