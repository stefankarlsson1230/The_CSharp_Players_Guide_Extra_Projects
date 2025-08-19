//  Overview: Create a program that asks the user for character details (name, age, class, stats),
//      calculates derived values (e.g., attack power), and prints a formatted character sheet.
//
//  Core Features:
//      - Input: string, int, double        // No need for double
//      - Method for computing AttackRating()
//      - Validation (e.g., stat total must not exceed 100)
//      - Use of properties with validation
//      - Enum for class types(Warrior, Mage, Rogue)
// 
//  Comments
//      - I will use the stats: Strength, Dexterity, Power and Charisma
//      - Attack Rating = Strength + Dexterity
//      - The book has not yet covered Enums, but it isn't that hard
//      - Not sure what "properties" it's talking about in the validation part. We have not covered Classes and properties


// Get values
string name = GetName();
int age = GetAge();
CharClass charClass = GetClass();

int attributePoints = 100;
int str = GetAttribute("Strength", attributePoints);

attributePoints -= str;
int dex = GetAttribute("Dexterity", attributePoints);

attributePoints -= dex;
int pow = GetAttribute("Power", attributePoints);

attributePoints -= pow;
int cha = GetAttribute("Charisma", attributePoints);

int attackRating = AttackRating(str, dex);



// Present Character
// Could have used column width, but it felt unnecessary for this simple char-sheet

Console.WriteLine($"Name: {name}    Age: {age}   Class: {charClass}");
Console.WriteLine();
Console.WriteLine($"Strength (Str):\t\t{str}      Attack Rating:{attackRating}");
Console.WriteLine($"Dexterity (Dex):\t{dex}");
Console.WriteLine($"Power (Pow):\t\t{pow}");
Console.WriteLine($"Charisma (Cha):\t\t{cha}");




// ------------------- Local Functions -------------------

string GetName()
{
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Clear();

    return name;
}

int GetAge()
{
    int age = -1;

    while (age < 0)
    {
        Console.Write("Age: ");
        age = int.Parse(Console.ReadLine());
        if (age < 0)
        {
            Console.WriteLine("Age can not be negative!");
        }
    }

    Console.Clear();   
    return age;
}

CharClass GetClass()
{
    int choice = -1;

    while (choice < 1 || choice > 3)
    {
        Console.WriteLine("1. Warrior");
        Console.WriteLine("2. Mage");
        Console.WriteLine("3. Rogue");
        Console.Write("\nChoose a class: ");

        choice = int.Parse(Console.ReadLine());     // I don't check to se if the input can be converted to an int
        Console.Clear();
    }

    return choice switch
    { 
        1 => CharClass.Warrior,
        2 => CharClass.Mage,
        3 => CharClass.Rogue,
    };
}

int GetAttribute(string attribute, int pointsLeft)
{
    int input = 0;

    while(input < 1 || input > pointsLeft)
    {
        Console.WriteLine($"You have {attributePoints} points left.");
        Console.Write(attribute + ": ");
        input = int.Parse(Console.ReadLine());      // I don't check to se if the input can be converted to an int
        Console.Clear();
    }

    return input;
}

int AttackRating(int str, int dex) => str + dex;


// ------------------- Enums -------------------

enum CharClass
{
    Warrior,
    Mage,
    Rogue
}

