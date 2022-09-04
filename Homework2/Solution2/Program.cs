// Задача 13: Напишите программу, 
// которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число, программа покажет третью цифру этого числа.");
string number = Console.ReadLine();

if (int.TryParse(number, out var input)){
        if (Math.Abs(input) > 99 ){
            int res = 0;
            if (input < 0 ){
                res = 1;
            }
            Console.WriteLine($"Вы ввели значение {input} . третья цифра равна {(int)(Math.Abs(input)%Math.Pow(10,number.Length-2-res) / Math.Pow(10,number.Length-3-res))}");
        }
        else{
            Console.WriteLine($"Третьей цифры в числе {input} нет.");
        }
    }
    else{
        Console.WriteLine("Вы ввели не число.");
}


