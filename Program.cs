using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            // atama 
            int x = 3;
            int y =3;

            y=y+2;
           Console.WriteLine(y);
            y+=2;
Console.WriteLine(y);

            y/=1;
            Console.WriteLine(y);
            x*=2;
            Console.WriteLine(x);

            //Mantıksal
            bool isSucces = true ;
            bool isCompleted = false ;

            if(isSucces && isCompleted )
            {
Console.WriteLine ("Perfect");
            }
            if(isSucces|| isCompleted )
            {
Console.WriteLine ("Great");
            }
            if(isSucces && !isCompleted )
            {
Console.WriteLine ("Fine");
            }


            // ilişkisel

            int a = 3;
            int b =4;
            bool sonuc = a<b;
           Console.WriteLine (sonuc);
           sonuc = a>b;
           Console.WriteLine (sonuc);
           sonuc = a>=b;
           Console.WriteLine (sonuc);
           sonuc = a==b;
           Console.WriteLine (sonuc);

           // aritmetik

           int s1=10;
           int s2= 5;
           int sonuc1= s1/s2;
            Console.WriteLine (sonuc1);
            int sonuc2= s1*s2;
            Console.WriteLine (sonuc2);
            int sonuc3= s1+s2;
            Console.WriteLine (sonuc3);

            // mod alma

            int sonuc4 = 20%3;
            Console.WriteLine(sonuc4 );


//     www.patika.dev

            
            




        }
    }
}
