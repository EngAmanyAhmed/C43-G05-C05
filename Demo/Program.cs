using System.Security.AccessControl;
using Common;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Demo
{
    internal class Program
    {

        //Static  Void  DoSomeCode()
        //   { 
        //       int X, Y, Z;
        //       X = int.Parse(Console.ReadLine());
        //       Y = int.Parse(Console.ReadLine();

        //       Z = X/Y;

        //       int[] Arr = { 1, 2, 3 };

        //       Arr[99] = 10;
        //   }

        //Static Void  DoSomeCode()
        //{
        //    try
        //    {
        //        int X, Y, Z;
        //        X = int.Parse(Console.ReadLine());
        //        Y = int.Parse(Console.ReadLine();

        //        Z = X / Y;

        //        int[] Arr = { 1, 2, 3 };

        //        Arr[99] = 10;
        //    }
        //    Catch ( Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //    Finally
        //     {
        //        Console.WriteLine("Finally");
        //        // Disconnect | Dispose UnManged Resource
        //    }

        //}

        //Static Void DoSomeProtectiveCode()
        //{
        //int X, Y, Z;
        //bool Flag;
        //do
        //{
        //    Console.Write("Enter First Number: ");
        //    Flag = int. TryParse(s: Console.ReadLine(), out X);
            
        //    } while (Flag == false);

        //do
        //{
        //    Console.Write("Enter Second Number: ");
        //    Flag = int.TryParse(s: Console.ReadLine(), out Y);

        //} while (Flag == false || X == 0);
           
        //    Z = X / Y;

        //    int[] Arr = { 1, 2, 3 };

        //    if (99 < Arr?.Length)
        //    {
        //        Arr[99 = 10];
        //    }

        //}
        //CancellationToken (Exception e)
        //{
        //    Console.WriteLine(e.Message);
        //}


        static void Main()
        {
            #region Boxing And UnBoxing

            //Boxing And UnBoxing

            // Boxing Casting From ValueType To ReferenceType
            // UnBoxing: Casting From ReferenceType To ValueType

            //object 01;

            // 01 Can Refer To Instance Of "Object" Or Any Instance of Any Type

            //01 =1;
            //01 = "Ahmed";


            //01 = 3;                 // Cast From ValueType [int] To ReferenceType [object]      => Boxing 
            //01 = 1.5;               // Cast From ValueType [char] To Reference Type [object]    => Boxing 
            //01 = 'A';               // Cast From ValueType[double] To ReferenceType[object]     => Boxing 
            //01 = true;              // Cast From ValueType [bool] To ReferenceType [object]     => Boxing 
            //01 = new DateTime();    // Cast From ValueType [DateTime] To ReferenceType [object] => Boxing          


            //int x = 5;
            //object 01 / (object)*/ X;
            // Implicit Casting
            // Safe Casting
            //Boxing
            // Parent Child Child is Parent
            //Animal Dog => Dog is Animal


            //object 01 = 3;


            //int x = (int)01;

            // Explicit Casting
            // UnSafe Casting [May Throw Exception]
            // UnBoxing
            // Dog (Dog) Animal Animal is Dog
            // Child = Parent => Parent is Child

            #endregion

            #region Nullable Types

            // Nullable Types

            // Value Type
            //Reference Type

            #region Nullable Value Type

            // Value Type


            //int X = 6;

            // X = null; // Not Valid


            //Nullable<int> : Allow Int Value or Null as Valid Value
            //int? Age = 20'

            //Age = null;

            // Nullable<int>  Allow Int Value or Null as Valid Value
            //double? Salary = 4000.5;

            //    Sakary = null;

            //int X = 5;

            // Y : Nullable<int>
            // Y : Allow int Value or Null

            // Implicit Casting
            // Safe Casting

            // Console.WriteLine(Y);


            //int? X = 5;


            //X = null;
            // Y : int;
            // Y : Allow int Value Only

            //int Y = (int)X;


            // Explicit Casting
            // May Throw Exception
            // Defensive  Code

            //if (X != null)
            //    Y = (int)X;
            //else
            //    Y = 0;

            // =================


            //if (X is mot null)
            //    Y = (int)X;
            //else
            //    Y = 0;

            // =================

            //if (X.HasValue)
            //    Y = X.Value;
            //else
            //    Y = 0;

            // ===================

            // Y = X.HasValue? X.Value : 0;

            // ===================

            // Y = X is not null? X.Value : 0;
            // ===================

            // Null Coalescing Operator ??

            //Y = X ?? 0; // Syntax Sugar : X is not null ? X.Value : 0


            //Console.WriteLine(Y); 
            #endregion


            #region  Nullable  Reference Type [C# 10.0 .Net 6.0]

            //// Nullable  Reference Type [C# 10.0 .Net 6.0]


            //String Message01 = null;    // Required

            //String? Message02 = null;    // Nullable

            //Console.WriteLine(Message01.Length);
            //Console.WriteLine(Message02);

            #endregion


            #endregion

            #region Null Propagation Operator?

            // Null Propagation Operator?

            //double X default; // 0
            //bool C default;

            //Console.WriteLine(C);



            //int[] Arr default; // null
            //int[] Arr = {1,2,3,4,5]; // null

            // Best Practice
            //if (Are is not null)
            //{
            //    for (int i = 0; i < Arr.Length; i++)
            //    Console.WriteLine(Arr[i]);
            //}


            //for(int i=0; (Arr is not null) &&i< Arr.Length; i++)
            // Console.WriteLine(Arr[i]);


            //    for (int i = 0; i < Arr.Length; i++)
            //    Console.WriteLine(Arr[i]);


            //// E? Department? DeptName

            //int Len = Arr is not null ? Arr.Length: 0;

            //int? Len Arr? Length;

            //int Len Arr? Length is not null ? Arr.Length: 0;

            //int Len = Arr? Length ??  -1;

            //Console.WriteLine(Len);


            #endregion

            #region Exception Handing And Protective Code

            // Exception Handing And Protective Code

            //DoSomeCode();

            //Console.WriteLine("Hello After Exception");


            // Exception
            // 1. SystemException
            // 1.1. FormatException
            // 1.2. IndexOutOfRangeException
            // 1.3. NullReferenceException
            // 1.4. ArithmeticException I
            //     1.4.1.OverflowException
            //2. ApplicationException

            #endregion

            #region Access Modifiers

            // Class Librarry

            // Common.TypeA typeA = new Common.TypeA(); // invalied TypeA is Invalied

            // Common.TypeB typeB = new Common.TypeB(); // TypeB is Public

            //typeB.X = 12; // invalid private
            //TypeB.Y = 12; // Invalid internal

            //TypeB.Z = 12; // valid public 
            #endregion


        }
    }
}
