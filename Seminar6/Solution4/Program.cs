// Задача 45: Напишите программу, 
// которая будет создавать копию заданного 
// массива с помощью поэлементного копирования.

//поэлементное копирование
int[] CopyArray(int[] arr){
    var res = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++){
        res[i] = arr[i];        
    }
    return res;
}

//Ввод
int Imput(){
    int imput;
    while (int.TryParse(Console.ReadLine().Replace('.',','), out imput) == false){
        Console.WriteLine("Некорректное значение, введите натуральное число");
    }
    return imput;
}

//Печать массива
void PrintArray(int[] arr){
    foreach (var item in arr){
        Console.Write(item + " ");        
    }
}

Console.WriteLine("Задайте массив, программа скопирует его поэлементно.");
Console.WriteLine("Введите длинну массива:");
int size;
while (int.TryParse(Console.ReadLine().Replace('.',','), out size) == false || size < 1){
    Console.WriteLine("Некорректное значение, введите натуральное число");
}

var array = new int[size];
for (int i = 0; i < array.Length; i++){
    Console.WriteLine($"Введите элемент №{i+1}");
    array[i] = Imput();
}

var copyarray = CopyArray(array);
PrintArray(copyarray);
