﻿//lerissa lazar
//10-19-22
//say hello

Console.Clear();

string? name;
bool loop = true;
while (loop)
{
    Console.WriteLine("Hello!");
    Console.WriteLine("What is your name?");

    name = Console.ReadLine();

    Console.WriteLine($"Hello {name} <3");

    Console.WriteLine("Do you want to introduce yourself again? (Yes or No)");

    bool validLoopInput = false;
    while (!validLoopInput)
    {
        string loopInput = Console.ReadLine().ToLower();

        if (loopInput == "yes")
        {
            validLoopInput = true;
        }
        else if (loopInput == "no")
        {
            validLoopInput = true;
            loop = false;
            Console.WriteLine("Well it was nice to meet you, bye now!");
        }
        else
        {
            Console.WriteLine("Invalid input. Enter Yes or No");
        }

    }
}


