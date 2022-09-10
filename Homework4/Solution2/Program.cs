// Задача 27: Напишите программу,
// которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// метод расчета суммы цифр в числе
int SumOfDigitsInNumber(double number){
    string str = Convert.ToString(number).Replace(",","").Replace("-","");
    int res = 0;
    for (int i = 0; i < str.Length; i++){
        res = res + Convert.ToInt32(Convert.ToString(str[i]));
    }
    return res;
}

Console.WriteLine("Введите число любое число, программа расчитает сумму цифр этого числа.");

//imput A
Console.Write("Введите число ");
double imputA = 0;
while (double.TryParse(Console.ReadLine().Replace('.',','), out imputA) == false){
    Console.WriteLine("Некорректное значение, введите число, можно дробное");
}

Console.WriteLine($"Сумма цифр числа {imputA} равна {SumOfDigitsInNumber(imputA)}");

