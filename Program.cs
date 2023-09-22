string[] answer = { "2023", "Baden", "Zitrone", "Ja", "13", "27,5" }; // Antworten auf Fragen


string answer1;                     //Zuordnung Variablen
string answer2;
string answer3;
string answer4;
string answer5;
string answer6;
int point = 0;
Console.Write("Erste Frage: Welches Jahr haben wir?");
answer1 = Console.ReadLine();
if (answer1 == answer[0])                           // Einzelne Fragen
{
    point += 1;
    Console.WriteLine("Richtig");

}
else
{
    point -= 1;
    Console.WriteLine("Falsch");
}
Console.Write("Zweite Frage: Wo ist die BBB?");
answer2 = Console.ReadLine();
if (answer2 == answer[1])
{
    point += 1;
    Console.WriteLine("Richtig");

}
else
{
    point -= 1;
    Console.WriteLine("Falsch");
}
Console.Write("Dritte Frage: Welche Frucht ist gelb und sauer?");

answer3 = Console.ReadLine();
if (answer3 == answer[2])
{
    point += 1;
    Console.WriteLine("Richtig");

}
else
{
    point -= 1;
    Console.WriteLine("Falsch");
}
Console.WriteLine("Vierte Frage: Ging Albert Einstein in die Alte Kantonsschule Aarau zur Schule?");
answer4 = Console.ReadLine();
if (answer4 == answer[3])
{
    point += 1;
    Console.WriteLine("Richtig");

}
else
{
    point -= 1;
    Console.WriteLine("Falsch");
}
Console.WriteLine("Fünfte Frage: Was ist 6 plus 7?");
answer5 = Console.ReadLine();
if (answer5 == answer[4])
{
    point += 1;
    Console.WriteLine("Richtig");

}
else
{
    point -= 1;
    Console.WriteLine("Falsch");
}
Console.WriteLine("Sechste Frage: Was ist 14,5 plus 13?");
answer6 = Console.ReadLine();
if (answer6 == answer[5])
{
    point += 1;
    Console.WriteLine("Richtig");

}
else
{
    point -= 1;
    Console.WriteLine("Falsch");
}
Console.WriteLine("Du hast:" + point);                      //Ausgabe Punkte
Console.ReadLine();
