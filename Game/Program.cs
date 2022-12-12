

string[] words = { "dog", "cat", "pen", "sos", "bag", "hug", "dig", "leg", "bug", "book" };

var rand = new Random();
int myRand = rand.Next(1, words.Length);
int wordsLength = words[myRand].Length;
string myWord = words[myRand];
int health = 6;
int count = 0;
List<char> wrongChar=new();
string[] userword = new string[wordsLength];

for (int i = 0; i < userword.Length; i++)
{
    userword[i] = "_ ";
}

for (int i = 0; i < wordsLength; i++)
{
    System.Console.Write("_");
}


for (int i = 0; i < wordsLength; i++)
{
    System.Console.Write("_ ");
}
System.Console.WriteLine();
Top:
System.Console.WriteLine("Type letter: ");
char searchWord = Convert.ToChar(Console.ReadLine());
bool checkWord=CheckChar(searchWord);

if(checkWord)
{
    goto Top;
}


bool findWord = myWord.Contains(searchWord);

if (findWord)
{
    for (int i = 0; i < myWord.Length; i++)
    {
        if (myWord[i] == searchWord)
        {
            userword[i] = searchWord.ToString();
            count++;
        }
    }

}
else
{
    wrongChar.Add(searchWord);
    health -= 1;
}
Console.Clear();
Drow();
Console.WriteLine("\n");
for (int i = 0; i < userword.Length; i++)
{
    Console.Write(userword[i]);
}
Console.WriteLine("\n");

if (count == myWord.Length)
{
    System.Console.WriteLine("you Win!!!");
    Console.ReadKey();
}

if (health != 0)
{
    goto Top;
}

void Drow()
{
 
    switch (health)
    {
        case 0:
            Console.WriteLine("__________");
            Console.WriteLine("|        |");
            Console.WriteLine("|        |");
            Console.WriteLine("|        O");
            Console.WriteLine("|        |");
            Console.WriteLine("|       /|\\");
            Console.WriteLine("|        |");
            Console.WriteLine("|       / \\");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|______");
            Console.WriteLine("\n");
            Console.WriteLine("Game Over \n");
            Console.WriteLine("Correct answer" +" "+ myWord);
            break;
        case 1:
            Console.WriteLine("__________");
            Console.WriteLine("|        |");
            Console.WriteLine("|        |");
            Console.WriteLine("|        O");
            Console.WriteLine("|        |");
            Console.WriteLine("|       /|\\");
            Console.WriteLine("|        |");
            Console.WriteLine("|       / ");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|______");
            break;
        case 2:
            Console.WriteLine("__________");
            Console.WriteLine("|        |");
            Console.WriteLine("|        |");
            Console.WriteLine("|        O");
            Console.WriteLine("|        |");
            Console.WriteLine("|       /|\\");
            Console.WriteLine("|        |");
            Console.WriteLine("|         ");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|______");
            break;
        case 3:
            Console.WriteLine("__________");
            Console.WriteLine("|        |");
            Console.WriteLine("|        |");
            Console.WriteLine("|        O");
            Console.WriteLine("|        |");
            Console.WriteLine("|       /|");
            Console.WriteLine("|         ");
            Console.WriteLine("|         ");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|______");
            break;
        case 4:
            Console.WriteLine("__________");
            Console.WriteLine("|        |");
            Console.WriteLine("|        |");
            Console.WriteLine("|        O");
            Console.WriteLine("|        |");
            Console.WriteLine("|        |");
            Console.WriteLine("|         ");
            Console.WriteLine("|         ");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|______");
            break;
        case 5:
            Console.WriteLine("__________");
            Console.WriteLine("|        |");
            Console.WriteLine("|        |");
            Console.WriteLine("|        O");
            Console.WriteLine("|         ");
            Console.WriteLine("|         ");
            Console.WriteLine("|         ");
            Console.WriteLine("|         ");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|______");
            break;
        case 6:
            Console.WriteLine("__________");
            Console.WriteLine("|        |");
            Console.WriteLine("|        |");
            Console.WriteLine("|         ");
            Console.WriteLine("|         ");
            Console.WriteLine("|         ");
            Console.WriteLine("|         ");
            Console.WriteLine("|         ");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|______");
            break;
        default:

            Console.WriteLine("__________");
            Console.WriteLine("|        |");
            Console.WriteLine("|        |");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|______");
            break;
    }
       foreach (var w in wrongChar)
    {
        Console.WriteLine($"[{w}]");
    }
    Console.Write("\n");
}


bool CheckChar(char word)
{
    var findChar=wrongChar.Where(x=>x==word).ToList();
    if (findChar.Count()>0)
    {
        System.Console.WriteLine("this char was alredy used.");
        return true;
    }
    return false;
}