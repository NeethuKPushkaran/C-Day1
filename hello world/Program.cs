

using System;
using System.Diagnostics.Metrics;

Console.WriteLine("Hello, World!"); //Output - Hello, World!

//Data-Types and Variables

int x = 5;
double y = 5.99;
char letter = 'A';
string name = "Neethu";
bool myBool = true;
Console.Write("\nInteger is: " + x + "\nDecimal is: " + y + "\nLetter is: " + letter + "\nString is: " + name + "\nBoolean is: " + myBool);

/*Output - 
Integer is: 5
Decimal is: 5.99
Letter is: A
String is: Neethu
Boolean is: True*/

float f1 = 35e3F;
double d1 = 12E4D;
Console.WriteLine("\n" + f1); //Output - 35000
Console.WriteLine(d1); //Output - 120000


//Type Casting - Implicit Type Casting

int myInt = 9;
double myDouble = myInt;
Console.WriteLine(myInt); //Output - 9
Console.WriteLine(myDouble); //Output - 9


//Type Casting - Explicit Type Casting

double myDouble1 = 9.78;
int myInt1 = (int) myDouble1;
Console.WriteLine(myDouble1); //Output - 9.78
Console.WriteLine(myInt1); //Output - 9

//Type Casting - Explicit - Built in Method

int myInt2 = 10;
double myDouble2 = 5.25;
bool myBool2 = false;
Console.WriteLine(Convert.ToString(myInt2)); //Output - 10
Console.WriteLine(Convert.ToDouble(myInt2)); //Output - 10
Console.WriteLine(Convert.ToInt32(myDouble2)); //Output - 5
Console.WriteLine(Convert.ToString(myBool2)); //Output - False

//Type Casting - Convert Class

string numberString = "123";

// Convert string to int using Convert.ToInt32
int convertedNumber = Convert.ToInt32(numberString);

Console.WriteLine($"Converted Number: {convertedNumber}"); //Output - 123


//Type Casting - Parse Method

string numberString1 = "456";

// Parse string to int using int.Parse
int parsedNumber = int.Parse(numberString1);

Console.WriteLine($"Parsed Number: {parsedNumber}"); //Output - 456


//ARITHEMATIC OPERATIONS


Console.WriteLine("\nEnter Two Numbers: ");
double number1 = Convert.ToDouble(Console.ReadLine());
double number2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("The Sum of the Numbers is " +(number1 + number2));
Console.WriteLine("The Difference of the Numbers is " + (number1 - number2));
Console.WriteLine("The Product of the Numbers is " + (number1 * number2));
Console.WriteLine("The ratio of the Numbers is " + (number1 / number2));


//IF ELSE-IF ELSE

if (number1 > number2)
    Console.WriteLine("First Number is Greater");
else if
    (number1 < number2)
    Console.WriteLine("Second Number is Greater");
else
    Console.WriteLine("The Numbers are equal");

//FOR LOOP

for(int i = 0; i <= number1; i++)
{
    Console.WriteLine(i);
}

//WHILE LOOP

while(number2 < 100)
{
    Console.WriteLine(number2);
        number2++;
}

//DO-WHILE LOOP

do
{
    Console.WriteLine(number1);
    number1++;
}while(number1 < 100);
