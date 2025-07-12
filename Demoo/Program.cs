namespace Demoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Evalution in switch in c# 


            #region Evolution in c# 7.0

            // object number = 5.6; // boxing

            #region Example1[ pattern maching on types]
            //// no jump table will be create [Bid number of any type]
            //switch (number)
            //{
            //    case int value: // unboxing
            //        Console.WriteLine("int");
            //        break;
            //    case double value:
            //        Console.WriteLine("double");
            //        break;
            //    case float value:
            //        Console.WriteLine("float");
            //        break;
            //    default:
            //        Console.WriteLine("No Match");
            //        break;

            //}










            #endregion

            #region Example 2 [Case Guard when]

            //switch (number)
            //{
            //    case int value when value <10: // unboxing
            //        Console.WriteLine("int less than 10");
            //        break;
            //    case int value when value > 10: // unboxing
            //        Console.WriteLine("int Bigger than 10");
            //        break;
            //    case decimal value:
            //        Console.WriteLine("decimal");
            //        break;
            //    case double value when value >5.5 && value < 10:
            //        Console.WriteLine("Double Between 5.5 to 10");
            //        break;
            //    default:
            //        Console.WriteLine("No Match");
            //        break;

            //}






            #endregion

            #region Example 3 [user -Defined DateType]

            //object num = 50;
            //num = new person();
            //{ Id = 1 , name = "Omer " ,Age = 25}

            //switch (num)
            // {
            //    case int value when value < 10:
            //        Console.WriteLine("int");
            //        break ;
            //        case string value:
            //        Console.WriteLine("String");
            //        break ; 
            //        case double value:
            //        Console.WriteLine("double");
            //        break ;
            //        case person  value when ID == 1 && name == "omer" : // short cricut
            //        Console.WriteLine("person");
            //        break ; 
            //        default:
            //        Console.WriteLine("No match");
            //        break ; 





            //  }



            #endregion








            #endregion


            #region Evolution in C# 8.0

            #region  Example 01 pattern matching with out alias name

            //object number = 5.5;

            //switch (number)
            //{
            //    case int when (int)number < 10: // unboxing
            //        Console.WriteLine("int less than 10");
            //        break;
            //    case int when (int)number > 10: // unboxing
            //        Console.WriteLine("int Bigger than 10");
            //        break;
            //    case decimal :
            //        Console.WriteLine("decimal");
            //        break;
            //    case double  when (double)number > 5.5 && (double)number < 10:
            //        Console.WriteLine("Double Between 5.5 to 10");
            //        break;
            //    default:
            //        Console.WriteLine("No Match");
            //        break;

            //}









            #endregion


            #region switch  case Before Switch expression

            //string number = Console.ReadLine();

            //string message;
            //switch (number)
            //{
            //    case "1":
            //        message = "option 1";
            //        break;
            //        case "2":
            //        message = " option 2";
            //        break;
            //        case "3":
            //        message = "option 3 ";
            //        break;
            //         default:
            //        message = "No options";
            //        break;  


            //}
            //Console.WriteLine(message); 



            #endregion


            #region Example 02 Switch expression [constant pattern - Discard pattern]

            //string number = Console.ReadLine() ?? "0";
            //string message;

            //message = number switch
            //{
            //    "1" => "option 1",
            //    "2" => "option 2",
            //    "3" => "option 3",
            //    _ => "No options"
            //};
            //Console.WriteLine(message);






            #endregion


            #region Example 03 [property pattern]
            //Person number = new Person() {Id=5 , Name ="omer " ,age=25 };

            //string message;

            //message = number switch
            //{
            //    { Id: 5, Name: "Omer" } => "hellow Omer",
            //    { Id: 5, Name: "May" } => "hellow May",
            //    { Id: 5 } => "hellow ",
            //    _ => "No match"
            //};
            //Console.WriteLine(message);








            #endregion

            #region Nullable type  switch expression

            //int? number =10;
            //string message;
            //message = number switch
            //{
            //    null => " null value ",
            //    int x when x > 0 => "number Bigger than 0",
            //    int x when x < 0 => "Number less than 0",
            //    int x when x == 0 => "Number is 0"



            //};
            //Console.WriteLine(message);


            #endregion


            #endregion





            #endregion











        }
    }
}
