// See https://aka.ms/new-console-template for more information
string[] ItemsForSale = ["Rope","Torches", "Climbing Equipment","Clean Water","Machete","Canoe","Food Supplies"];
int[] PricesList = [10,15,25,1,20,200,1];

Console.WriteLine("The following items are available:");
for (int i=0; i < ItemsForSale.Length;i++)
{
    Console.WriteLine(i+1 + " - " + ItemsForSale[i]);
}

Console.Write("What number do you want to see the price of? ");
string _input = Console.ReadLine();
EvaluateInput(_input);

void EvaluateInput(string input)
{
    int inputInt = Convert.ToInt32(input);
    int inputToIndex = inputInt - 1;
    Console.WriteLine(ItemsForSale[inputToIndex] + " cost " + PricesList[inputToIndex] + " gold ");
}
