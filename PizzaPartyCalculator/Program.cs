//Pizza Party Calculator
//Author: Dr. Mary Lebens
//Date: 1/21/2025

//Declare variables
int numberOfGuests;
int slicesPerGuest = 3; //Assumes each guest wants 3 pieces
int slicesPerPizza = 8; //Standard pizza has 8 slices 

//Prompt the user to enter the number of guests
Console.Write("Enter the number of guests: ");

//Call the parse function to turn the value the user entered into an int
numberOfGuests = int.Parse(Console.ReadLine());

//Calculate the total number of slices needed:
int totalSlicesNeeded = numberOfGuests * slicesPerGuest;

//Calculate the number of pizzas required
int pizzasNeeded = (int)Math.Ceiling((double)totalSlicesNeeded / slicesPerPizza);

//Output the number of pizzas needed
Console.WriteLine($"For {numberOfGuests} guests, you'll need {pizzasNeeded} pizzas.");