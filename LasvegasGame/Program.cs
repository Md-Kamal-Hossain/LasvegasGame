do
{

//Declaring variable
int firstDice;
int secondDice;
int amountBet;

//Declaring constant
const int numberToRoll = 1;

//Instatiating Random
Random rand = new Random();

//Getting input from user
Console.WriteLine("Enter Your Firstname");
//assigning the value
string FirstName = Console.ReadLine();

Console.WriteLine("Enter Your Lastname");
string lastName = Console.ReadLine();

//concateneting to get full name
string name = string.Concat(FirstName, lastName);  

//getting input from user
Console.WriteLine("How much do you want to bet!");
amountBet = Convert.ToInt32(Console.ReadLine());

if (amountBet>=5)//Condition to roll two dice 
{
    
    for (int i = 0; i < numberToRoll; i++)
    {
         //Generating random number for first dice roll
         firstDice = rand.Next(1, 7);
        //Generating random number for first dice roll
         secondDice = rand.Next(1, 7);
         int sumdice = firstDice + secondDice;
        if (firstDice==secondDice)// if Pasch
        {
            Console.WriteLine("you win a free game!");
            Console.WriteLine("do you want to play your free game? Please type `yes` if you want");
            string yesNo = Console.ReadLine();
            string updatedYesNo = yesNo.ToLower();
            if (updatedYesNo=="yes"||updatedYesNo=="ja")//Still I put ja incase user type ja
            {
                int newFirst;
                int newSecond;
                int newSumdice2 = 0;
                //For free game
                Console.WriteLine("How much do you want to bet!");
                amountBet = Convert.ToInt32(Console.ReadLine());
                for (int j = 0; j < numberToRoll; j++)
                {
                    newFirst = rand.Next(1, 7);
                    newSecond = rand.Next(1, 7);
                    newSumdice2 = newFirst + newSecond;
                }
                int SumFinal = sumdice + newSumdice2;
                Console.WriteLine("Hi Mr." + name + "you have made a bet of " + amountBet + "and you have gain total " + SumFinal);

            }
            

        }
        else if (sumdice > 7)//Condition: if sum of the dice from both the rolls is more than 7 
        {
            int winningAmount = 0;
            winningAmount = 3 * amountBet;
            Console.WriteLine("Hi Mr."+ name + "You won."+ "you have made a bet of "+ amountBet + "and you have gain total "+ sumdice +"and you won"+ winningAmount + "$");
        }
        else
        {
                int looserDisposal = 0;
                looserDisposal = 0 * amountBet;
                Console.WriteLine("Hi Mr." + name +"Verloren!"+ "you have made a bet of " + amountBet + "and you have gain total " + sumdice+ "and you won" + looserDisposal+"$");
        }

    }

}
}
while (Console.ReadKey().Key != ConsoleKey.X);


