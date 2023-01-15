using System;

//Basic Loops Lab


//Description Use a do-while loop to output "Hello, World!" in a loop. Each time you output
//"Hello, World!" ask the user whether they would like to continue.


do
{
    Console.WriteLine("Hello World!");
    Console.WriteLine("Would you like to continue? y/n?"); //continue running with a prompt at the end to see if they want to stop. 
    string choice2 = Console.ReadLine();
    while (choice2 != "y")
    {
        Console.WriteLine("See Ya!");
        return;
        
    }
} while (true);


//Description.  Prompt the user for a number. Use a for loop to output all the numbers from that number to 0.
//After that loop finishes, use another loop to output all the numbers from 0 to that number.

bool isValidNum1;
Console.WriteLine("Please enter a number");  //Prompt user to enter a number
string input1 = Console.ReadLine(); //stores input in the varible input
isValidNum1 = int.TryParse(input1, out int num1); //checks to see if the input can be used as an integer
if (isValidNum1 == true)
{
    for (int i = num1; i > 0; i--) // take input value and subtract 1 from it until 0 is reached
    {
        Console.WriteLine(i);
    }

    for (int i = 0; i <= num1; i++) // take input and add 1 to 0 until the input value is reached
    {
        Console.WriteLine(i);
    }
}
else if (isValidNum1 == false)   // if user does not enter an integer, display error message
{
    Console.WriteLine("Sorry, please enter only an integer");
}



//Description: A door has a keypad entry. The combination to get in is 13579.
//Write a while loop (not a do while loop) that asks the user to enter a key code.
//The loop will repeat as long as the user enters the wrong code.
//After the user enters the correct code, the program will print out a welcome message.




const int entryCode = 13579; //constant entry code pin does not change
bool isValidNum; //bool value for 
bool lockStatus = false; //door is set to locked by default

while (true)
{
      for (int i = 5; i > 0; i--)
      {

        Console.WriteLine(i + " attepts remain");
        Console.WriteLine("Please enter your passcode"); //propts user for thier passcode
        string input2 = Console.ReadLine(); //stores input in the varible input
        isValidNum = int.TryParse(input2, out int num2); //checks to see if the input can be used as an integer
        
            if (isValidNum == true) // if input was an int run this block of code
            {
                if (num2 == entryCode) //if the user types the correct passcode run this block
                {
                Console.WriteLine("Correct you may enter");
                lockStatus = true; // ulock door by changing lock status to true
                Environment.Exit(0);
                }
                else // if input is incorrect prompt user to try again
                {
                Console.WriteLine("Incorrect passcode, please try again...");
                }
            }
      }
        Console.WriteLine("Sorry that was too many attempts, Goodbye");   
        return;
}

