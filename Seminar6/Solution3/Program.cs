// Задача 44: Не используя рекурсию, 
// выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

//Ввод
int Imput(){
    int imput;
    while (int.TryParse(Console.ReadLine().Replace('.',','), out imput) == false || imput < 1){
        Console.WriteLine("Некорректное значение, введите натуральное число");
    }
    return imput;
}

//Решение
int[] Fibonachi(int n){
    int[] res = new int[n];
    res[0] = 0;
    if (n == 1)
        return res;
    
    res[1] = 1;
    if (n == 2)
        return res;    
    
    for (int i=2; i < n; i++){
        res[i] = res[i-1]+res[i-2];
    }
    return res;
}

//Печать результата
void PrintResult(int[] res){
    Console.Clear();
    Console.Write($"Ряд первых {res.Length} чисел Фибоначи:\n");        
    foreach (var item in res){
        Console.Write($"{item} ");        
    }
}

Console.WriteLine("Введите натуральное число, программа покажет первые n чисел фибоначи");
var n = Imput();
PrintResult(Fibonachi(n));