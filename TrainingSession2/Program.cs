#region// program to accept two integers and check whether they are equal or not.

//int a;
//int b;

//Console.WriteLine("Enter a no");

//a=Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter a no");

//b=Convert.ToInt32(Console.ReadLine());  

//if(a==b)
//{
//    Console.WriteLine(" Two integers are same");
//}
//else
//{
//    Console.WriteLine("Two intergers are not same");
//}
//Console.ReadLine();
//..............................................................................................................................
#endregion

#region//program to check whether a given number is positive or negative.

//int a;


//Console.WriteLine("Write a number");

//a=Convert.ToInt32(Console.ReadLine());

//if(a>=0)
//{
//    Console.WriteLine("Given number is Positive");

//}
//else
//{
//    Console.WriteLine("Given number is Negative");
//}
//Console.ReadLine();
#endregion
//..............................................................................................................................

#region//program to find out whether a given year is a leap year or not.

//int a;
//Console.WriteLine("Enter a year");

//a=Convert.ToInt32(Console.ReadLine());

//if(a > 0)
//{
//    if(a % 4 == 0)
//    {
//        Console.WriteLine(" This is Leap Year");
//    }
//    else
//    {
//        Console.WriteLine(" This is not a leap year");
//    }
//}
#endregion
//..............................................................................................................................
#region//program to read the age of a candidate and determine whether it is eligible for casting his/her own vote

//int a ;

//Console.WriteLine("Enter a Age");

//a=Convert.ToInt32(Console.ReadLine());

//if(a<=18)
//{
//    Console.WriteLine("Not Eligible for Vote");
//}
//else
//{
//    Console.WriteLine(" Eligible for Vote");
//}
#endregion
//.............................................................................................................................

#region// program to read the value of an integer m and display the value of n is 1 when m is larger than 0,
// 0 when m is 0 and -1 when m is less than 0.

//int m;
//int n;

//Console.WriteLine("Write Value of m");

//m=Convert.ToInt32(Console.ReadLine());



//if (m > 0)
//{
//    Console.WriteLine(" The value of n is " );
//    Console.WriteLine( n = 1);
//}
//else 
//{
//    Console.WriteLine("the value of m is " );
//    Console.WriteLine(m = 0);
//    Console.WriteLine(m = -1);
//}
#endregion
//.............................................................................................................................
#region//For Loop (Write a program in C# Sharp to display the first 10 natural numbers)

//Console.WriteLine("The First 10 Natural Numbers are ");

//for ( int i=1; i <= 10; i++)
//{
//    Console.WriteLine(i);
//}
//Console.ReadLine();
#endregion
//..............................................................................................................................

#region
//Write a C# Sharp program to find the sum of the first 10 natural numbers.

//int i;
//int sum = 0;


//for (i = 1; i <= 10; i++)
//{
//    sum = sum + i;

//    Console.WriteLine( i);
//}
//Console.WriteLine("The Sum of First 10 numbers are " +sum);
//Console.ReadLine();
#endregion
//..............................................................................................................................

#region//Write a C# Sharp program that displays the sum of n natural numbers.

//int i;
//int j;
//int sum = 0;

//Console.WriteLine("Enter any one number");
//i=Convert.ToInt32(Console.ReadLine());

//for (j = 0; j <= i; j++) 
//{
//    sum=sum+j;

//}
//Console.WriteLine("The sum of numbers are " + sum);
#endregion
//..............................................................................................................................

#region//Write a  program to read 10 numbers and find their average and sum.

//int i;
//int sum = 0;
//double avg;



//Console.WriteLine("all 10 numbers are here");



//for (i = 1; i <= 10; i++)
//{
//    Console.WriteLine(i);
//    sum += i;

//}
//Console.WriteLine("The Sum of 10 numbers are " + sum);


//avg = sum / 10.0;

//Console.WriteLine("The average of 10 numbers are " +avg);
#endregion
//.............................................................................................................................

#region//Write a program to display the cube of an integer up to given number.


//int n;
//int sum = 0;

//Console.WriteLine("Write any one Number");

//n = Convert.ToInt32(Console.ReadLine());

//for (int i = 1; i <= n; i++)
//{
//    sum = i * i * i;
//    Console.Write(sum + " ");
//    Console.WriteLine();
//}
//Console.WriteLine("Cube of this number is " + sum);
#endregion
//..............................................................................................................................
#region//Write a to display the multiplication table of a given integer.

//int n = 15;

//for (int i = 1; i < 15; i++)
//{
//    Console.WriteLine("{0} * {1}={2}", n, i, (n * i));
//}
#endregion

//..............................................................................................................................

#region//write a program to display the multiplication table vertically from 1 to n(8)

//int j, i, n;

//Console.Write("Write any number " );
//n=Convert.ToInt32( Console.ReadLine() );

//for (i = 1; i <= 10; i++)
//{
//    for (j = 1; j <= n; j++)
//    {

//        Console.Write("{0} * {1} = {2}             ", i, j, i * j);
//    }
//    Console.WriteLine();
//}
#endregion
//..............................................................................................................................
#region//Write a  program to display the n terms of odd natural numbers and their sums.




//int sum = 0;
//Console.Write("Enter value a Number:");
//int Number = Convert.ToInt32(Console.ReadLine());
//start with 1
//1+2 = 3
//3+2 = 5
//for (int i = 1; i <= Number; i += 2)
//{
//    sum += i;
//}
//Console.Write($"Sum of Odd numbers from 1 to {Number} is : {sum}");
//Console.ReadLine();

#endregion
//..............................................................................................................................

#region//Write a program in C# Sharp to display a right angle triangle with an asterisk.


//int i, j, rows;

//Console.WriteLine("Write any number");

//rows = Convert.ToInt32(Console.ReadLine());

//for(i = 1; i <= rows; i++)

//{
//    for(j = 1; j <= i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();

//}
//Console.ReadLine() ;
#endregion
//...............................................................................................................................


#region//Write a program to display a pattern like a right angle triangle with a number



//int i, j, num;

//Console.WriteLine("Write any number");

//num = Convert.ToInt32(Console.ReadLine());

//for (i = 1; i <= num; i++)

//{
//    for (j = 1; j <= i; j++)
//    {
//        Console.Write(j + " ");
//    }
//    Console.WriteLine();

//}
//Console.ReadLine();
#endregion
//..............................................................................................................................

#region// Write a program to make such a pattern like a right angle triangle with a number which repeats a number in a row.

//int col, rows;

//for (rows = 1; rows <= 5; rows++)
//{
//    for (col = 1; col <= rows; col++)
//    {
//        Console.Write(rows);
//    }
//    Console.WriteLine();
//}
//Console.ReadLine();
#endregion
//..............................................................................................................................

#region//Write a C# Sharp program to make such a pattern like a right angle triangle with the number increased by 1.


//int i, j, rows, k = 1;

//Console.Write("Write any number ");
//rows = Convert.ToInt32(Console.ReadLine());
//for (i = 1; i <= rows; i++)
//{
//    for (j = 1; j <= i; j++)

//        Console.Write(k++ + " ");

//    Console.WriteLine();
//}

//Console.ReadLine();
#endregion
//..............................................................................................................................

#region// to calculate the factorial of a given number
//6*5*4*3*2*1=720


//int num,i,fact = 1;

//Console.WriteLine("Enter any value");

//num=Convert.ToInt32(Console.ReadLine());

//for(i=1;i<=num;i++)
//{
//    fact=fact*i;
//}
//Console.WriteLine("factorial of above no is " + fact);
#endregion

//..............................................................................................................................

#region/Write a program in C# Sharp to display the n terms of even natural number and their sum.

//int i, n, sum = 0;

//Console.Write("Write any number : ");
//n = Convert.ToInt32(Console.ReadLine());

//for (i = 1; i <= n; i++)
//{
//    Console.Write(2 * i);
//    sum = 2 * i;
//    Console.WriteLine();
//}
//Console.WriteLine("The sum of even natural numbers are " + sum);


#endregion
//...............................................................................................................................






















































