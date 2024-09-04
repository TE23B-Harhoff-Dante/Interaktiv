using System;




string choice = "";
string word = "";

Console.WriteLine("Du vaknar och ser två dörrar framför dig.\n");
Console.WriteLine("Den ena dörren är blå och den andra röd.\n");
Console.WriteLine("vilken dörr väljer du?");

choice = Console.ReadLine();


if (choice == "röd")
{

    Console.WriteLine("Du ser 3 nya dörrar");
    Console.WriteLine("\nEn svart, en grön och en lila");
    Console.WriteLine("\nVilken väljer du");

    word = Console.ReadLine();


    if (word == "lila")
    {

        Console.WriteLine("YAY det är dörren till en miljard kronor");
    }

    else if (word == "grön")
    {

        Console.WriteLine(" Det var en dörr till havet (du drunknar)");
    }
    else
    {

        Console.WriteLine(" Det var en dörr till dinosaurietiden (du blir förmodligen upäten)");
    }

}
else
{
    Console.WriteLine("\nEtt monster var bakom dörren och åt upp dig");
}



Console.ReadLine();