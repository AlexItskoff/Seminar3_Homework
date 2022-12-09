/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да

*/

Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine()!);

if (n < 10000 || n >99999)     // отсекаем не 5 - значные числа.
Console.WriteLine("Wrong number! We need numbers between 10000 and 99999!");

   if (n> 9999 && n < 100000 )
     
        Console.WriteLine("Good for you!");


     int fifthDigit = n%10;            // 5-я цифра
      //Console.WriteLine(fifthDigit);

      int fourthDigit = n/10%10;       // 4-я цифра
       //Console.WriteLine(fourthDigit);

       int thirdDigit = n/100%10;       // 3-я цифра
       //Console.WriteLine(thirdDigit);

       int secondDigit = n/1000%10;      // 2-я цифра
       //Console.WriteLine(secondDigit);

       int firstDigit = n/10000%10;      // 1-я цифра
       //Console.WriteLine(firstDigit);
       

          if ((firstDigit==fifthDigit) && (secondDigit==fourthDigit)&& (n> 9999 && n < 100000)) 
            // проверяем, палиндром ли это и опять проверяем на 5 значность
            //иначе код назовет палиндромом,например, число 70000000
       
       Console.WriteLine("This number is PALINDROM!!");

             else
               {   
                Console.WriteLine("No, it's not him");
               }
                

// Осталась проблема: Не получается остановить код если число не 5 - значное.
// код работает при любом введенном числе, хотя в идеале он должен останавливаться
// на строке 18, если число не 5 значное. Команды return и break не помогли.

                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                

       

 


