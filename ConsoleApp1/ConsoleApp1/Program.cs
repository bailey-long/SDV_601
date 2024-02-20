using ConsoleApp1;

/*var class1 = new Class1("Bailey");

Console.WriteLine("Hello, World!");
Console.WriteLine(class1.name);*/

byte myValue = 64;
double myDouble = 295.1; //change to 295.1
try
{
    myValue = (byte)myDouble;
    Console.WriteLine(myValue);
}
catch (OverflowException)
{
    Console.WriteLine("{0} is out of range of a byte.", myValue);
}
//Outputs 5 
