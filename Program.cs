﻿using System;

    namespace operatorler
    {
        class Program
        {
            static void Main(string[] args)
            {
                 Console.WriteLine("Atama ve işlemli atama");
               // Atama ve işlemli atama
               int x=3;
               int y=3;

               y = y + 2;
               Console.WriteLine(y);
               y += 2;
               Console.WriteLine(y);

               y /= 1;
               Console.WriteLine(y);

               x+=2;
               Console.WriteLine(x);


                 Console.WriteLine("Mantıksal Operatatorler");
               //Mantıksal Operatatorler
               // ||, &&, !

               bool isSuccess = true;
               bool isCompleted = false;

               if(isSuccess && isCompleted)
               {
                Console.WriteLine("Perfect!");
               }

               if(isSuccess || isCompleted)
               {
                Console.WriteLine("Great!");
               }

               if(isSuccess && !isCompleted)
               {
                Console.WriteLine("Fine!");
               }


                Console.WriteLine("İliskisel Operatorler");
               // İliskisel Operatorler
               // ==, <, >, <=, >=, !=

               int a = 3;
               int b = 4;
               bool sonuc = a<b;

               Console.WriteLine(sonuc);
               sonuc = a>b;
               Console.WriteLine(sonuc);
               sonuc = a>=b;
               Console.WriteLine(sonuc);
               sonuc = a<=b;
               Console.WriteLine(sonuc);
               sonuc = a==b;
               Console.WriteLine(sonuc);
               sonuc = a!=b;
               Console.WriteLine(sonuc);

               Console.WriteLine("Aritmetik Operatorler");
               // Aritmetik Operatorler
               // /, *, +, -, 
               // % mod alır

               int sayı1 = 10;
               int sayı2 = 5;
               int sonuc1 = sayı1/sayı2;

               Console.WriteLine(sonuc1);

               sonuc1 = sayı1 * sayı2;
               Console.WriteLine(sonuc1);

               sonuc1 = sayı1 + sayı2;
               Console.WriteLine(sonuc1);

               sayı1 = sayı1++;
               Console.WriteLine(sayı1);

               sayı1 ++;
               Console.WriteLine(sayı1);

               int sonuc2 = 20 % 3;
               Console.WriteLine(sonuc2);



               
               
               



            }
        }
    }

