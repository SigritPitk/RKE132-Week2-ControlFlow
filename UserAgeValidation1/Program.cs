// See https://aka.ms/new-console-template for more information
//rakendus küsib kasutajal sisestada tema vanuse
//kui kasutaja vanus on väiksem kui 13 siis konsoolis kuvatakse:
//"You are too young to use Instagram!"
//muul juhul
//konsoolis kuvatakse "Welcome to Instagram!"

Console.WriteLine("Enter your age");
//ei saa olla string, sest sa ei saa v]rrelda teksti numbriga!
int userAge = Int32.Parse(Console.ReadLine()); //"13" - salvestatakse heapi (hunnik). 13 - salvestatakse stacki (kiirem ja votab v'hem m'lu)

if(userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram!");
}

else // if (userAge < 13)
{
    Console.WriteLine("You are too young to use Instagram!");
}
