Console.WriteLine("WELCOME TO DEVELOPER KI CHAI");

string input = string.Empty;
int teaQuantity = 0;
int coffeeQuantity = 0; 
int milkQuantity = 0;

do
{
    Console.WriteLine("What would you like to have ?");
    Console.WriteLine($"1 : TEA 10 Rs, 2 : COFFEE 30 Rs, 3 : MILK 20 Rs (Type 1 - 2 - 3 according to order) ");

    int order = int.Parse(Console.ReadLine());

    switch (order)
    {
        case 1:
            Console.WriteLine("How much ?");
            teaQuantity += int.Parse(Console.ReadLine());
            Console.WriteLine($"Your ordered {teaQuantity} TEA in total");
            break;

        case 2:
            Console.WriteLine("How much ?");
            coffeeQuantity += int.Parse(Console.ReadLine());
            Console.WriteLine($"Your ordered {coffeeQuantity} COFFEE in total"); 
            break;

        case 3:
            Console.WriteLine("How much ?");
            milkQuantity += int.Parse(Console.ReadLine());
            Console.WriteLine($"Your ordered {milkQuantity} MILK in total");
            break;

        default:
            Console.WriteLine("INVALID ORDER");
            break;
    }
    Console.WriteLine("Do you Want to place any other order ? [YES/NO]");
    input = Console.ReadLine().ToUpper(); // YES/ NO
} while (input == "YES" || input == "Y");

if (teaQuantity > 0 || coffeeQuantity > 0 || milkQuantity > 0)
{
    Console.WriteLine("****YOUR BILl****");
    int totalbill = 0;

    if (teaQuantity > 0) // TEA
    {
        Console.WriteLine($"TEA : {teaQuantity} * 10 = {teaQuantity * 10} Rs");
        totalbill += teaQuantity * 10;
    }

    if (coffeeQuantity > 0) // COFFEE
    {
        Console.WriteLine($"COFFE : {coffeeQuantity} * 30 = {coffeeQuantity * 30} Rs");
        totalbill += coffeeQuantity * 30;
    }

    if (milkQuantity > 0) // MILK
    {
        Console.WriteLine($"MILK: {milkQuantity} * 20 = {milkQuantity * 20} Rs");
        totalbill += milkQuantity * 20;
    }
    Console.WriteLine($"YOUR TOTAL BILL AMOUNT = {totalbill} Rs");
}
Console.WriteLine("****THANK YOU . VISIT AGAIN .****");

Console.ReadLine();

