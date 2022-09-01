//Skriv ett program som frågar efter användarens namn och skriver ut en hälsning på konsolen.
//Om namnet är "David" ska det skriva ut "Hej David!"

Console.WriteLine("Vad heter du?");
string name = Console.ReadLine();

Console.WriteLine("Hur många gånger ska jag hälsa?");
string number = Console.ReadLine();
int numberAsInt = int.Parse(number);

for (int i = 0; i < numberAsInt; i++)
{
    Console.WriteLine($"Hej {name}!");
}


//Skriv ett program som frågar användaren efter ett lösenord.
//Hitta på ett hemligt lösenord och spara det i en variabel.
//När användaren har skrivit in ett lösenord ska programmet jämföra med det
//sparade lösenordet och skriva ut om det var rätt eller inte. Använd en if-sats.

Console.WriteLine("Ange lösenord:");
string password = Console.ReadLine();
string secretPassword = "123";

if (password == secretPassword)
{
    Console.WriteLine("Det var RÄTT lösenord!");
}
else
{
    Console.WriteLine("Det var FEL lösenord!");
}

// Skriv ett program som frågar användaren efter ett tal.
// Det ska skriva ut om talet är mindre än 100, lika med 100 eller större.

Console.WriteLine("Ange ett tal:");
string num = Console.ReadLine();
int numAsInt = int.Parse(num);

if (numAsInt < 100)
{
    Console.WriteLine("Talet är mindre än 100");
}
else if (numAsInt == 100)
{
    Console.WriteLine("Talet är lika med 100");

}
else if (numAsInt > 100)
{
    Console.WriteLine("Talet är större än 100");

}

