//declare variables
int milesDriven;
int gallonsUsed;

//prompt user for number of miles driven
Console.Write("Enter the number of miles driven: ");
//parse to turn value of input into an int
milesDriven = int.Parse(Console.ReadLine());

//prompt user for amount of gasoline used
Console.WriteLine("Enter the amount of gasoline used in gallons:");
//parse to turn value of input into an int
gallonsUsed = int.Parse(Console.ReadLine());

//calculate MPG (Miles per gallon)
double mpg = milesDriven / gallonsUsed;

//display mpg to user
Console.WriteLine($"The miles per gallon is {mpg}");
