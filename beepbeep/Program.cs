beep();
foreach (string arg in args)
{
    switch(arg)
    {
        case "beep":
            beep();
            break;
        case "boop":
            boop();
            break;
    }
}

static void beep()
{
    Console.Beep(1000, 700);
}

static void boop()
{
    Console.Beep(800, 700);
}
