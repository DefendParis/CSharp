﻿//Un-comment below code and fix the issues
//Push to github

int RecursiveFibonacci(int first, int second, int count)
{
    count --;

    int nextnumber = first + second;
    
    if(count == 0) {
    
    }else{
        return RecursiveFibonacci(1, 1, 2);
    }
}

int lastFibo = RecursiveFibonacci(1,1,5);
Console.WriteLine("Last fibo number was " + lastFibo);
Console.ReadLine();

Console.ReadKey();



