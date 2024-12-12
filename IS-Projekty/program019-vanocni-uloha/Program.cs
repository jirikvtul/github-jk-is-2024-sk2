using System.Diagnostics;       
        string again = "y";
        while(again == "y" || again == "Y") {
            // //Console.Clear();
            // Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");
            // Console.WriteLine("+++++++ Generátor pseudonáhodných čísel +++++++");
            // Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");
            // Console.WriteLine("++++++++++++++ Jiří Kvajsar +++++++++++++++++++");
            // Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++\n\n");
            // Console.WriteLine();

            // Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            // int n;
            // while(!int.TryParse(Console.ReadLine(), out n)) {
            //     Console.Write("Nezadali jste celé číslo. Zadejte znovu počet čísel (celé číslo):  ");    
            // }
            // Console.Write("Zadejte dolní mez (celé číslo): ");
            // int dm;
            // while(!int.TryParse(Console.ReadLine(), out dm)) {
            //     Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez (celé číslo):  ");    
            // }
            // Console.Write("Zadejte horní mez (celé číslo): ");
            // int hm;
            // while(!int.TryParse(Console.ReadLine(), out hm)) {
            //     Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez (celé číslo):  ");    
            // }

            // Console.WriteLine("\n\n==============================================");
            // Console.WriteLine("Uživatelský vstup: ");
            // Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            // Console.WriteLine("\n================================================\n\n");

            // //deklarace pole
            // int[] myArray = new int[n];

            // // příprava pro generování náhodných čísel
            // Random randomNumber = new Random();

            // Console.WriteLine("Náhodná čísla: ");
            // for(int i=0; i<n; i++){
            //     myArray[i] = randomNumber.Next(dm, hm+1);
            //     Console.Write("{0},", myArray[i]);
            // }
            // // Maximum a minimum
            // int max = myArray[0];
            // int min = myArray[0];
            
            // for(int i = 0; i < n; i++){
            //     if(max < myArray[i]){
            //         max = myArray[i];
            //     }
            //     else if(min > myArray[i]){
            //         min = myArray[i];
            //     }
            // }
            // Stopwatch Stopky = new Stopwatch();
            // Stopky.Start();
            // //Bubble sort
            // for(int i = 0; i < n-1; i++){
            //     for(int j = 0; j < n-i-1;j++){
            //         if(myArray[j] < myArray[j+1]){
            //             int temp = myArray[j];
            //             myArray[j] = myArray[j+1];
            //             myArray[j+1] = temp;
            //         }
                   
            //     }
            // }
            // Stopky.Stop();
            // // Aritmetický průměr
            // int sum = 0;
            // for(int i = 0; i < myArray.Length; i++){
            //     sum += myArray[i]; 
            // }
            // int average = sum / n;
            // int rest = sum % n;

            // // Console.WriteLine($"\n\n{sum}");

            // // Výpisy
            // Console.WriteLine("\n\nPole seřazené bubble sortem: ");
            // for(int i = 0; i < n; i++){
            //     Console.Write("{0} ", myArray[i]);
            // }

            // Console.WriteLine($"\n\nMaximum: {max}");
            // Console.WriteLine($"Minimum: {min}");

            // Console.WriteLine($"\n\nAritmetický průměr pole --> celá část: {average}, zbytek: {rest}");

            // Console.WriteLine($"Čas provedení sortu: {Stopky.Elapsed}");
            
            //Obrazec
                int hodnota = 5;
                for(int i = 0; i < hodnota; i++){
                    for(int j = 0; j < hodnota; j++){
                        Console.Write("  ");
                    }
                    for(int j = 0; j < hodnota - i; j++){
                        Console.Write(" *");
                    }
                    Console.WriteLine();
                }
            // Opakování programu
            Console.WriteLine("\n\nChcete program opakovat y/n?: ");
            again = Console.ReadLine();


        }