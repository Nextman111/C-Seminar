// Задача 23
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void CubeTable(int n){
    if (n > 0){
        for(int i = 1; i <= n; i++){
            Console.WriteLine($"{i} => {Math.Pow(i,3)}");
        }
    }
    else{
        Console.WriteLine("Некорректное значение");
    }
}

Console.WriteLine("Введите натуральное число N, программа выдаст таблицу кубов натуральных чисел от 1 до N");
if (int.TryParse(Console.ReadLine(), out int n)){
    CubeTable(n);
}
else{
    Console.WriteLine("Некорректное значение");
}