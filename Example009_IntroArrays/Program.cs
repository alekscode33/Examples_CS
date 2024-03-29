﻿// How to find Maximum from 9 numbers 
// using methods

int Max(int arg1, int arg2, int arg3)   // Method which used to compare numbers 
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

// int [] array = {1,2,3,4,5,6,7,8,9}; 
// Сейчас это 9 значений, идущих по порядку. 
// Далее правим значения и убираем лишнее:

//               0   1   2   3   4   5   6   7   8
int[] array = { 11, 21, 31, 4134, 15, 6134, 17, 18, 19 };

//array[0] = 12;                 // how to replace the value of array's 
// element with index [0] from 11 to 12

//Console.WriteLine(array[0]);   // this line shows via Console 
// the value of array's element with index [0]  -> now it's equals 12

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));

Console.WriteLine(result);





