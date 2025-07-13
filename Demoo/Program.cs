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

            #region Evolution in C# 9.0 [ logical pattern ,relational pattern , enhanced property pattern]



            #region Example 01 Relational pattern 

            //int number = 10;
            //string result = number switch
            //{

            //    < 10 => " number less than 10",
            //    >= 10 and <= 20 => "Number Between 10 to 20",
            //    > 20 => " number is greater than 20"

            //};
            //Console.WriteLine(result);  




            #endregion

            #region Example 02 logical pattern
            //int number = 50;
            //string result = number switch
            //{

            //    >0 and <10 => " number Between 0 to 10",
            //    >= 10 and <= 20 => "Number Between 10 to 20",
            //    0 => " number is 0" ,
            //    //_ => " Out of the range "
            //    > 20 or < 0 => " out of the range" 

            //};
            //Console.WriteLine(result);





            #endregion

            #region Example 03 enhanced property pattern

            //Person number = new Person() {Id = 21 , Name ="Samy" ,age =25 };
            //string result;
            //result = number switch
            //{
            //    { Name: "Samy", age: > 20 } => "Hellow samy",
            //    { Name: "Omer  ", age: > 20 and < 24 } => " hello Omer",
            //    { age: > 50 and < 60 } => " hellwo oid man",
            //    _ => "  I unKnwon you"

            //};
            //Console.WriteLine(result);



            #endregion

            #endregion





            #endregion



            #region Control statment 




            //Console.WriteLine("1");
            //Console.WriteLine("2");
            //Console.WriteLine("3");
            //Console.WriteLine("4");
            //Console.WriteLine("5");
            //Console.WriteLine("6");
            //Console.WriteLine("7");
            //Console.WriteLine("8");
            //Console.WriteLine("9"); 
            //Console.WriteLine("10");

            //// 10 step



            //Console.WriteLine("=========================");



            //for (int i=1 ; i<= 10 ; i++) 
            //{
            //  Console.WriteLine(i);

            //}









            #region for foreach 

            //int[] number = { 1, 2, 3, 4, 5};


            //for (int i = 0; i < number.Length; i++)
            //{

            //    if (i == 2)
            //    { 
            //       // continue;
            //      // break;
            //    }
            //   // number[i] += 10;

            //    Console.WriteLine(number[i ]);


            //}



            //Console.WriteLine("=======================");    
            //foreach (int item in number) 
            //{

            //  //  item +=10 invalid
            //    Console.WriteLine(item);




            //}







            #endregion

            #region While - Do while


            #region While

            //Console.WriteLine("Enter the number");
            // bool isParsed = int.TryParse(Console.ReadLine(), out int number);
            //if (isParsed)
            //{
            //    while (number <= 10)
            //    {
            //        Console.WriteLine(number);
            //        number++;


            //    }

            //}





            #endregion


            #region Do while

            //bool IsParsed;
            //int number;

            //do
            //{

            //    Console.WriteLine("Enter the  even number ");
            //    IsParsed = int.TryParse(Console.ReadLine(), out number);

            //} 
            //while ( !IsParsed || number %2 ==1);

            //Console.WriteLine($" the number {number} is even" );




            #endregion







            #endregion






            #endregion











        }
    }
}
