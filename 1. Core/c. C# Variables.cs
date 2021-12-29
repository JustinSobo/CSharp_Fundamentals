// Declaring (Creating) Variables
type variableName = value;
// Types: int, double, char, string, bool

// Examples:
// Create a variable called name of type string and assign it the value "John":
string name = "John";
Console.WriteLine(name);

// Create a variable called myNum of type int and assign it the value 15:
int myNum = 15;
Console.WriteLine(myNum);

// You can also declare a variable without assigning the value, and assign the value later:
int myNum;
myNum = 15;
Console.WriteLine(myNum);

// Change the value of myNum to 20:
int myNum = 15;
myNum = 20; // myNum is now 20
Console.WriteLine(myNum);

// Constants
const int myNum = 15;
myNum = 20; // error because constant makes declares the var as read-only. A const field requires a value to be provided.

// Other types
int myNum = 5;
double myDoubleNum = 5.99D;
char myLetter = 'D';
bool myBool = true;
string myText = "Hello";

// Display Variables
string name = "John";
Console.WriteLine("Hello " + name);

// You can also use the + character to add a variable to another variable:
string firstName = "John ";
string lastName = "Doe";
string fullName = firstName + lastName;
Console.WriteLine(fullName);

// For numeric values, the + character works as a mathematical operator (notice that we use int (integer) variables here):
int x = 5;
int y = 6;
Console.WriteLine(x + y); // Print the value of x + y

// Declare Many Variables
int x = 5, y = 6, z = 50;
Console.WriteLine(x + y + z);
