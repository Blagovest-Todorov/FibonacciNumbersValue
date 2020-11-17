using System;

namespace _31.fibonacciNumbValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");  //let base member value = 0, firstMember value be, 1;
            int n = int.Parse(Console.ReadLine()); //n number in the row ?
            if (n <= 1 && n > 0 )
            {
                Console.WriteLine(1); //the value of first number in Fibonacci row is 1;
                Console.WriteLine("the first MemberNumber value in Fibonacci's row is 1");
            }
            else if( n >= 2)
            {
                int zeroNumber = 0; //zeroNumber = Base number to creat the second number; (ZeroNum + first number = second number int the row)
                int firstNumber = 1; //first number from the row ; to create the secound numebr in the row;
                int secondNumber = 0; //value here We dont know it still, in the cycle we will reinitialize it;(we sum the value of Zero and first always ! )
                for (int i = 2; i <= n ; i++)
                {
                    secondNumber = zeroNumber + firstNumber; //We always have to have value of base number(zeroNumber actualized) 
                    //and the firstNumber value actialized in order to produce the next -search number in the row   :
                    
                    //Console.WriteLine($" the value of the {n}number is :{secondNumber}");
                    zeroNumber = firstNumber;  //We actualize the /zeroNumber;
                    firstNumber = secondNumber;//We actualize the firstNumber; so : zeroNumber + firstNumber =(the newSearched Number!);

                }
                Console.WriteLine($" the value of the {n}th MemberNumber FibonacciRow is :{secondNumber}");
            }
        }
    }
}
