using DesignPatterns.Patterns;
using DesignPatterns.Patterns.Creational;

IRunnable[] runnables = { 
    new RunFactoryMethod(), 
    new RunAbstractFactory(), 
    new RunBuilder(),
    new RunPrototype(),
    new RunSingleton(),
};


foreach (var runnable in runnables)
{
    var title = runnable.GetType().Name;

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(new string('-', title.Length));
    Console.WriteLine(runnable.GetType().Name);
    Console.WriteLine(new string('-', title.Length));
    Console.ForegroundColor = ConsoleColor.White;

    runnable.Run();

    Console.WriteLine();
    Console.WriteLine();
}

