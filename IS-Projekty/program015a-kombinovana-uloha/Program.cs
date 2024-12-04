string again = "y";
        while(again == "y" || again == "Y") {
            //Console.Clear();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+++++++ Generátor pseudonáhodných čísel +++++++");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("++++++++++++++ Jiří Kvajsar +++++++++++++++++++");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++\n\n");
            Console.WriteLine();

            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu počet čísel (celé číslo):  ");    
            }
            Console.Write("Zadejte dolní mez (celé číslo): ");
            int dm;
            while(!int.TryParse(Console.ReadLine(), out dm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez (celé číslo):  ");    
            }
            Console.Write("Zadejte horní mez (celé číslo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(), out hm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez (celé číslo):  ");    
            }

            Console.WriteLine("\n\n===================");
            Console.WriteLine("Uživatelský vstup: ");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("\n\n===================\n\n");

            //deklarace pole
            int[] myArray = new int[n];
            int[] positionsMax = new int[n];
            int[] positionsMin = new int[n];
            // příprava pro generování náhodných čísel
            Random randomNumber = new Random();

            Console.WriteLine("Náhodná čísla: ");
            for(int i=0; i<n; i++){
                myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write("{0},", myArray[i]);
            }

            int max = myArray[0]; // První maximum
            int max_2 = int.MinValue; // Druhé maximum
            int max_3 = int.MinValue;
            int max_4 = int.MinValue;
            int min = myArray[0]; // Minimum
            int countMax = 1;
            int countMin = 1;
            positionsMax[0] = 0;
            positionsMin[0] = 0;
            

            for(int i = 1; i < n; i++){
               // Kontrola nového maxima
                if(myArray[i] > max){
                    max_4 = max_3;
                    max_3 = max_2;
                    max_2 = max; // Předchozí maximum je nyní druhé největší
                    max = myArray[i]; // Nové maximum
                    positionsMax[0] = i;
                    countMax = 1;
                }
                else if(myArray[i] == max){
                    positionsMax[countMax] = i;
                    countMax++;
                }
                else if(myArray[i] > max_2 && myArray[i] < max){
                    max_2 = myArray[i]; // Druhé největší číslo
                }
                else if(myArray[i] > max_3 && myArray[i] < max_2){
                    max_3 = myArray[i]; // 3. největší číslo
                }
                else if (myArray[i] > max_4 && myArray[i] < max_3){
                    max_4 = myArray[i]; // 4. Největší číslo
                }
                if(myArray[i] < min){
                    min = myArray[i];
                    positionsMin[0] = i;
                    countMin = 1;
                }
                else if(myArray[i] == min){
                    positionsMin[countMin] = i;
                    countMin++;
                }
            }
            // Shaker sort
            int start = 0; // Počáteční index (první číslo)
            int end = myArray.Length - 1; // Konečný index (poslední číslo)
            bool swapped = true; // Indikátor, zda došlo k výměně


            while(swapped){
                swapped = false;

                // Směrem doprava
                for(int i = start; i < end; i++){
                    if(myArray[i] < myArray[i + 1]){
                        // Prohození prvků
                        int temp = myArray[i];
                        myArray[i] = myArray[i + 1];
                        myArray[i + 1] = temp;
                        swapped = true; // Záznam, že došlo k výměně
                    }
                }
                end--; // Posunutí horní hranice

                // Směrem doleva
                for(int i = end; i > start; i--){
                    if (myArray[i] > myArray[i-1]){
                        // Prohození prvků
                        int temp = myArray[i];
                        myArray[i] = myArray[i-1];
                        myArray[i-1] = temp;
                        swapped = true; // Záznam, že došlo k výměně
                    }
                }
                start++; // Posunutí dolní hranice
            }
            Console.WriteLine("\n\nSeřazené pole: ");
            for(int i = 0; i < n; i++){
                Console.Write("{0},", myArray[i]);
            }

            int median;
            if(n % 2 != 0){
                // Lichý počet prvků
                median = myArray[n / 2];
            }
            else{
                // Sudý počet prvků
                median = (myArray[n / 2 - 1] + myArray[n / 2]) / 2;
            }
            int temp2 = max_4;
            int[] mojeRada = new int[32];
            int zbytek;
            int k = 0;
            while(temp2 > 0){
                
                zbytek = temp2 % 2;
                temp2 = (temp2 - zbytek) / 2;
                mojeRada[k] = zbytek;
                k++;
            }

            Console.WriteLine("\n\nMaximum: {0}", max);
            Console.WriteLine("Minimum: {0}\n", min);
            for(int i = 0; i < countMax; i++){
                    Console.WriteLine("Maxima jsou na pozicích: {0}", positionsMax[i]);
            }
                  
            for(int i = 0; i < countMin; i++){
                    Console.WriteLine("Minima jsou na pozicích: {0}", positionsMin[i]); 
            }
            Console.WriteLine("\nDruhé největší číslo: {0}", max_2);
            Console.WriteLine("Třetí největší číslo: {0}", max_3);
            Console.WriteLine("Čtvrté největší číslo: {0}", max_4);

            Console.WriteLine("\nMedián: {0}", median);
            // Převod do dvojkové soustavy
            for(int j = k; j > 0; j--){
                Console.Write("{0}", mojeRada[j-1]);
            }
            Console.WriteLine("\n\n");
            
            // // Pro sudý median, lichý max_3 
            // int temp_median = 6;
            // int temp_max_3 = 7;
            // // Horní část
            // for(int i = 0; i < (temp_median/2)-1; i++){
            //     for(int m = 0; m < temp_median/3;m++){
            //         Console.Write("  ");
            //     }
            //     for(int j = 0; j <= temp_median/3; j++){
            //         Console.Write(" *");
            //         }
            //     Console.WriteLine();
            // }

            // //Prostřední část
            // for(int i = temp_median/3; i < temp_median-(temp_median/3); i++){
            //     for(int j = 0; j < temp_max_3;j++){
            //         Console.Write(" *");  
            //     }
            //     Console.WriteLine();
            // }
            // // Dolní část
            // for(int i = temp_median-2; i < temp_median; i++){
            //     for(int m = 0; m < temp_median/3;m++){
            //         Console.Write("  ");
            //     }
            //     for(int j = 0; j <= temp_median/3; j++){
            //         Console.Write(" *");
            //     }
            //     Console.WriteLine();
            // }
            
            int temp_median_2 = 6;
            int temp_max_3_2 = 7;
            int prostredni_cast;
            int pocet_hvezdicek;
            if(temp_median_2 % 2 == 1){
                prostredni_cast = temp_max_3_2/2;
                pocet_hvezdicek = temp_median_2/3+1;
            }
            else{
                prostredni_cast = temp_max_3_2/3;
                pocet_hvezdicek = temp_median_2/3;
            }
            
            int horni_dolni_cast = 2;
            
            // Horní část
            for(int i = 0; i < horni_dolni_cast; i++){
                for(int m = 0; m < pocet_hvezdicek;m++){
                    Console.Write("  ");
                }
                for(int j = 0; j < pocet_hvezdicek; j++){
                    Console.Write(" *");
                    }
                Console.WriteLine();
            }

            //Prostřední část
            for(int i = 0; i < prostredni_cast; i++){
                for(int j = 0; j < temp_max_3_2;j++){
                    Console.Write(" *");  
                }
                Console.WriteLine();
            }
            // Dolní část
            for(int i = 0; i < horni_dolni_cast; i++){
                for(int m = 0; m < pocet_hvezdicek;m++){
                    Console.Write("  ");
                }
                for(int j = 0; j < pocet_hvezdicek; j++){
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            // Opakování programu
            Console.WriteLine("\n\nChcete program opakovat y/n?: ");
            again = Console.ReadLine();


        }