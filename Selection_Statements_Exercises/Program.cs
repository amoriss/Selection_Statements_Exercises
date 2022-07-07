
//Exercise 1:
//Create a program that allows a user to play a game where they must
//guess what your favorite number is:
//Initialize an integer to represent a favorite number and assign a value
//with a number of your choosing or you can assign a random number to
//this variable:
//var r = new Random();
//var favNumber = r.Next(1, 1000);
//var userInput = int.Parse(Console.ReadLine());
// The following code will allow the user to guess what your favorite
// number is:
//var userInput = int.Parse(Console.ReadLine());
//Create an if-statement that if the guessed number is below the initial
//value, print out “too low”.
//Create an else-if statement that if the number is higher than the
//initial value, print out “too high”.
//Create an else statement that prints out some type of congratulations
//for guessing the correct number e.g. “You guessed it!!!”.

var r = new Random();
var faveNumber = r.Next(1, 10);
var userInput = int.Parse(Console.ReadLine());

if (userInput < faveNumber)
{
    Console.WriteLine("Too low");
}
else if (userInput > 10)
{
    Console.WriteLine("Too high");
}
else
{
    Console.WriteLine("You guessed correctly!");
}

//Ask the user for their favorite school subject.
//Store their answer in a variable
//Pass the variable as the expression in a switch statement.
//Create 5 different cases for different subjects. Each case will print the subject chosen and a custom message of your choosing.
//Create a default case to handle any case not handled.

Console.WriteLine("What is your favorite school subject");
var answer = Console.ReadLine();

switch (answer.ToLower())
{
    case "math":
        Console.WriteLine("Math is cool");
        break;
    case "english":
        Console.WriteLine("You're a smartie");
        break;
    case "gym":
        Console.WriteLine("Drop and give me 20");
        break;
    case "lunch":
        Console.WriteLine("Lunch is the best subject");
        break;
    default:
        break;
}