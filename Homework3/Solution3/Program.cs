// Задача 23
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void CubeTable(int n){
//     if (n > 0){
//         for(int i = 1; i <= n; i++){
//             Console.WriteLine($"{i} => {Math.Pow(i,3)}");
//         }
//     }
//     else{
//         Console.WriteLine("Некорректное значение");
//     }
// }

int[] CubeTable(int n){
    int[] res = new int[n];
    for(int i = 0; i < res.Length; i++){
        res[i] = (int)Math.Pow((i+1), 3);
    }
    return res;
    
}

void ConsoleTable(int[] table){
    for(int i = 0; i < table.Length; i++ ){
        Console.WriteLine($"{i+1} => {table[i]}");
    }
}

Console.WriteLine("Введите натуральное число N, программа выдаст таблицу кубов натуральных чисел от 1 до N");
if (int.TryParse(Console.ReadLine(), out int n)){
    if (n > 0){
        ConsoleTable(CubeTable(n));
    }
    else{
        Console.WriteLine("Некорректное значение");
    }
}
else{
    Console.WriteLine("Некорректное значение");
}