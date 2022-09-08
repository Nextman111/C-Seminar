// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//функция проверки на палиндром (не обязательно пятизначного числа)
string Palindrom(string number){
    string pal = "палиндром";
    for (int i = 0 , j = number.Length-1; i < j ; i++, j-- ){
        if (number[i] != number[j]){
            pal = "не палиндром";
            break;
        }
    }
    return pal;
}

//ввод и проверка
Console.WriteLine("Введите пятизначное положительное натуральное число, программа покажет является ли оно палиндромом");
if (int.TryParse(Console.ReadLine(), out var imput)){
    if (imput >= 9999 & imput < 100000){
        //вызов функции и вывод результата
        Console.WriteLine($"Число {imput} {Palindrom(Convert.ToString(imput))}");
   }
    else{
        Console.WriteLine($"Число {imput} не натуральное пятизначное число");
    }
}
else{
    Console.WriteLine("Вы ввели не числовое значение");
}
