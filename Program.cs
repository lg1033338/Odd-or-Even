/* Divison Program
Created By: Logan Galindo
Takes in two numbers and divides 
*/

// Ask User for # 
Console.Write("Enter a number: ");

// Take in a string and convert
int x = Convert.ToInt32(Console.ReadLine());

// Using Mod to check if Even
if (x % 2 == 0)
{
    // If number was even then show "Even" to User
    Console.WriteLine("Even");
}
// Uses Mod to check if Odd
else if (x % 1 == 0)
{
    // If number was odd then show "Odd" to User
    Console.WriteLine("Odd");
}