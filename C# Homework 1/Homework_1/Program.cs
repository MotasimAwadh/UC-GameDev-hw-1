int health = 100;
String hero = "Ahmad";
Console.WriteLine("Health is equal to "+health);
damaged();
void damaged()
{
    health = health - 20;
    Console.WriteLine("health after damage is equal to "+health);
    Boost();
}
void Boost()
{
    health = health + 10;
    Console.WriteLine("health after taking boost equal to " + health);
}

