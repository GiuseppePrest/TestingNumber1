// See https://aka.ms/new-console-template for more information
using Giuseppe_CSharp_Practice;

//var CharacterName = "Tom";
//var CharacterAge = 25;


/*
Console.WriteLine("There once was a man named " + CharacterName);
Console.WriteLine("He was " + CharacterAge + " years old");

CharacterName = "James";

Console.WriteLine("He really liked the name " + CharacterName);
Console.WriteLine("But did not like being 24");
*/

//Bit that you did to commence with.


//var max = new Dog();
//var tim = new Dog();

//max.Name = "max";
//tim.Name = "tim";

//max.SayYourName();
//tim.SayYourName();


//max.Bark();
//// Eye colour
//var Blue = new Dog();

//Blue.EyeColour = "Blue";

//Blue.SayYourEyeColour();



// Added the name nissanCar to the Car Object/Class.
//var nissanCar = new Car();

//Used the new car class name to get the property and assigned it a value of Nissan.
//nissanCar.Type = "Nissan";

//Nisan class function to call back the value of type.
//nissanCar.CarType();

// Person Name Practice.

/* 
Person ThisIsAPerson = new Person();
ThisIsAPerson.Name = "Giuseppe";
ThisIsAPerson.personName();
*/


// Fish Practice.
//var MyFish = new Fish();
//MyFish.FishName = "Nemo";

//MyFish.SayFishName();




//Just a simple what is your pets name practice. 
/*Console.Write("What is your pets' name?");

string PetName = Console.ReadLine();

Console.WriteLine("Your pet name is " + PetName);
*/

// Creating a small addition calculater.
/*Console.Write("Enter a number");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter another number");
int Num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your number is " + Num1 + Num2);
*/

// Creating a more complete calculater.
/*
Console.Write("Insert a number:");
double Num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Insert an operator");
string OP = Console.ReadLine();

Console.Write("Insert a number:");
double Num2 = Convert.ToDouble(Console.ReadLine());

if (OP == "+")
{
    Console.WriteLine(Num1 + Num2);
}
 else if (OP == "-")
{
    Console.WriteLine(Num1 - Num2);
}
else if (OP == "/")
{
    Console.WriteLine(Num1 / Num2);
}
else if (OP == "*")
{
    Console.WriteLine(Num1 * Num2);
}
else
{
    Console.WriteLine("Please enter a valid operator.");
}
*/

// was able to write this class with no mistake. A function is a Method.
/*var MyPhone = new Phone();
MyPhone.PhoneType = "Iphone 11";
MyPhone.WhatPoneDoYouHave();
*/


//Maid Lib Game.
/*
 string colour, PluralNoun, YourName;

Console.Write("Type a colour:");
colour = Console.ReadLine();

Console.Write("Type a plural noun:");
PluralNoun = Console.ReadLine();

Console.Write("Type your name:");
YourName = Console.ReadLine();

Console.WriteLine("Roses are " + colour + "\n" + PluralNoun + " are blue" + "\n" + "I love " + YourName);
*/


// Arrays:
/*
int [] LuckyNumber = { 1, 2, 4 };

LuckyNumber[0] = 100;

Console.WriteLine(LuckyNumber[0]);

// Array with nothing inside just how many elements it can hold.
string[] Friends = new string[4];

Friends[0] = "Jim";

Console.WriteLine(Friends[0]);
*/



// Method 
/*
int NumberCubed = Cube(5);
Console.WriteLine(NumberCubed);

static int Cube(int Num)
{
   int Result = Num * Num * Num;

    return Result; 
}
*/

// If else statement.
/* 
bool Male = true; 
bool Tall = true;

if (Male && Tall)  
{
    Console.WriteLine("Yes you are a dude and tall!");
} else if(Male && !Tall)
{
    Console.WriteLine("You are a male however, not tall!");
} else
{
    Console.WriteLine("You are likely a girl!");
}
*/


// If statement with a Method to return the highest number.
/*
static int BiggerNumber(int Num1, int Num2, int Num3)
{
    if (Num1 > Num2 && Num1 > Num3)
    {
        int Result = Num1;
        return Result;
    }
    else if (Num2 > Num1 && Num2 > Num3)
    {
        int Result = Num2;
        return Result;
    }
    else if (Num3 > Num2 && Num3 > Num1)
    {
        int Result = Num3;
        return Result;
    }
    else
    {
        return 0;
    }
}
int NumberIs = BiggerNumber(2, 5, 7);
Console.WriteLine(NumberIs);    
*/

// Tell me the day of the week.
/*
static string WhichDay(int Num1) {
    string DayOfTheWeek;

    switch(Num1) 
    {
        case 0: DayOfTheWeek = "Monday";
            break;
        case 1: DayOfTheWeek = "Tuesday";
            break;
        case 2: DayOfTheWeek = "Wednesday";
            break;
        case 3: DayOfTheWeek = "Thursday";
            break;
        case 4: DayOfTheWeek = "Friday";
            break;
        case 5: DayOfTheWeek = "Saturday";
            break;
        case 6: DayOfTheWeek = "Sunday";
            break;
        default: DayOfTheWeek = "Please enter a number from 0 - 6";
            break;
    }
    return DayOfTheWeek;
}    

Console.WriteLine(WhichDay(8));
*/


//While loop.
/*                                            
int Index = 0;
while(Index <= 5)
{
    Console.WriteLine(Index);
    Index++;
}


//Do while. 
/*
int Index = 7;
do
{
    Console.WriteLine(Index);
    Index++;
} while (Index < 7);
*/

// While loop using if statements with a limit to the game chances. 
/*
string Word = "Correct";
Console.Write("Guess the word: ");
string GuessWord = Console.ReadLine();
int GuessLimit = 3;
int GuessCount = 0;
bool Correct = false;

while(GuessWord != Word && GuessCount != 3)
{
    Console.WriteLine("Try again: ");
    GuessWord = Console.ReadLine();
    GuessCount++;
} 
if(GuessWord != Word)
{
    Console.WriteLine("You lost");
} else 
{ 
    Correct = true;
    Console.WriteLine("You won");
}
*/



// Iterating through an array. 
/*
int[] LuckyNumber = { 1, 2, 3, 4, 5 };

for (int i = 0; i < LuckyNumber.Length; i++)
{
    Console.WriteLine(LuckyNumber[i]);
}

Console.WriteLine(LuckyNumber[0]);
*/


//Two way array
/*
int[,] Number = {
    {1,2}, {3,4}, {5,6}, {6,7}, {7,8}
};


Console.WriteLine(Number[4, 0]);


int[,] tryingSomething = new int[2,3];
*/

// Exeption handling using try catch
/*try {
    Console.Write("A number: ");
    int Num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Wrote another number: ");
    int Num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(Num1 / Num2);
}
catch(DivideByZeroException e)
{
    Console.WriteLine(e);
}
catch (FormatException e)
{
    Console.WriteLine(e);
}
*/



//Phone MyPhone = new Phone();
//MyPhone.PhoneNumber = 79078978907;

//MyPhone.WhatNumber();


/* Phone MyPhone = new Phone("IPhone", 798797549072);

Phone MyPhone2 = new Phone("Samsung", 74907149073490);

Console.WriteLine(MyPhone.PhoneNumber + My Phone.PhoneType);
*/


// Created new classes using constructors and a method that returns if a person is powerfull. 
/*
PersonPower MyPower = new PersonPower("Giuseppe", "Male", 11);
PersonPower MyPower1 = new PersonPower("Giuseppe1", "Male1", 9);

Console.WriteLine(MyPower.AreYouStrong());
Console.WriteLine(MyPower1.AreYouStrong());
*/


//Created a watch class and added a private property:
/*Watch MyWatch = new Watch("Digital","Big");
Console.WriteLine(MyWatch.watchType);
*/

ItalianChef italianChef = new ItalianChef();
Chef chef = new Chef();
chef.MakeMeAGelato();
italianChef.MakeMeAGelato();