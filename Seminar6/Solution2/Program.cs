// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

//Ввод
int Imput(){
    int imput;
    while (int.TryParse(Console.ReadLine().Replace('.',','), out imput) == false || imput < 1){
        Console.WriteLine("Некорректное значение, введите натуральное число");
    }
    return imput;
}

//Преобразование в десятичное
int ParsToBinar(int number){
    string res = string.Empty;
    while (number > 0){
        if (number%2 == 1){
            res = res + '1';
        } 
        else{
            res = res + '0';
        }
        number = number/2;

    }
    return int.Parse(res);
}

Console.WriteLine("Введите целое число ");
int number = Imput();
Console.WriteLine($"Число {number} в двоичной системе это {ParsToBinar(number)}");