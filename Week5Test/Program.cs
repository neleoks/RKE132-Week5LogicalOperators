//double height, weight;
//double userBMI;
//Console.WriteLine("Enter your height in cm:");
//height = Int32.Parse(Console.ReadLine());
//Console.WriteLine("Enter your weight in kg:");
//weight = Int32.Parse(Console.ReadLine());
//userBMI = Math.Round((weight / (height * height) * 10000));
//Console.WriteLine($"test {userBMI}");
//if (userBMI < 19)
//{
//  Console.WriteLine("Underweight");
//}
//else if (userBMI >= 19 && userBMI < 25)
//{
//  Console.WriteLine("Normal weight.");
//}
//else if (userBMI >= 25 && userBMI < 30)
//{
//  Console.WriteLine("Overweight");
//}
//else
//{
//  Console.WriteLine("Obesity");
//}

//Console.WriteLine("Enter username:");
//string userName = Console.ReadLine();

//Console.WriteLine("Enter password:");
//string Password = Console.ReadLine();

//if (userName == "admin" && Password == "admin1234")
//{
// Console.WriteLine("Welcome!");
//}
//else
//{
//  Console.WriteLine("Invalid login credentials.");
//}

//Console.WriteLine("Enter username:");
//string userName = Console.ReadLine();

//Console.WriteLine("Enter password:");
//string password = Console.ReadLine();

//if (userName != "admin" || password != "admin1234")
//{
//   Console.WriteLine("Invalid login credentials.");
//}
//else
//{
//    Console.WriteLine("Welcome!");
//}

//Console.WriteLine("Enter the first letter of your first name:");
//char userLetter = Char.Parse(Console.ReadLine().ToLower());

//if (userLetter == 'a' || userLetter == 'e' || userLetter == 'i' || userLetter == 'o' || userLetter == 'u')
//{
//   Console.WriteLine("I can sing it.");
//}
//else
//{
//  Console.WriteLine("There is no way I can sing it.");
//}

string userPIN, userName, password;
Console.WriteLine("Enter PIN:");
userPIN = Console.ReadLine();
if (userPIN == "1234")
{
    Console.WriteLine("Enter your username:");
    userName = Console.ReadLine();
    Console.WriteLine("Enter your password:");
    password = Console.ReadLine();
    if (userName == "admin1" && password == "admin1234")
    {
        Console.WriteLine("Welcome!");
    }
    else
    {
        Console.WriteLine("Invalid login credentials");
    }
}
else
{
    Console.WriteLine("Invalid PIN");
}
