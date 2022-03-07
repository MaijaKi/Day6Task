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


Console.WriteLine("******************************************");

var time = -2;
var day = 12;
var month = 5;
var year = 2021;

if (time < 0 || time > 24)
{ Console.WriteLine("Please check the time!"); }

if (time < 12 && time >= 0)
{ Console.WriteLine("Good Morning Sunshine!");}
if (time > 13 && time < 19)
{ Console.WriteLine("Good Afternoon. Work Hard!");}
if (time > 20 && time < 24)
{ Console.WriteLine("Good Evening. Get some rest!");}

if (day < 1 || day > 31)
{ Console.WriteLine("Please check the date!"); }

if (month < 1 || month > 12)
{ Console.WriteLine("Please check the month!"); }

if (year < 0)
{ Console.WriteLine("Please check the year!"); }

Console.WriteLine($"{year}/{month}/{day}");

Console.WriteLine("******************************************");

Console.WriteLine("Please write day");
string day1 = Console.ReadLine();

Console.WriteLine("Please write month");
string month1 = Console.ReadLine();

Console.WriteLine("Please write year");
string year1 = Console.ReadLine();

day = Convert.ToInt32(day1);
month = Convert.ToInt32(month1);
year = Convert.ToInt32(year1);

if (day < 1 || day > 31)
{ Console.WriteLine("Please check the date!"); }

if (month < 1 || month > 12)
{ Console.WriteLine("Please check the month!"); }

if (year < 0)
{ Console.WriteLine("Please check the year!"); }

Console.WriteLine("Please select the date formatting. 1 - YYYY/MM/DD, 2- YYYY.MM.DD");
string Format = Console.ReadLine();

if (Format == "1")
{ Console.WriteLine($"Your date is { year}/{ month}/{ day}"); }
else if (Format == "2")
{ Console.WriteLine($"Your date is { year}.{ month}.{ day}"); }
