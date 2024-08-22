// ourAnimals ARRAY STORE THE FOLLOWING: 
using System.ComponentModel;

string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// VARIABLES THAT SUPPORT DATA ENTRY
int maxPets = 8;
string? readResult;
string menuSelection = "";

// ARRAY TO STORE RUNTIME DATA, NO PERSISTED DATA
string[,] ourAnimals = new string[maxPets, 6];

// TO DO: CONVERT IF - ELSEIF - ELSE CONSTRUCT TO SWITCH STATEMENT

// CREATE INITIAL ourAnimals ARRAY ENTRIES
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "SPECIES: " + animalSpecies;
    ourAnimals[i, 2] = "AGE: " + animalAge;
    ourAnimals[i, 3] = "NICKNAME: " + animalNickname;
    ourAnimals[i, 4] = "PHYSICAL DESCRIPTION: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "PERSONALITY: " + animalPersonalityDescription;
}

do
{
    // DISPLAY TOP - LEVEL MENU OPTIONS

    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. LIST ENTIRE CURRENT PET INFORMATION");
    Console.WriteLine(" 2. ADD AN ANIMAL FRIEND TO ourAnimals ARRAY");
    Console.WriteLine(" 3. ENSURE ANIMAL AGES AND PHYSICAL DESCRIPTIONS ARE COMPLETE");
    Console.WriteLine(" 4. ENSURE ANIMAL NICKNAMES AND PERSONALITY DESCRIPTIONS ARE COMPLETE");
    Console.WriteLine(" 5. EDIT AN ANIMAL'S AGE");
    Console.WriteLine(" 6. EDIT AN ANIMAL'S PERSONALITY DESCRIPTION");
    Console.WriteLine(" 7. DISPLAY ENTIRE CATS WITH A SPECIFIED CHARACTERISTIC");
    Console.WriteLine(" 8. DISPLAY ENTIRE DOGS WITH A SPECIFIED CHARACTERISTIC");
    Console.WriteLine();
    Console.WriteLine("enter selection number or type exit to exit the program.");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    Console.WriteLine($"menu option {menuSelection} is selected.");
    Console.WriteLine("press enter key to continue.");

    // PAUSE CODE EXECUTION
    readResult = Console.ReadLine();

    switch (menuSelection)
    {
        case "1":
            // LIST ENTIRE CURRENT PET INFORMATION
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("press the enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "2":
            // ADD AN ANIMAL FRIEND TO ourAnimals ARRAY
            string anotherPet = "y";
            int petCount = 0;
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                    petCount += 1;
            }
            if (petCount < maxPets)
                Console.WriteLine($"CURRENTLY INCLUDE {petCount} PETS THAT REQUIRE CARE. ABLE TO MANAGE {maxPets - petCount} MORE.");
            while (anotherPet == "y" && petCount < maxPets)
            {
                // BUILD STRING animalSpecies SINCE IT IS A REQUIRED FIELD
                bool validEntry = false;
                do
                {
                    Console.WriteLine("\n\renter 'dog' or 'cat' to initialize an entry.");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalSpecies = readResult.ToLower();
                        if (animalSpecies != "dog" && animalSpecies != "cat")
                            validEntry = false;
                        else
                            validEntry = true;
                    }
                } while (validEntry == false);
                // BUILD ANIMAL ID NUMBER E.G., C1 CAT 1 D2 DOG 2
                animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();
                // BUILD ANIMAL AGE
                do
                {
                    int petAge;
                    Console.WriteLine("ENTER PET'S AGE OR ENTER ? IF UNKNOWN.");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalAge = readResult;
                        if (animalAge != "?")
                            validEntry = int.TryParse(animalAge, out petAge);
                        else
                            validEntry = true;
                    }
                } while (validEntry == false);
                // GET A DESCRIPTION OF PET'S PHYSICAL APPEARENCE
                do 
                {
                    Console.WriteLine("ENTER A PHYSICAL DESCRIPTION OF A PET (SIZE, COLOUR, GENDER, WEIGHT).");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPhysicalDescription = readResult.ToLower();
                        if (animalPhysicalDescription == "")
                            animalPhysicalDescription = "tbd";
                    }
                }
                while (animalPhysicalDescription == "");
                // GET A DESCRIPTION OF PET'S PERSONALITY
                do
                {
                    Console.WriteLine("ENTER A DESCRIPTION OF PET'S PERSONALITY (TRICKS, ENERGY LEVEL).");
                    readResult= Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPersonalityDescription = readResult.ToLower();
                        if (animalPersonalityDescription == "")
                            animalPersonalityDescription = "tbd";
                    }
                } while (animalPersonalityDescription == "");
                // GET PET'S NICKNAME
                do
                {
                    Console.WriteLine("ENTER A NICKNAME FOR PET.");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalNickname = readResult.ToLower();
                        if (animalNickname == "")
                            animalNickname = "tbd";
                    }
                } while (animalNickname == "");
                // STORE PET INFORMATION INTO ourAnimals ARRAY (ZERO BASED)
                ourAnimals[petCount, 0] = "ID #: " + animalID;
                ourAnimals[petCount, 1] = "SPECIES: " + animalSpecies;
                ourAnimals[petCount, 2] = "AGE: " + animalAge;
                ourAnimals[petCount, 3] = "NICKNAME: " + animalNickname;
                ourAnimals[petCount, 4] = "PHYSICAL DESCRIPTION: " + animalPhysicalDescription;
                ourAnimals[petCount, 5] = "PERSONALITY: " + animalPersonalityDescription;
                petCount = petCount + 1;
                if (petCount < maxPets)
                {
                    Console.WriteLine("WANT TO ENTER INFORMATION FOR ANOTHER PET? (y/n)");
                    do
                    {
                        readResult = Console.ReadLine();
                        if (readResult != null)
                            anotherPet = readResult.ToLower();    
                    } while (anotherPet != "y" && anotherPet != "n");
                }
            }
            if (petCount >= maxPets)
            {
                Console.WriteLine("LIMIT IS REACHED ABOUT NUMBER OF PETS THAT ARE MANAGEABLE.");
                Console.WriteLine("press the enter key to continue.");
                readResult = Console.ReadLine();
            }
            break;

        case "3":
            // ENSURE ANIMAL AGES AND PHYSICAL DESCRIPTIONS ARE COMPLETE
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {   
                    // CHECK ANIMAL AGE
                    if (ourAnimals[i, 2] == "AGE: ?")
                    {
                        bool validEntry = false;
                        int petAge = 0;
                        do
                        {
                            Console.WriteLine($"ENTER AN AGE FOR {ourAnimals[i, 0]}.");
                            readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                animalAge = readResult;
                                validEntry = int.TryParse(readResult, out petAge);
                            }
                        } while (validEntry == false);
                        ourAnimals[i, 2] = "AGE: " + petAge;
                    }
                    // CHECK ANIMAL PHYSICAL DESCRIPTION
                    if (ourAnimals[i, 4] == "PHYSICAL DESCRIPTION: tbd" || ourAnimals[i, 4] == "PHYSICAL DESCRIPTION: ")
                    {
                        bool validEntry = false;
                        do
                        {
                            Console.WriteLine($"ENTER A PHYSICAL DESCRIPTION FOR {ourAnimals[i, 0]} (SIZE, COLOUR, GENDER, WEIGHT).");
                            readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                animalPhysicalDescription = readResult;
                                if (animalPhysicalDescription != "" )
                                    validEntry = true;
                                    ourAnimals[i, 4] = "PHYSICAL DESCRIPTION: " + animalPhysicalDescription;
                            }
                        } while (validEntry == false);
                    }
                }
            }
            Console.WriteLine("AGE AND PHYSICAL DESCRIPTION FIELDS ARE COMPLETE FOR ENTIRE FRIENDS.");
            Console.WriteLine("press the enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "4":
            // ENSURE ANIMAL NICKNAMES AND PERSONALITY DESCRIPTIONS ARE COMPLETE
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {   
                    // CHECK ANIMAL NICKNAME
                    if (ourAnimals[i, 3] == "NICKNAME: tbd" || ourAnimals[i, 3] == "NICKNAME: ")
                    {
                        bool validEntry = false;
                        do
                        {
                            Console.WriteLine($"ENTER A NICKNAME FOR {ourAnimals[i, 0]}.");
                            readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                animalNickname = readResult;
                                if (animalNickname != "" )
                                    validEntry = true;
                                    ourAnimals[i, 3] = "NICKNAME: " + animalNickname;
                            }
                        } while (validEntry == false);
                    }
                    // CHECK PERSONALITY DESCRIPTION
                    if (ourAnimals[i, 5] == "PERSONALITY: tbd" || ourAnimals[i, 5] == "PERSONALITY: ")
                    {
                        bool validEntry = false;
                        do
                        {
                            Console.WriteLine($"ENTER A PERSONALITY DESCRIPTION FOR {ourAnimals[i, 0]} (TRICKS, ENERGY LEVEL).");
                            readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                animalPersonalityDescription = readResult;
                                if (animalPersonalityDescription != "" )
                                    validEntry = true;
                                    ourAnimals[i, 5] = "PERSONALITY: " + animalPersonalityDescription;
                            }
                        } while (validEntry == false);
                    }                    
                }
            }
            Console.WriteLine("NICKNAME AND PERSONALITY DESCRIPTION FIELDS ARE COMPLETE FOR ENTIRE FRIENDS.");
            Console.WriteLine("press the enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "5":
            // EDIT AN ANIMAL'S AGE
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month for progress.");
            Console.WriteLine("press the enter key to continue.");
            readResult = Console.ReadLine();
            break;
        
        case "6":
            // EDIT AN ANIMAL'S PERSONALITY DESCRIPTION
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month for progress.");
            Console.WriteLine("press the enter key to continue.");
            readResult = Console.ReadLine();
            break;
        
        case "7":
            // DISPLAY ENTIRE CATS WITH A SPECIFIED CHARACTERISTIC
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month for progress.");
            Console.WriteLine("press the enter key to continue.");
            readResult = Console.ReadLine();
            break;
        
        case "8":
            // DISPLAY ENTIRE DOGS WITH A SPECIFIED CHARACTERISTIC
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month for progress.");
            Console.WriteLine("press the enter key to continue.");
            readResult = Console.ReadLine();
            break;
        
        default:
            break;
    }
} while (menuSelection != "exit");

Console.WriteLine(ourAnimals);