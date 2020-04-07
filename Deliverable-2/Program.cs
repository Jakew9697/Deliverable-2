using System;


namespace Deliverable_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string message = "";
            int checksum = 0;
            int asciiCode;
            


                Console.WriteLine( "What is your message?" );
                input = Console.ReadLine().ToUpper(); //1 //2 //3
            
                foreach (char letter in input) //4 //5

                {
                asciiCode = (int)letter - 64; //6 //7
                    message += asciiCode + "-"; //8
                checksum = checksum + (int)letter;
                   
                }  
            
            message = message.Substring(0, message.Length - 1); //5
            Console.WriteLine("Your encoded message is " + message );//10
            Console.WriteLine("Message checksum is " + checksum);//10



        }
    }
}
