using System;

class Program
{
    const int POCET_DES_MIST = 2;
    static Random random = new Random();

    static void Main()
    {
        char pokracovani = 'y'; // Cyklus pouzije y, aby zacal
        int volba;

        while (pokracovani == 'y' || pokracovani == 'Y')
        {
            Console.WriteLine("\nVitejte v kalkulacce! \n");
            Console.WriteLine("\n\nVyberte si z nasledujici nabidky obrazec pro ktery chcete provest vypocet obsahu/obvodu: \n");
            Console.WriteLine("\n\nPro ctverec - 1 \n");
            Console.WriteLine("Pro obdelnik - 2 \n");
            Console.WriteLine("Pro trojuhelnik - 3 \n\n");

            // Vstup a kontrola volby
            volba = nacti_cele_cislo();

            switch (volba)
            {
                // Ctverec
                case 1:
                    {
                        int volbactverec;
                        Console.WriteLine("\nKalkulacka - 1 \n");
                        Console.WriteLine("Procvicovani - 2 \n\n");

                        volbactverec = nacti_cele_cislo();

                        switch (volbactverec)
                        {
                            case 1:
                                {
                                    ctverec_kalkulacka();
                                    break;
                                }

                            case 2:
                                {
                                    int volba_procvicovani_ctverec;
                                    Console.WriteLine("\nProcvicovani vypoctu ctverce\n");
                                    Console.WriteLine("1 - obsah\n");
                                    Console.WriteLine("2 - obvody\n\n");

                                    volba_procvicovani_ctverec = nacti_cele_cislo();

                                    switch (volba_procvicovani_ctverec)
                                    {
                                        case 1:
                                            {
                                                int a_nahodne = MAX_DELKA(50);
                                                int spravny_obsah = a_nahodne * a_nahodne;
                                                Console.WriteLine("Jaky je obsah ctverce pri hodnote a = {0} ?\n", a_nahodne);
                                                Console.Write("Tva odpoved: ");
                                                int obsah_odpoved_ctverec;

                                                // Kontrola odpovedi
                                                obsah_odpoved_ctverec = nacti_cele_cislo();

                                                if (obsah_odpoved_ctverec == spravny_obsah)
                                                {
                                                    Console.WriteLine("\nSpravne! Obsah ctverce je {0} \n", spravny_obsah);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Spatne! Obsah ctverce je {0} \n", spravny_obsah);
                                                }
                                                break;
                                            }

                                        case 2:
                                            {
                                                int a_nahodne = MAX_DELKA(50);
                                                int spravny_obvod = 4 * a_nahodne;
                                                Console.WriteLine("Jaky je obvod ctverce pri hodnote a = {0} ?\n", a_nahodne);
                                                Console.Write("Tva odpoved: ");
                                                int obvod_odpoved_ctverec;

                                                obvod_odpoved_ctverec = nacti_cele_cislo();

                                                if (obvod_odpoved_ctverec == spravny_obvod)
                                                {
                                                    Console.WriteLine("\nSpravne! Obvod ctverce je {0} \n", spravny_obvod);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Spatne! Obvod ctverce je {0} \n", spravny_obvod);
                                                }
                                                break;
                                            }
                                        default:
                                            {
                                                Console.WriteLine("Neplatna volba zadejte cislo.\n");
                                                break;
                                            }
                                    }
                                    break; // Added break here
                                }
                            default:
                                {
                                    Console.WriteLine("Neplatna volba, zadejte cislo 1 nebo 2. \n");
                                    break;
                                }
                        }
                        break;
                    }

                // Obdelnik
                case 2:
                    {
                        int volba_obdelnik;
                        Console.WriteLine("\nObdelnik\n");
                        Console.WriteLine("1 - Kalkulacka\n");
                        Console.WriteLine("2 - Procvicovani\n");

                        volba_obdelnik = nacti_cele_cislo();

                        switch (volba_obdelnik)
                        {
                            case 1:
                                {
                                    obdelnik_kalkulacka();
                                    break;
                                }
                            case 2:
                                {
                                    int volba_procvicovani_obdelnik;
                                    Console.WriteLine("\nProcvicovani vypoctu obdelniku\n");
                                    Console.WriteLine("1 - obsah\n");
                                    Console.WriteLine("2 - obvod\n\n");

                                    volba_procvicovani_obdelnik = nacti_cele_cislo();

                                    switch (volba_procvicovani_obdelnik)
                                    {
                                        case 1:
                                            {
                                                int a_nahodne = MAX_DELKA(50);
                                                int b_nahodne = MAX_DELKA(50);
                                                int spravny_obsah = a_nahodne * b_nahodne;
                                                Console.WriteLine("Jaky je obsah obdelniku pri hodnote a = {0}, b = {1} ?\n", a_nahodne, b_nahodne);
                                                Console.Write("Tva odpoved: ");
                                                int obsah_odpoved_obdelnik;

                                                // Kontrola odpovedi
                                                obsah_odpoved_obdelnik = nacti_cele_cislo();

                                                if (obsah_odpoved_obdelnik == spravny_obsah)
                                                {
                                                    Console.WriteLine("\nSpravne! Obsah obdelniku je {0} \n", spravny_obsah);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Spatne! Obsah obdelniku je {0} \n", spravny_obsah);
                                                }
                                                break;
                                            }
                                        case 2:
                                            {
                                                int a_nahodne = MAX_DELKA(50);
                                                int b_nahodne = MAX_DELKA(50);
                                                int spravny_obvod = 2 * (a_nahodne + b_nahodne);
                                                Console.WriteLine("Jaky je obvod obdelniku pri hodnote a = {0}, b = {1} ?\n", a_nahodne, b_nahodne);
                                                Console.Write("Tva odpoved: ");
                                                int obvod_odpoved_obdelnik;

                                                // Kontrola odpovedi
                                                obvod_odpoved_obdelnik = nacti_cele_cislo();

                                                if (obvod_odpoved_obdelnik == spravny_obvod)
                                                {
                                                    Console.WriteLine("\nSpravne! Obsah ctverce je {0} \n", spravny_obvod);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Spatne! Obsah ctverce je {0} \n", spravny_obvod);
                                                }
                                                break;
                                            }
                                        default:
                                            {
                                                Console.WriteLine("Zadejte hodnotu 1 nebo 2.\n");
                                                break;
                                            }
                                    }

                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Zadejte hodnotu 1 nebo 2.\n");
                                    break;
                                }
                        }
                        break;
                    }

                // Trojuhelnik
                case 3:
                    {
                        int volba_trojuhelnik;

                        Console.WriteLine("\nChcete kalkulacku ci procvicovani?\n");
                        Console.WriteLine("1 - kalkulacku\n");
                        Console.WriteLine("2 - procvicovani\n");

                        volba_trojuhelnik = nacti_cele_cislo();

                        switch (volba_trojuhelnik)
                        {
                            // Kalkulacka - trojuhelnik
                            case 1:
                                {
                                    int volba2;
                                    Console.WriteLine("\nVybrali jste si kalkulacku trojuhelniku!\n");
                                    Console.WriteLine("Chcete vypocitat obvod, ci obsah?\n");
                                    Console.WriteLine("Pro obvod - 1\n");
                                    Console.WriteLine("Pro obsah - 2\n");

                                    volba2 = nacti_cele_cislo();
                                    switch (volba2)
                                    {
                                        case 1:
                                            {
                                                obvod_trojuhelnik_kalkulacka();
                                                break;
                                            }
                                        case 2:
                                            {
                                                obsah_trojuhelnik_kalkulacka();
                                                break;
                                            }

                                        default:
                                            {
                                                Console.WriteLine("Neplatna volba, zadejte cislo 1 nebo 2. \n");
                                                break;
                                            }
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    int volba_trojuhelnik_cvic;
                                    Console.WriteLine("Vybrali jste si procvicovani!\n");
                                    Console.WriteLine("Pro obsah - 1\n");
                                    Console.WriteLine("Pro obvod - 2\n\n");

                                    volba_trojuhelnik_cvic = nacti_cele_cislo();

                                    switch (volba_trojuhelnik_cvic)
                                    {
                                        case 1:
                                            {
                                                int a_nahodne = MAX_DELKA(50);
                                                int v_nahodne = MAX_DELKA(50);
                                                int spravny_obsah = (a_nahodne * v_nahodne) / 2;
                                                Console.WriteLine("Jaky je obsah trojuhelniku pri hodnotach a = {0}, v = {1} ?\n", a_nahodne, v_nahodne);
                                                Console.Write("Tva odpoved: ");
                                                int obsah_odpoved_trojuhelnik;

                                                // Kontrola odpovedi
                                                obsah_odpoved_trojuhelnik = nacti_cele_cislo();

                                                if (obsah_odpoved_trojuhelnik == spravny_obsah)
                                                {
                                                    Console.WriteLine("\nSpravne! Obsah trojuhelniku je {0} \n", spravny_obsah);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Spatne! Obsah trojuhelniku je {0} \n", spravny_obsah);
                                                }
                                                break;
                                            }
                                        case 2:
                                            {
                                                int a_nahodne = MAX_DELKA(50);
                                                int b_nahodne = MAX_DELKA(50);
                                                int c_nahodne = MAX_DELKA(50);
                                                int spravny_obvod = a_nahodne + b_nahodne + c_nahodne;
                                                Console.WriteLine("Jaky je obvod trojuhelniku pri hodnotach a = {0}, b = {1}, c = {2} ?\n", a_nahodne, b_nahodne, c_nahodne);
                                                Console.Write("Tva odpoved: ");
                                                int obvod_odpoved_trojuhelnik;

                                                // Kontrola odpovedi
                                                obvod_odpoved_trojuhelnik = nacti_cele_cislo();

                                                if (obvod_odpoved_trojuhelnik == spravny_obvod)
                                                {
                                                    Console.WriteLine("\nSpravne! Obsah trojuhelniku je {0} \n", spravny_obvod);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Spatne! Obsah trojuhelniku je {0} \n", spravny_obvod);
                                                }
                                                break;
                                            }
                                        default:
                                            {
                                                Console.WriteLine("Neplatna volba, zadejte cislo 1 nebo 2.\n");
                                                break;
                                            }

                                    }
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Neplatna volba, zadejte cislo 1 nebo 2.\n");
                                    break;
                                }

                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Zadejte hodnotu dle nabidky 1, 2 nebo 3.\n");
                        break;
                    }
            }
            // Opakovani programu
            pokracovani = nacteni_znaku();
        }
    }

    static void ctverec_kalkulacka()
    {
        float obvod_ctverce, obsah_ctverce, a;
        Console.WriteLine("Vybrali jste si ctverec! \n");
        Console.Write("Zadejte delku strany a: ");

        a = nacti_cislo();

        obsah_ctverce = a * a;
        obvod_ctverce = 4 * a;

        Console.WriteLine("\nObsah ctverce = {0:F" + POCET_DES_MIST + "} \n", obsah_ctverce);
        Console.WriteLine("Obvod ctverce = {0:F" + POCET_DES_MIST + "} \n", obvod_ctverce);
    }

    static void obdelnik_kalkulacka()
    {
        float obvod_obdelniku, obsah_obdelniku, a, b;
        Console.WriteLine("\nVybrali jste si obdelnik!\n");
        Console.Write("Zadejte delku strany a: ");
        a = nacti_cislo();

        Console.Write("Zadejte delku strany b: ");
        b = nacti_cislo();

        obsah_obdelniku = a * b;
        obvod_obdelniku = 2 * (a + b);

        Console.WriteLine("\nObsah obdelniku = {0:F" + POCET_DES_MIST + "} \n", obsah_obdelniku);
        Console.WriteLine("Obvod obdelniku = {0:F" + POCET_DES_MIST + "} \n", obvod_obdelniku);
    }

    static void obvod_trojuhelnik_kalkulacka()
    {
        float obvod_trojuhelniku, a, b, c;
        Console.Write("Zadejte delku strany a: ");
        a = nacti_cislo();

        Console.Write("Zadejte delku strany b: ");
        b = nacti_cislo();

        Console.Write("Zadejte delku strany c: ");
        c = nacti_cislo();

        obvod_trojuhelniku = a + b + c;
        Console.WriteLine("\nObvod trojuhelniku = {0:F" + POCET_DES_MIST + "} \n", obvod_trojuhelniku);
    }

    static void obsah_trojuhelnik_kalkulacka()
    {
        float a, v, obsah_trojuhelniku;
        Console.Write("Zadejte delku strany a: ");
        a = nacti_cislo();

        Console.Write("Zadejte vysku trojuhelniku: ");
        v = nacti_cislo();

        obsah_trojuhelniku = (a * v) / 2;

        Console.WriteLine("\nObsah trojuhelniku: {0:F" + POCET_DES_MIST + "}", obsah_trojuhelniku);
    }

    static int nacti_cele_cislo()
    {
        int cele_cislo;
        while (!int.TryParse(Console.ReadLine(), out cele_cislo))
        {
            Console.WriteLine("Neplatna volba. Zadejte prosim cele cislo, dle nabidky.");
        }
        return cele_cislo;
    }

    static float nacti_cislo()
    {
        float cislo;
        while (!float.TryParse(Console.ReadLine(), out cislo))
        {
            Console.WriteLine("Neplatna volba. Zadejte prosim realne cislo. \n");
        }
        return cislo;
    }

    static char nacteni_znaku()
    {
        char pokracovani;
        Console.Write("\nChcete provest dalsi vypocet? y/n: \n");
        pokracovani = Console.ReadKey().KeyChar;
        Console.WriteLine(); // For better formatting
        return pokracovani;
    }

    static int MAX_DELKA(int max)
    {
        return random.Next(1, max + 1);
    }
}

