Console.WriteLine("FRÅGESPORT WOOO");

Console.WriteLine("Fråga 1: Vilken är min favoritfärg?");

int poäng = 0;
Console.WriteLine("a) lila, b) blå, c) orange");

string svar1=Console.ReadLine();
if (svar1=="c")
{
Console.WriteLine("WOO rätt svar :D");
poäng++;
}



else
{
    Console.WriteLine("FEL!!! >:(");
}

Console.WriteLine($"dina poäng är nu: {poäng}" );

Console.WriteLine("Fråga 2: Vad är min favorit smak?");
Console.WriteLine("a) jordgubb, b) grönt äpple, c) apelsin");
string svar2=Console.ReadLine();
if (svar2=="b")
{
poäng++;
Console.WriteLine("YAY RÄTT SVAR");

}
else
{
    Console.WriteLine("fel svar :(");

}

Console.WriteLine($"du har nu {poäng} poäng");

Console.WriteLine("Fråga 3: Vad heter min döda kanin?");
Console.WriteLine("a) bullen, b) lillen, c) tipsy");
string svar3= Console.ReadLine();
if (svar3=="b")
{
    poäng++;
    Console.WriteLine("WOOO RÄTT SVAR");
}

else
{
    Console.WriteLine("feeeeel");
}

if (poäng==3)
{
    Console.WriteLine("spelet är slut, du alla rätt!");
}
if (poäng==2)
{
Console.WriteLine("Grattis! Du fick nästan alla rätt!");

}
if (poäng==1)
{
    Console.WriteLine("hmm du fick bara 1 rätt :/ inte jättebra");
}

if (poäng==0)
{
Console.WriteLine("Wow det gick jättedåligt. du fick 0 rätt");

}

Console.ReadLine();
