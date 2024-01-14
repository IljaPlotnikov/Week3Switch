//Odd or even

int a = 11;

int result = a % 2;

Console.WriteLine(result);

if (result == 0)
{
    Console.WriteLine($"{a} is an even number");
else
{
    Console.Write($"{a} is an odd number");
}