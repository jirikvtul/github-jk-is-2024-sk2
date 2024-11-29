using System.Diagnostics;

string again = "a";
while(again == "a") {
//Console.Clear();
Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++");
Console.WriteLine("+++++++ Převod z 10 do 2 soustavy +++++++");
Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++");
Console.WriteLine("++++++++++++ Jiří Kvajsar +++++++++++++++");
Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++\n\n");
Console.WriteLine();

        // Vstup od uživatele - lepší varianta
        Console.Write("Zadejte číslo v desítkové soustavě pro převod (přirozené): ");
        uint cislo;
        while(!uint.TryParse(Console.ReadLine(), out cislo)) {
            Console.Write("Špatný vstup. Zadejte číslo v desítkové soustavě pro převod (přirozené):  ");    
        }

        uint[] myArray = new uint[32];
        uint zaloha = cislo;    
        uint zbytek;

        uint i=0;
        while(cislo > 0){
            zbytek = cislo % 2;
            cislo = (cislo - zbytek) /  2;
            myArray[i] = zbytek;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Celá část: {0}; zbytek = {1}", cislo, zbytek);

            i++;
        }

        Console.WriteLine("Poslední využitý index pole: {0}", i-1);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n\nVýsledek: ");

        for(uint j = i; j > 0; j--){
            Console.Write("{0}", myArray[j-1]);
        }


        Console.ForegroundColor = ConsoleColor.White;
        
        // Opakování programu
        Console.WriteLine("\nPro opakování programu stiskněte klávesu a");
        again = Console.ReadLine();


    }   