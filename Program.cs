// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");
// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
void OutputMtoN (int M, int N){
    if (M<N){
        Console.WriteLine(M+" ");
        OutputMtoN(M+1,N);
    }
    else if (M>N){
        Console.WriteLine(M+" ");
        OutputMtoN(M-1,N);
    }
    else  Console.WriteLine(N);
}

OutputMtoN(5,5);

//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int A (int m, int n){
    if (m==0){
        return (n+1);
    }
    else if (m>0 && n==0){
        return A(m-1,1);
    }
    else{
        return A(m-1, A(m,n-1));
    }

}
Console.WriteLine(A (3,1));

//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

String str = "Iwonttoeat";

void Array(string str){
int i = str.Length-1;
ArrayOutput(str,i);
 void ArrayOutput(string str, int i){
    if (i>=0){
        Console.Write(str[i]);
        ArrayOutput(str,i-1);
    }
}
}

Array(str);
