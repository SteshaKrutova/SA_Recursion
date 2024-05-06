// // Задача 1: Задайте значения M и N. 
// // Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

//This function outputs numbers from M to N. Function OutputMtoN for beautiful and conveniences, funcrion MtoN for recursion.
void OutputMtoN(){
    Console.WriteLine("Please, write two numbers.");
    Console.Write("M: ");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.Write("N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.Write("The result of your function: ");
    MtoN(M,N);
    void MtoN (int M, int N){
    if (M<N){
        Console.Write(M+" ");
        MtoN(M+1,N);
    }
    else if (M>N){
        Console.Write(M+" ");
        MtoN(M-1,N);
    }
    else  Console.Write(N);
}
}

// //Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

//This function for calculations function of Akkerman. The function AkkermanFunction for beautifun and conveniences,
// function A for recursion.
void AkkermanFunction(){
    Console.WriteLine("Please, print m and n.");
    Console.Write("m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("The result of your function: ");
    Console.WriteLine(A(m,n));
    int A ( int m, int n){
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
}

// //Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

//This function for output of array elements begginning with end. The function Array for beautiful, conveniec and recursion; 
// ArrayOutput for recursion.
void Array(){
Console.Write("Please, print something: ");
string str = Console.ReadLine();
if (str == ""){
    Console.WriteLine("Please, write something!!!");
    Array();
}
else{
int i = str.Length-1;
Console.WriteLine("Your array: ");
ArrayOutput(str,i);
 void ArrayOutput(string str, int i){
    if (i>=0){
        Console.Write(str[i]+"\n");
        ArrayOutput(str,i-1);
    }
}
}
}

//This function for output all functions.
void main(){
    OutputMtoN();
    Console.WriteLine();
    Console.WriteLine();
    AkkermanFunction();
    Console.WriteLine();
    Array();
}

main();