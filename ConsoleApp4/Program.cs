// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// An exception can simply be said to be any error/action/event that can interupt
// the normal flow of a program

var numerator = -15;
var denominator = -1;

var obj = new
{
    numerator = numerator,
    denominator = denominator
};
try
{
    var answer = obj.numerator / obj.denominator;
    
    Console.WriteLine(answer);

}
catch (ArithmeticException ex)
{
    Console.WriteLine($"Arithmetic Error: {ex.Message}\n");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}\n");
}
finally
{
    obj = null;
}



// steps involved in handling exception
// - put the happy code in try block
// - put the favourable message / option in catch block


// Simple senerio
/*
  - Define a file variable
  - open a file
  - read file content
  - file not found, return message that file was not found
  - close file
 */


// Joseph, Bassey
// open a file
try
{
    // read file content
}
catch(Exception e)
{
    // file not found, return message that file was not found
}
finally
{
    // close file
}

// Ifeoluwa, Peace, Chimezirim, Francis
try
{
    // open a file  - Might not b found, if on a different server - network failure
    // read file content - EOF issues, BOF issue, bench mark, unreadable character
}
catch (Exception e)
{
    // file not found, return message that file was not found
}
finally
{
    // close file
}

