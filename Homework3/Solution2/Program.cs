// Задача 21
// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

//Расстояние между точками в трехмерном пространстве — это число, 
//равное корню из суммы квадратов разностей координат точек.

//Функция валидации
double ImputPointValidation(){
    double point;
    while (double.TryParse(Console.ReadLine().Replace('.',','), out point) == false){
            Console.WriteLine("Некорректное значение, введите число, можно дробное");
    }
    return point;
}

//вызов ввода
double[] ImputPoint(){
    double[] point = new double[3];
    
    Console.WriteLine("Введите координату X");
    point[0] = ImputPointValidation();
    
    Console.WriteLine("Введите координату Y");
    point[1] = ImputPointValidation();
    
    Console.WriteLine("Введите координату Z");
    point[2] = ImputPointValidation();
    
    return point;
}

//формула расчета расстояния в трехмерном пространстве
double Distance(double[] pointA, double[] pointB){
    double result = 0;
    for (int i = 0; i <3; i++){
       result = result + Math.Pow(pointA[i] - pointB[i], 2);
    }
    return Math.Sqrt(result);
}

//imput and verification
Console.WriteLine("Введите координаты двух точек в 3D пространстве, программа расчитает расстояние между ними.");
Console.WriteLine("Введите координаты точки A в формате > X Y Z < разделитель пробел :");
double[] pointA = ImputPoint();
Console.WriteLine("Введите координаты точки B в формате > X Y Z < разделитель пробел :");
double[] pointB = ImputPoint();

//вызов формулы
Console.WriteLine($"Расстояние между координатами A({pointA[0]} {pointA[1]} {pointA[2]}) и B({pointB[0]} {pointB[1]} {pointB[2]}) равно {Distance(pointA,pointB)}");