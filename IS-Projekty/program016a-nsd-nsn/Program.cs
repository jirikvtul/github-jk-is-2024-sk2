        // chci, aby se program opakoval po stisku klávesy a 
        string again = "a";
        while(again == "a") {
            Console.Clear();
            logo();
            
            
            ulong a = ziskatCislo("Zadejte (celé číslo - kladné) a: ");
            ulong b = ziskatCislo("Zadejte (celé číslo - kladné) b: ");
            ulong nsd = vypocitatNsd(a, b);
            ulong nsn = vypocitatNsn(a, b, nsd);
            zobrazitvysledky(a, b, nsn, nsd);
            

            // Opakování programu
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();


        } 
static void logo(){
            Console.WriteLine("++++++++++++++++++++++++++++++++");
            Console.WriteLine("++++++++++ NSD A NSN ++++++++++");
            Console.WriteLine("++++++++++++++++++++++++++++++++");
            Console.WriteLine("+++++++++ Jiří Kvajsar +++++++++");
            Console.WriteLine("++++++++++++++++++++++++++++++++\n\n");
            Console.WriteLine();
}

static ulong ziskatCislo(string zprava){
    // Vstup od uživatele - lepší varianta
    Console.Write(zprava);
    ulong cislo;
    while(!ulong.TryParse(Console.ReadLine(), out cislo)) {
        Console.Write("Nezadali jste celé přirozené číslo. Zadejte znovu:  ");    
    }
    return cislo;
}
static ulong vypocitatNsd(ulong a, ulong b){
    while(a != b){
        if(a > b){
            a = a - b;
        }
        else{
            b = b - a;
        }
    }
    return a; 
}
static ulong vypocitatNsn(ulong a, ulong b, ulong nsd){
    return (a*b)/nsd;
}
static void zobrazitvysledky(ulong a, ulong b, ulong nsn, ulong nsd){
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("\n\nNSD čísel {0} a {1} je {2}", a, b, nsd);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"NSN čísel {a} a {b} je {nsn}");
}