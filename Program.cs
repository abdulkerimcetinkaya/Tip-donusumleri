using System;
namespace tip_donusumleri
{
    class program
    {
        private static void Main(String[] args){

            System.Console.WriteLine("******** bilinçsiz(İmplicit) dönüşüm *********");

            byte a = 5 ;
            sbyte b =10;
            short c = 30;

            int d = a+b+c;
            System.Console.WriteLine("d: " + d );

            long h = d;
            System.Console.WriteLine("h: " + h);

            float i = h;
            System.Console.WriteLine("i: " + i);

            string e ="kerim";
            char f = 'k';
            object g = e+ " " + f + " " +d;
            System.Console.WriteLine("g: " + g); 

            System.Console.WriteLine("******** bilinçli(Explicit) dönüşüm *********");

            int x = 4;
            int y = (byte)x;
            Console.WriteLine("y: " +y);

            int z = 100;
            byte t = (byte)z;
            System.Console.WriteLine("t: " + t);

            float w = 10.3f;
            byte v = (byte)w;
            System.Console.WriteLine("v " + v);

            System.Console.WriteLine("******** toString Methodu ***********");

            int xx  =6;
            string yy = xx.ToString();
            System.Console.WriteLine("yy " + yy);
            
            string zz = 12.5f.ToString();
            System.Console.WriteLine("zz : " + zz);

            System.Console.WriteLine("******** System.Convert Methodu ***********");

            string s1 = "10" , s2 = "20";
            int sayi1 , sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            toplam = sayi1 + sayi2; 
            System.Console.WriteLine("toplam " + toplam);

            System.Console.WriteLine("****** Parse Methodu *******");

            parseMethod();



        }

        public static void parseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);

            System.Console.WriteLine("rakam1 " + rakam1);
            System.Console.WriteLine("double1 " + double1);


        }
    }

    
}
