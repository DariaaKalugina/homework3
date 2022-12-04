Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n / 10000 % 10;
int n2 = n / 1000 % 10;
int r1 = n / 10 % 10;
int r2 = n % 10;
if (n < 10000 || n > 99999)
Console.Write("Вы ошиблись!");
else if (n1 == r2 && n2 == r1)
Console.Write("Это палиндром!");
else 
Console.Write("Это не палиндром!");