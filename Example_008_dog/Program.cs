int count = 0;
int dist = 10000;
int firstFriendSpeed = 1, secondFriendSpeed = 2, dogSpeed = 5;
int friend = 1;
while(dist < 10)
{
    if(friend == 1)
    {
      double time = (dist / (firstFriendSpeed + dogSpeed));
      int friend = 2;
    }
    else
    {
        double time = dist / (secondFriendSpeed + dogSpeed);
        int friend = 1;  
    }
    double dist = dist-(firstFriendSpeed+secondFriendSpeed)*time;
    count += 1;
}
Console.Write("Собака пробежит ");
Console.Write(count);
Console.Write(" раз");
