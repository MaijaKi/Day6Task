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