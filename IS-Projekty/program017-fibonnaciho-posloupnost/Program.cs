using System.Diagnostics;
      // chci, aby se program opakoval po stisku klávesy a 
        string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+++++++ Fibonacciho posloupnost +++++++");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("++++++++++++ Jiří Kvajsar +++++++++++++");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++\n\n");
            Console.WriteLine();

            // Vstup od uživatele - lepší varianta
            Console.Write("Zadejte první číslo řady (celé číslo): ");
            ulong n;
            while(!ulong.TryParse(Console.ReadLine(), out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu první číslo řady (celé číslo):  ");    
            }

            Stopwatch myStopwatch = new Stopwatch();

            myStopwatch.Start();
            ulong[] myArray = new ulong[n+1];
            ulong fibonacci_n = 0;
            ulong last_fibonnaci = 0;
            ulong sum_fibonnaci = 0;
            for(ulong i = 0; i <= n; i++){
               if(i == 0){
                 myArray[i] = 0;
                 fibonacci_n = 0; 
               }
               else if (i == 1){
                myArray[i] = 1;
                fibonacci_n = 1;
               }
               else{
                myArray[i] = myArray[i-1] + myArray[i - 2];
                fibonacci_n++;
               }
            }
            // Nález posledního prvku
            for(ulong i = 0; i <= n; i++){
                if(i == n){
                last_fibonnaci = myArray[i]; 
               }
            }
            for(ulong i = 0; i <= n; i++){
                sum_fibonnaci = myArray[i] + sum_fibonnaci;
            }
            myStopwatch.Stop();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nFibonnaciho posloupnost:");
            for(ulong i = 0; i <= n; i++){
                Console.Write($"{myArray[i]} ");
            }
            
            Console.WriteLine($"\n{fibonacci_n}. prvek Fibonacciho posloupnosti je: {last_fibonnaci}");

            Console.WriteLine($"Součet posloupnost (do {fibonacci_n} prvku): {sum_fibonnaci}\n");
            Console.WriteLine($"Čas trvání výpočtu: {myStopwatch.Elapsed}");
            
            // Opakování programu
            Console.WriteLine("\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();


        }            
