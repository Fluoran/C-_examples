
//#pragma warning disable

int count = 0,
    distance = 10000,
    firstFriendSpeed = 1,
    secondFriendSpeed = 2,
    dogSpeed = 5,
    friend = 2,
    time = 0;


while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 2;
    }
    if (friend == 2)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    System.Console.WriteLine(distance);
    count++;
}
System.Console.Write("Количество кругов которые пробежит собака = ");
System.Console.WriteLine(count);
