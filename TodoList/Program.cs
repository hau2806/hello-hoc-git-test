//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//var result = Add(10, 5);
//Console.WriteLine("10 + 5 = " + result);

//Console.ReadKey();

//int Add( int a, int b)
//{
//    return a + b;
//}

int a = 4;
int b = 5;
int c = 6;
Console.WriteLine($"The sum of {a}, {b} and {c} is {a + b + c}");

switch (a)
{
    case 1:
        Console.WriteLine("a is 1");
        break;
    case 2:
        Console.WriteLine("a is 2");
        break;
    case 3:
        Console.WriteLine("a is 3");
        break;
    default:
        Console.WriteLine("a is not 1, 2 or 3");
        break;
}

string ConvertPointsToGrade(int points)
{

    switch (points)
    {
        case 10:
        case 9:
            return "A";

        case 8:
        case 7:
        case 6:
            return "B";

        case 5:
        case 4:
        case 3:
            return "C";

        case 2:
        case 1:
            return "D";

        case 0:
            return "F";

        default:
            return "Invalid points";

    }
}