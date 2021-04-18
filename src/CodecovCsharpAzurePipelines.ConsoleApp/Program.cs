using System;
using CodecovCsharpAzurePipelines;

ShowTypes();

static void ShowTypes()
{
    Console.WriteLine();
    Console.WriteLine("What do you want to try?");
    Console.WriteLine("1. Fully covered");
    Console.WriteLine("2. Partially overed");
    Console.WriteLine("3. Uncovered");
    Console.WriteLine();
    Console.WriteLine("Select a type...");

    var result = Console.ReadKey(intercept: true);
    
    switch (result.Key)
    {
        case ConsoleKey.D1:
            ShowCovered<FullyCoveredType>();
            return;
        case ConsoleKey.D2:
            ShowCovered<PartiallyCoveredType>();
            return;
        case ConsoleKey.D3:
            ShowCovered<UncoveredType>();
            return;
    }

    ShowTypes();
}

static Options ShowOptions()
{
    Console.WriteLine();
    Console.WriteLine("What's your answer?");
    Console.WriteLine("1. Yes");
    Console.WriteLine("2. No");
    Console.WriteLine("3. Maybe");
    Console.WriteLine();
    Console.WriteLine("Select an option...");

    var result = Console.ReadKey(intercept: true);

    switch (result.Key)
    {
        case ConsoleKey.D1:
            return Options.Yes;
        case ConsoleKey.D2:
            return Options.No;
        case ConsoleKey.D3:
            return Options.Maybe;
    }
    return ShowOptions();
}

static void ShowCovered<T>()
    where T: ICoveredType, new()
{
    var type = new T();

    var option = ShowOptions();

    var result = type.GetResult(option);

    Console.WriteLine();
    Console.WriteLine($"Result: {result}");
    Console.WriteLine();
    Console.WriteLine("----------");

    ShowTypes();
}