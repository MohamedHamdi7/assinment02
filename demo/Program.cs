using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Channels;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region STRING FORMATING
            //1-STRING COCATINTION
            //int X = 4;
            //int Y = 5;
            //string Message = "EQUTION:" + X + "+" + Y + "=" + (X + Y);


            //STRING FORMAT>>>BUILT IN FUNCTION
            //string Message= string.Format("EQUATION:{0}+{1}={2}",X,Y,(X+Y));

            //Console.WriteLine(Message);

            ////STRING ENTRPOLUTION($)

            //string Message = &"EQUATION:{X}+{Y}={X=Y}";            
            //    Console.WriteLine(Message);


            #endregion
            #region CONTROLSTATMENT
            //CONDITONAL CONTROL (IF /SWITCH)
            //LOOP CONTROL(FOR  /FROEACH /WHILE /DO-WHILE)




            //SYNTAX(IF CONDITION)
            //IF(EXPRETION OR CONDITION)
            //{

            //CODE

            //}    
            //EX

            //Console.Write("ENTER NUMBER OF MONTH IN THE 1ST QUARTER:");
            //int MonthNumber = int.Parse(Console.ReadLine());

            //if (MonthNumber == 1)
            //{
            //    Console.WriteLine("jan");
            //}
            //if (MonthNumber == 2)
            //{

            //    Console.WriteLine("mar");
            //}
            //if (MonthNumber == 3)
            //{
            //    Console.WriteLine("mar");
            //}


            //SWITCH(EXPRITTION)
            //switch(MonthNumber)
            //    {
            //    case 1:
            //        Console.WriteLine("jan");
            //        break;
            //        case 2:
            //        Console.WriteLine("feb");
            //        break;
            //        case 3:
            //        Console.WriteLine("mar");
            //        break;
            //        default:
            //        Console.WriteLine("nomonth");
            //        break;
            //    }

            //ex

            //Console.Write("enter your name:");
            //string Name = Console.ReadLine();
            //if (Name == "Ahmed"||Name=="ahmed")
            //{
            //    Console.WriteLine("hi Ahmed");
            //}
            //else if (Name == "Ali"||Name=="ali")
            //{
            //    Console.WriteLine("hi ali");
            //}
            //else if (Name == "Mohamed"||Name=="mohamed")
            //{
            //    Console.WriteLine("hi mohamed");
            //}
            //else
            //{
            //    Console.WriteLine("no name");
            //}


            ////with switch
            //switch (Name)
            //{
            //    case "Ahmed":
            //    case "ahmed":
            //        Console.WriteLine("hi ahmed");
            //        break;
            //    case "ali":
            //    case "Ali":
            //        Console.WriteLine("hi ali");
            //        break;  
            //    case "marim":
            //    case "Marim":
            //        Console.WriteLine("hi marim");
            //        break;
            //        default:
            //        Console.WriteLine("no name");
            //        break;


            //}

            //ex
            //Console.WriteLine("enter your age");
            //int Age=int.Parse(Console.ReadLine());
            //if (Age>18)
            //{
            //    Console.WriteLine("welcom");
            //}
            //else if (Age<18)
            //{
            //    Console.WriteLine("bye bye");
            //}
            //else
            //{
            //    Console.WriteLine("equal");
            //}

            //using switch
            //Console.WriteLine("enter your age");
            //int Age=int.Parse(Console.ReadLine());
            //switch(Age)
            //{
            //    case > 18:
            //        Console.WriteLine("welcom");
            //        break;
            //    case < 18:
            //        Console.WriteLine("bye bye");
            //        break;
            //        default:
            //        Console.WriteLine("equal");
            //        break;

            //}





            #endregion
            #region EVALIOTION IN SWITCH
            //IN C#7.0
            // CAN MAKE PATERN MATCHING MAKE CONDITION 
            //EX
            //object Object= new object();
            //Object = "Ahmed";
            ////Object = 1;
            //switch(Object)
            //{
            //    case int i when i > 0:
            //        Console.WriteLine("int object");
            //        break;
            //    case string i when i.Length > 4:
            //        Console.WriteLine("string object");
            //        break;
            //}


            //IN C# 8.0
            // (Syntax SUGER)
            //string Input = Console.ReadLine();
            //string Output = Input switch
            //{
            //    "1" => "option1",
            //    "2" => "option2",
            //    "3" => "option3",
            //};
            //  Console.WriteLine(Output); 
            //string Input = Console.ReadLine();
            // Console.WriteLine( Input switch
            //{
            //    "1" => "option1",
            //    "2" => "option2",
            //    "3" => "option3",
            //});
            //Console.WriteLine(Output);

            #endregion
            #region LOOP CONTROL STATMENT
            //LOOP COTROL(FOR / FOREACH / WHILE / DO-WHILE )
            //USED FOR REPEATION
            //SYNTAX FOR 
            //FOR(STATMENT,EXPRISSION,STATMENT)
            //{
            //CODE
            //}
            //Console.WriteLine("HELLO WORLD");
            //int i = 0;
            //for (; i <= 10;)
            //{
            //    Console.WriteLine("hello world");
            //    i++;
            //}


            //for (int i = 0; i <= 10;  i++)
            //{
            //    Console.WriteLine("hello world");

            //}

            //FOREACH>>>USED WITH ARY(CONTINER)
            //int[] Number = { 1, 2, 3,4,5,6 };
            //foreach (int i in Number)
            //{
            //    Console.WriteLine(i);
            //}

            //using FOR
            //int[] Number = { 1, 2, 3, 4, 5, 6 };
            //for (int i = 0; i < Number.Length;i++)
            //{
            //    Console.WriteLine(Number[i]);
            //}


            //WHILE THE SAME BUT SYNTAX DIFARNCE
            //WHILE(EXPRISSION)>>BOOL (TRUE OR FALSE)
            //{
            //CODE
            //}
            //int i = 0;
            //  while (i<10)

            //{
            //    Console.WriteLine("HI");
            //    i++;
            //}


            //DO-WHILE >>>SAME BUT DIFFERNT SYNTAX AND THE CODE EXCUTE FIRST
            //DO
            //{
            //CODE
            //}WHILE (EXPRIDSSION);

            //int i = 0;
            //do
            //{
            //    Console.WriteLine("hi");
            //    i++;

            //} while (i <= 10);
            ////  //// //////////////////////////////////

            //Console.WriteLine("even number");
            //using do-while
            //int Number;
            //do
            //{
            //    Console.WriteLine("even");
            //    Number = int.Parse(Console.ReadLine());


            //} while (Number % 2!=0);
            //Console.WriteLine(Number);
            ////////////////////////////////////////
            //IF USER(USER STRING)
            //int Number;
            //bool Flag;
            //do
            //{
            //    Console.WriteLine("even number");
            //    Flag = int.TryParse(Console.ReadLine(), out Number);

            //} while (Number % 2!= 0||Flag==false);
            //Console.WriteLine(Number);

            #endregion
            #region String
            //STRING(IMMUTABLE>>CAN NOT CHANGE ITS VALUE AFTER CREATION)
            //string Name;

            //Name = "Ahmed";
            //Console.WriteLine(Name.GetHashCode());
            //Name = "ali";
            //Console.WriteLine(Name.GetHashCode());
            //Name = "mariam";
            //Console.WriteLine(Name.GetHashCode());
            #endregion
            #region STRING BUILDER



            #endregion






        }
    }
}
   





                  
