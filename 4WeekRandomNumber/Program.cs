
//int sum = 0;

//for (int i = 1; i < 4; i++) /*i--=i-1*/
//{
//    Console.WriteLine($"i={i}");
//    Console.WriteLine($"Current total: {sum}");
//    sum = sum + 1;
//}

Random rnd = new Random();

int myRandomNum;
    int randomSum = 0;

for (int i = 0; i < 3; i++)
{
myRandomNum = rnd.Next(0, 11); /*0-10*/
    randomSum = randomSum + myRandomNum;
Console.WriteLine($"My random number is: {myRandomNum}");
}
Console.WriteLine($"Random sum total: {randomSum}");
