//Напишите программу,
//которая будет выдавать название дня недели по заданному номеру.

Console.Write("Введите первое число от 1го до 7ми");
int a1 = int.Parse(Console.ReadLine());

switch (a1){
    case 1:
        Console.WriteLine("Понедельник");
        break;
    case 2:
        Console.WriteLine("Вторник");
        break;
    case 3:
        Console.WriteLine("Среда");
        break;
    case 4:
        Console.WriteLine("Четверг");
        break;
    case 5:
        Console.WriteLine("Пятница");
        break;
    case 6:
        Console.WriteLine("Суббота");
        break;
    case 7:
        Console.WriteLine("Воскресенине");
        break;
}