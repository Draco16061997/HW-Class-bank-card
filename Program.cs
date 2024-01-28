//Написать класс Банковская карта, которая хранит в себе номер 16 цифр CVV ФИО Баланс
//дать возможность искать поллзователяю карту в массиве карт и выводить всю прочую ифнормацию по карте



BankCard card = new BankCard("1234567891234567", "Jony Bravo", "345");

card.Print();


class BankCard
{
    public BankCard (string CardNumber, string Name, string CVV)
    {
        CardNumber = CardNumber;
        Name = Name;
        CVV = CVV;
        balance = 0;
    
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


    public float balance { get { return BALANCE; }
        set {
            BALANCE += balance;
        
        } }
   
   

    public void Print()
    {
        Console.WriteLine(CardNumber);
    }
}


