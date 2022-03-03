// See https://aka.ms/new-console-template for more information

short A = 13;
short B = 2;

if (A > B)
{ Console.WriteLine($"{A} is greater than {B}"); }

if (B > A)
{ Console.WriteLine($"{B} is greater than {A}"); }

if (A < B)
{ Console.WriteLine($"{A} is smaller than {B}"); }

if (B < A)
{ Console.WriteLine($"{B} is smaller than {A}"); }

if (A == B)
{ Console.WriteLine($"{A} is equal to {B}"); }
else
{ Console.WriteLine($"{A} is not equal to {B}"); }


if (A % 2 == 1)
{ Console.WriteLine($"{A} is odd number"); }
if (B % 2 == 1)
{ Console.WriteLine($"{B} is odd number"); }

if (A % 2 == 0)
{ Console.WriteLine($"{A} is even number"); }
if (B % 2 == 0)
{ Console.WriteLine($"{B} is even number"); }

if (A < 0)
{ Console.WriteLine($"{A} negative bumber"); }
if (B < 0)
{ Console.WriteLine($"{B} negative bumber"); }

if (A > 0)
{ Console.WriteLine($"{A} positive bumber"); }
if (B > 0)
{ Console.WriteLine($"{B} positive bumber"); }

if (A < 100)
{ Console.WriteLine($"{A} less than 100"); }
if (B < 100)
{ Console.WriteLine($"{B} less than 100"); }

double C = 1.5;
double D = 3.4;

var sum = Math.Round(C + D);
Console.WriteLine(sum);

var substraction = Math.Abs(C - D);
string output = substraction.ToString("#.00");
Console.WriteLine(output);