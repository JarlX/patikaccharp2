﻿using System;

namespace operations
{
    class Program
    {

        static void Main(string[] args)
        {   
            Console.WriteLine("********Atama Operatörler****************");
            //Atama ve işlemli atama
            int x = 3;
            int y = 3;
            y = y + 2;

            Console.WriteLine(y);
            y+= 2;
            Console.WriteLine(y);
            y/=1;
            Console.WriteLine(y);

            x*=2;
            Console.WriteLine(x);

            Console.WriteLine("********Mantıksal Operatörler****************");
            //Mantıksal Operatörler

            bool isSuccess = true;
            bool isCompleted = false;
            
            if(isSuccess && isCompleted)
            Console.WriteLine("Perfect!");

            if(isCompleted || isSuccess)
            Console.WriteLine("Great!");

            if(!isCompleted || isSuccess);
            Console.WriteLine("Fine");


            Console.WriteLine("********İlişkisel Operatörler****************");
            //İlişkisel Operatörler

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

            Console.WriteLine("********Aritmetik Operatörler****************");

            // / , * , + , - 

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1/sayi2; 
            Console.WriteLine(sonuc1);
            int sonuc2 = sayi1*sayi2;
            Console.WriteLine(sonuc2);
            int sonuc3 = sayi1+sayi2;
            Console.WriteLine(sonuc3);
            int sonuc4 = sayi1-sayi2;
            Console.WriteLine(sonuc4);
            int sonuc5 = ++sayi1;
            Console.WriteLine(sonuc5);

            // % mod alır
            int sonuc6 = 20 % 3;
            Console.WriteLine(sonuc6);



        }

    }


}