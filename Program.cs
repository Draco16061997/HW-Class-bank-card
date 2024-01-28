//Написать класс Банковская карта, которая хранит в себе номер 16 цифр CVV ФИО Баланс
//дать возможность искать поллзователяю карту в массиве карт и выводить всю прочую ифнормацию по карте



BankCard card = new BankCard("1234567891234567", "Jony Bravo", "345");
BankCard card2 = new BankCard("2323232323232323","Valera","444");

card.AddBalance(30);








List<BankCard> bankCards = new List<BankCard>();

bankCards.Add(card);
bankCards.Add(card2);


for (int i = 0; i < bankCards.Count; i++)
{
    bankCards[i].Print();
}



void Serch(string num)
{

}

class Bank
{


}



class BankCard
{
    public BankCard (string cardNumber, string name, string cvv)
    {
        CardNumber = cardNumber;
        Name = name;
        CVV = cvv;
        BALANCE = 0;
    
    }



    private string CardNumber;

    public string cardNumber
    {
        get { return CardNumber; }
        set { 
            if (value != null && value.Length == 16 && value.All(char.IsDigit)) 
            {
            CardNumber = value;
            }
            else
            {
                throw new ArgumentException("введите 16 цифр");
            }
        }
    }

    //public BankCard(string CardNumber)
    //{
    //    cardNumber = CardNumber;
    //}

    public string Name { set; get; }


    private string CVV;

    public string cvv { 
        set {
            if (value != null && value.Length == 3 && value.All(char.IsDigit))
            {
                CardNumber = value;
            }
            else
            {
                throw new ArgumentException("CVV состоит из 3х чисел");
            }

        } 
        
        get { return CVV; } }

    private float BALANCE;


    public void AddBalance(float value)
    {
        this.BALANCE += value;
        
    }
   
   

    public void Print()
    {
        Console.WriteLine($"NUMCARD: {CardNumber} " +
            $" NAME: {Name} " +
            $" CVV: {CVV} " +
            $" BALANCE: {BALANCE}");
    }
}


