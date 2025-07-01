// See https://aka.ms/new-console-template for more information
static string GetCon()
{
    Random random = new Random();
    int index = random.Next(0, 20);
    const string letters = "BCDFGHJKLMNPQRSTVWXYZ";

    var value = "";

    if (index >= letters.Length)
        value += letters[index / letters.Length - 1];

    value += letters[index % letters.Length];

    return value;
}
static string GetSpecialChar()
{
    Random random = new Random();
    int index = random.Next(0, 21);
    const string letters = "!£$%^&*()-_=+[{]}:@#/?";

    var value = "";

    if (index >= letters.Length)
        value += letters[index / letters.Length - 1];

    value += letters[index % letters.Length];

    return value;
}
static string GetVowel()
{
    Random random = new Random();
    int index = random.Next(0, 5);
    const string letters = "AEIOU";

    var value = "";

    if (index >= letters.Length)
        value += letters[index / letters.Length - 1];

    value += letters[index % letters.Length];

    return value;
}

static int GetNum()
{
    Random random = new Random();
    return random.Next(0, 10);
}
static string GetMsPass()
{
    string str = GetCon().ToUpper() + GetVowel().ToLower() + GetCon().ToLower() + GetNum() + GetNum() + GetNum() +
                 GetNum() + GetNum();
    return str;
}

static void GetRandomCharPass()
{
    Random random = new Random();
    Console.WriteLine("What length do you require for the password?");
    int length = Convert.ToInt32(Console.ReadLine());
    string str = "";
    string pass = "";
    for (int i = 0; i < length; i++)
    {
        bool value;
        if (random.Next(0, 2) == 1)
        {
            value = true;
        }
        else
        {
            value = false;
        }

        int ran = random.Next(0, 3);
        if (ran == 0)
        {
            str = GetCon();
        }
        else if(ran == 1)
        {
            str = GetVowel();
        }
        else if (ran == 2)
        {
            str = GetNum().ToString();
        }

        if (value)
        {
            str = str.ToLower();
        }

        pass = pass + str;
    }
    Console.WriteLine(pass);
}
Console.WriteLine("How many passwords do you want to generate?");
int passwords = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < passwords; i++)
{
    Console.WriteLine();
    Console.WriteLine("For Password "+(i+1)+": ");
    Console.WriteLine("Password Style?");
    Console.WriteLine("A = Old Microsoft Style (ie:Loy46265)");
    Console.WriteLine("B = Random string");
    Console.WriteLine("C = Old Microsoft + Chars");
    string choice = Console.ReadLine();
    if (choice == "A")
    {
        string pass = GetMsPass();
        Console.WriteLine(pass);
    }
    else if (choice == "B")
    {
        GetRandomCharPass();
    }
    else if (choice == "C")
    {
        string pass = GetSpecialChar()+GetMsPass()+GetSpecialChar();
        Console.WriteLine(pass);
    }
    else
    {
        Console.WriteLine("Incorrect choice");
        i --;
    }
    Console.WriteLine();
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}

