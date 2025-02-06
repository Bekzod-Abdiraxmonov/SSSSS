Console.Write("Sonni kiriting: ");
        int x = int.Parse(Console.ReadLine()); // Butun sonni kiritish
        Console.Write("So'zni kiriting: ");
        string str = Console.ReadLine(); // Matnni kiritish

        // Tekshiruv: x str ning uzunligidan katta yoki yo'q
        string result = 
                        x > str.Length 
                            ? str.ToUpper() 
                            : str.ToLower();

        Console.WriteLine("Natija: " + result);