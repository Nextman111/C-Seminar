// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// k1 = 5, b1 = 2, 
// k2 = 9, b2 = 4 -> (-0,5; -0,5)

//Ввод
double Imput(){
    double imput;
    while (double.TryParse(Console.ReadLine().Replace('.',','), out imput) == false){
        Console.WriteLine("Некорректное значение, введите натуральное число");
    }
    return imput;
}

//Решение
double[] ReturnSolution(double[,] arg){ 
    double[] solution = new double[3];
    
    // т.к. делим на (k1 - k2), не должно быть нуля в знаменателе, если k1 == k2
    // даем делаем solution[2] = -1 - будем считать за ошибку и вернем массив; 
    if (arg[0,0] == arg[1,0]){
        solution[2] = -1;
        return solution;
    }
    // ищем x = (b2 - b1) / (k1 - k2)
    solution[0] = (arg[1,1] - arg[0,1])/(arg[0,0] - arg[1,0]); //x

    // ищем y = k1*x + b1
    solution[1] = arg[0,0] * solution[0] + arg[0,1] ;//y
    return solution;
}

//Печать решения
void PrintSolutionInConsole(double[] solution){
    if(solution[2] == -1 ){
        Console.WriteLine("Линнии не пересекаются");
    }
    else{
        Console.WriteLine($"Точка пересечения: x = {solution[0]}, y = {solution[1]}");
    }
}

double[,] arguments = new double[2,2];
Console.WriteLine("Введите точку b1:");
arguments[0,0] = Imput();
Console.WriteLine("Введите точку k1:");
arguments[0,1] = Imput();
Console.WriteLine("Введите точку b2:");
arguments[1,0] = Imput();
Console.WriteLine("Введите точку k2:");
arguments[1,1] = Imput();

Console.WriteLine($"Имеем уравнения y = {arguments[0,0]} * x + {arguments[0,1]}, y = {arguments[1,0]} * x + {arguments[1,1]}");
PrintSolutionInConsole(ReturnSolution(arguments));