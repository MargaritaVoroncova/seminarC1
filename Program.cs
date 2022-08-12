//написать программу, которая будет принимать 2 числа и показывать большее и меньшее из них.

int userNumberFirst = new int();
int userNumberSecond = new int();

Console.WriteLine("Введите первое число: ");
userNumberFirst = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите второе число: ");
userNumberSecond = Convert.ToInt32(Console.ReadLine());

if(userNumberFirst>userNumberSecond)
{
Console.WriteLine ($"max = {userNumberFirst}");
 Console.WriteLine ($"min = {userNumberSecond}");
}
else
{
    Console.WriteLine ($"max = {userNumberSecond}");
    Console.WriteLine ($"min = {userNumberFirst}");
    
}