using System;
using System.Text;

namespace basicdatatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = false;
            string ans;


            for (int i = 0; i < 43; i++)
            {
                
            }

            do
            {
               TicTacToe();
                System.Console.WriteLine("play again? (True / false)");
                ans =  Console.ReadLine();
                again = bool.Parse(ans); 
            } while (again == true);

            while (again == true)
            {
                TicTacToe();
                System.Console.WriteLine("play again? (True / false)");
                ans =  Console.ReadLine();
                again = bool.Parse(ans);
            }

            System.Console.WriteLine("Thanks for playing. Would you like a nice game of Global Thermal Nuclear War?");

           // LocalVariableDeclarations(); //dont worry what it means yet
           

        


            Console.ReadLine();
        }

        static void ThingDoer(){

           string[] carTypes = {"Ford","chevy","BMW","dodge","pinto"};



            for(int i =0; i < 500; i = i + 1){
                System.Console.WriteLine("Hi world");
            }

           foreach (var i in carTypes)
           {
               System.Console.WriteLine($"{i} is a type of car.");
           }


        }

        static void TicTacToe(){
            //code goes here
        }



        // static void LocalVariableDeclarations(){
        //     System.Console.WriteLine("data decs:");
        //     int age = 33;
        //     string name;
        //     y = "bob";
        //     y = "jayne";
        //     x = 42;
        //     bool subscribed = false;
        //     string fName = "bob", lName ="smith", FullName;



        // }
        // static void ThingDoer(){
        //     System.Console.WriteLine();
        // }
    }
}
