Console.Write("Please, input your name: ");
string username = Console.ReadLine();

//if (username == "Masha")  
// condition doesn't work properly cause many ways to type
// favorite username (e.g. MASHA masha mASHA ... and so on)

if (username.ToLower() == "masha")
// using the .ToLower() allows our program to convert all
// letters of our username to lower case before checking the condition
// now any variants of name is recognized 
{
    Console.WriteLine("Hura!!! This is our MASHA!!!");
}
else
{
    Console.WriteLine("Hi, ");
    Console.WriteLine(username);
}