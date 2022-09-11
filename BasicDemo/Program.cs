#region Uppgift 11 med extra
string[] siffror = new string[10] { "noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio" };

string input11 = Console.ReadLine();

string output = string.Empty;

foreach (var tecken in input11)
{
    string teckenString = "" + tecken;
    int inputTal = int.Parse(teckenString);
    output += siffror[inputTal] + "-";
}

//Alternativ lösning
//for (int i = 0; i < input11.Length; i++)
//{
//    string teckenString = "" + input11[i];
//    int inputTal = int.Parse(teckenString);
//    output += siffror[inputTal];
//    if (i < input11.Length-1)
//    {
//        output += "-";
//    }
//}

//output = output.Substring(0, output.Length - 1);

Console.WriteLine(output);
#endregion


# region Uppgift 14

//Skapa en lista med alla vokaler
char[] vokaler = new char[] { 'a', 'o', 'u', 'i', 'e', 'å', 'ä', 'ö', 'y' };

//Ta emot och spara en text från användaren
string input14 = Console.ReadLine();
char[] inputArr = input14.ToCharArray();


//För varje tecken i texten
for (int i = 0; i < inputArr.Length; i++)
{
    //    Om tecken är vokal
    for (int j = 0; j < vokaler.Length; j++)
    {
        if (input14[i] == vokaler[j])
        {
            //    ersätt med *
            inputArr[i] = '*';
            break;
        }
    }

    Console.Write(inputArr[i]);
}

//Alternativ lösning
//for (int i = 0; i < input.Length; i++)
//{
//    if (vokaler.Contains(input[i]))
//    {
//        //    ersätt med *
//        inputArr[i] = '*';
//    }
//}

// Skriv ut den förändrade texten
//string output = new string(inputArr);
//Console.WriteLine(output);

#endregion


#region Uppgift 14 Extra

//Niklas -> NoNikoklolasos

//char[] vokaler = new char[] { 'a', 'o', 'u', 'i', 'e', 'å', 'ä', 'ö', 'y' };

////Ta emot och spara en text från användaren
//string input = Console.ReadLine();
//string output = string.Empty;

////För varje tecken i texten
//for (int i = 0; i < input.Length; i++)
//{
//    string temp = string.Empty;
//    output += input[i];
//    if (vokaler.Contains(input[i]))
//    {
//        continue;
//    }
//    temp += "o" + input[i];
//    output += temp.ToLower();
//}

////    Skriv ut den förändrade texten
//Console.WriteLine(output);
//char[] vokaler = new char[] { 'a', 'o', 'u', 'i', 'e', 'å', 'ä', 'ö', 'y' };

////Ta emot och spara en text från användaren
//string input = Console.ReadLine();
//string output = string.Empty;
//bool isVokal = false;

//for (int i = 0; i < input.Length; i++)
//{
//    output += input[i];
//    for (int j = 0; j < vokaler.Length; j++)
//    {
//        if (input[i] == vokaler[j])
//        {
//            isVokal = true;
//            break;
//        }
//    }

//    if (!isVokal)
//    {
//        output += "o" + input[i];
//    }

//    isVokal = false;
//}

//Console.WriteLine(output);

#endregion
