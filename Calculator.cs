class Calculator
    { 
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            Console.write("Inputkan nilai a =  ");
			int a = int.Parse(Console.Readline());
			
			
            Console.write("Inputkan nilai b =  ");
			int b = int.Parse(Console.Readline());
			
			Console.WriteLine();
			
            Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            Console.WriteLine("Hasil Pengurangan " + a + " - " + b + " = " + Pengurangan(a, b));
            Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }

        static int Penambahan (int a,int b)
        {
            return a + b;
        }

        static int Pengurangan (int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static float Pembagian(float a, float b)
        {
            return  a / b;
        }
    }