// variable declare

int a = 2;
string name= "Hasibul Hasan";
byte c = 255; // its highest range 255
char d = 'a';
double d2 = 20.125425;
float d3 = 0.21545f;
decimal d4 = 25;

// type casting

/*
 * 2 types of type casting
 * implicit
 * explicit
 */

// explicit casting
double myNum  = 1520.5;
int ok = (int)myNum;

// advance string to int

string s1 = "4585485";
int result  = 0;

if (int.TryParse(s1, out result))
{ 
    Console.WriteLine("Success = "+ result);
}
else
{
    Console.WriteLine("Faliure = "+ result);
}