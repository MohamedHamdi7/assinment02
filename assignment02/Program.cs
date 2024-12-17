using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //1- Write a program that takes a number from the user then print yes
            //if that number can be divided by 3 and 4 otherwise print no.

            //Console.WriteLine("enternumber:");
            //int Number = int.Parse(Console.ReadLine());
            //if (Number % 3 == 0 && Number % 4 == 0)
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}
            #endregion
            #region Q2
            ////2- Write a program that allows the user to insert an integer then print negative
            //if it is negative number otherwise print positive.


            //Console.WriteLine("Enter Number");
            //int Number=int.Parse(Console.ReadLine());
            //if (Number < 0)
            //{
            //    Console.WriteLine("negative");

            //}
            //else
            //{
            //    Console.WriteLine("positive");
            //}







            #endregion
            #region Q3
            //3 - Write a program that takes 3 integers from the user then
            //prints the max element and the min element.
            //Console.WriteLine("Enter Number");
            //int Number01=int.Parse(Console.ReadLine());
            //int Number02 =int.Parse(Console.ReadLine());
            //int Number03=int.Parse(Console.ReadLine());
            //int Max;
            //int Min;

            //if(Number01>Number02)
            //{
            //    Max=Number01;
            //}
            //else
            //{
            //    Max=Number02;
            //}
            //if(Number03>Max)
            //{
            //    Max=Number03;
            //}
            //Console.WriteLine("max:"+Max);
            //if(Number01<Number02)
            //{
            //    Min = Number01;
            //}
            //else
            //{
            //    Min = Number02;
            //}
            //if (Number03 < Min)
            //{
            //    Min = Number03;
            //}
            //Console.WriteLine("MIN:"+Min);
            #endregion
            #region Q4
            //Write a program that allows the user to insert an integer number then
            //check If a number is even or odd.

            //Console.WriteLine("enter number:");
            //int Number=int.Parse(Console.ReadLine());   
            //if(Number %2==0)
            //{
            //    Console.WriteLine("even");
            //}
            //else if(Number %2!=0)
            //{
            //    Console.WriteLine("odd");
            //}




            #endregion
            #region Q5
            //5- Write a program that takes character from the user then
            //if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).

            //Console.WriteLine("enter char");
            //string Char=Console.ReadLine();
            //if (Char=="a" ||Char == "e" ||Char == "i" || Char == "o" || Char == "u")

            //{ 
            //    Console.WriteLine("vowel");
            //}
            //else
            //{
            //    Console.WriteLine("consonant");
            //}


            #endregion
            #region Q6

            // 6 - Write a program that allows the user to insert an integer
            // then print all numbers between 1 to that number.

            //Console.WriteLine("enter number");
            //int Number=int.Parse(Console.ReadLine());
            //for (int i = 1;i <= Number;i++)
            //{
            //    Console.WriteLine(i);
            //}






            #endregion
            #region Q7
            //7- Write a program that allows the user to insert an integer then 
            //print a multiplication table up to 12.

            //Console.WriteLine("enter number");
            //int Number = int.Parse(Console.ReadLine());
            //int i = 1;

            //for (; i <= 12;)
            //{
            //    string Message = $"{Number} * {i} = {Number * i}";
            //    Console.WriteLine(Message);
            //    ; i++;
            //}


            //Console.WriteLine("enter number");
            //int Number = int.Parse(Console.ReadLine());
            //int i = 1;

            //for (; i <= 12;)
            //{
            //    int Message = Number * i;
            //    Console.WriteLine(Message);
            //    ; i++;
            //}





            #endregion
            #region Q8

            // Write a program that allows to user to insert number
            // then print all even numbers between 1 to this number

            //Console.WriteLine("ENTER NUMBER");
            //int Number = int.Parse(Console.ReadLine());
            //for (int i = 2; i < Number; i += 2)
            //{
            //    Console.WriteLine(i);
            //}



            #endregion
            #region Q9
            //Write a program that takes two integers then prints the power.


            //Console.WriteLine("enter nimber");
            //int Number01=int.Parse(Console.ReadLine());
            //int Number02=int.Parse(Console.ReadLine());
            //double Message = Math.Pow( Number01 , Number02);
            //Console.WriteLine(Message);




            #endregion
            #region Q10
            //10- Write a program to enter marks of five subjects and
            //calculate total, average and percentage.


            //int Subject01, Subject02, Subject03, Subject04, Subject05;

            //Console.WriteLine("enter subject1:");
            // Subject01 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter subject2:");
            // Subject02 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter subject3:");
            // Subject03 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter subject4:");
            // Subject04 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter subject5:");
            // Subject05 = int.Parse(Console.ReadLine());

            //int Total = Subject01 + Subject02 + Subject03 + Subject04 + Subject05;
            //double Avg = Total / 5.0;
            //double Per = (Total / 5.0) * 100;

            //Console.WriteLine("average:" + Avg);
            //Console.WriteLine("percentage:" + Per);







            #endregion
            #region Q11
            //11- Write a program to input the month number and print the number of days in that month.


            //Console.WriteLine("MONTHNUMBER:");
            //int Month=int.Parse(Console.ReadLine());
            //switch (Month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine("32");
            //        break;

            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine("30");
            //        break;
            //    case 2:
            //        Console.WriteLine("28");
            //        break;
            //}











            #endregion
            #region Q12
            //Write a program to create a Simple Calculator.
            //Console.WriteLine("CALCULATR");
            //double Num1 = double.Parse(Console.ReadLine());
            //double Num2= double.Parse(Console.ReadLine());
            //double Choice;
            //double Result ;
            //switch(Choice)
            //{
            //    case 1: 
            //        Result = Num1 + Num2;
            //        Console.WriteLine(Result);
            //        break;  

            //}
            #endregion
            #region Q13
            //Write a program to allow the user to enter a string and print the REVERSE of it.

            //Console.WriteLine("enter word");
            //string Word=Console.ReadLine();





            #endregion
            #region Q14
            //14- Write a program to allow the user to enter int and print the REVERSED of it.






            #endregion
            #region Q15


            #endregion













        }
    }
}
