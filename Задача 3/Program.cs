// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear () ;
Console.WriteLine("Введите целое число N") ;
double N = double.Parse (Console.ReadLine ()!) ;
double i = 1 ;
while (i<=N) {
    Console.Write (Math.Pow(i, 3));
    Console.Write (", ");
    i++;
}

