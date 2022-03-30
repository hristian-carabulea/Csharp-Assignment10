class Program
{
    static void Main()
    {
        int b = 10; //Convert this value into "short" type (assign into another short type of variable
        short bb = (short)b;

        string c = "10.34"; //Convert this value into "double" type using Parse  //Also, convert the same value into "decimal" type  using TryParse
        double cc = double.Parse(c);

        decimal d = 11.56m; //Convert this value into "string" type (assign into another string type of variable)
        string dd = System.Convert.ToString(d);

        System.Console.WriteLine("\nint b: " + b);
        System.Console.WriteLine("short bb: " + bb);

        System.Console.WriteLine("\nstring c: " + c);
        System.Console.WriteLine("double cc: " + cc);

        System.Console.WriteLine("\ndecimal d: " + d);
        System.Console.WriteLine("string dd: " + dd);

        System.Console.Write("\nEnter a key to end program: ");
        System.Console.ReadKey();

    }
}

