using System.Runtime.InteropServices;

{
    Tree tree = new Tree();
    bool Full = true;
    Console.WriteLine("menu:");
    int searched = 0;
    while (Full)
    {
        Console.WriteLine("press 1 to add Node");
        Console.WriteLine("press 2 to enter the desired node");
        ConsoleKey key = Console.ReadKey().Key;
        switch (key)
        {
            case ConsoleKey.D1:
                tree.Add(Int32.Parse(Console.ReadLine()));
                break;
            case ConsoleKey.D2:
                searched = Int32.Parse(Console.ReadLine());
                break;
                Full = false;
            default:
                Console.WriteLine("\nyou input wrong key");
                break;
        }
    }

    Node result = tree.Search(searched);
    if (result != null)
    {
        Console.WriteLine("Node found: " + result.Data);
    }
    else
    {
        Console.WriteLine("Node not found.");
    }
}