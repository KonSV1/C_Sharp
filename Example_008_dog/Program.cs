﻿int count = 0;
double distance = 10000;
int firstFriendSpeed = 1, secondFriendSpeed = 2, dogSpeed = 5;
int friend = 2;
double time = 1;
while(distance > 10)
{
  if(friend == 1)
  {
    time = (distance / (firstFriendSpeed + dogSpeed));
    //Console.WriteLine(time);
    friend = 2;
  }
  else
  {
    time = distance / (secondFriendSpeed + dogSpeed);
   // Console.WriteLine(time);
    friend = 1;  
  }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    //Console.WriteLine(distance);
    count = count + 1;
}
Console.Write("Собака пробежит ");
Console.Write(count);
Console.Write(" раз");
