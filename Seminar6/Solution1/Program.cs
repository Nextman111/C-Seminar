// Задача 40: Напишите программу,
// которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.

//Ввод
double Imput(){
    double imput;
    while (double.TryParse(Console.ReadLine().Replace('.',','), out imput) == false || imput < 1){
        Console.WriteLine("Некорректное значение, введите натуральное число");
    }
    return imput;
}

//Решение
bool IsTriangle(double[] triangle){
    var res = false;
    if(triangle[0]+triangle[1] > triangle[2] &&
        triangle[1]+triangle[2] > triangle[0] &&
        triangle[0]+triangle[2] > triangle[1] ){
        res = true;
    }
    return res;
}

//Вывод
void PrintResultInConsole(bool res){
    string result = "не существует";
    if(res) result = "существует";
    Console.WriteLine($"Треугольник с такими сторонами {result}");
}

var triangle = new double[3];
Console.WriteLine("Введите 3 стороны треугольника, программа покажет может ли существовать треугольник с такими сторонами");
Console.WriteLine("Сторона A: ");
triangle[0] = Imput();
Console.WriteLine("Сторона C: ");
triangle[1] = Imput();
Console.WriteLine("Сторона B: ");
triangle[2] = Imput();

PrintResultInConsole(IsTriangle(triangle));