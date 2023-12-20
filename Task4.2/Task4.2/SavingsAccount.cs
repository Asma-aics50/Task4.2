using System;
namespace Task4._2
{
	public class SavingsAccount:Account
	{
        public double InterestedRate;

        public SavingsAccount(string name = "Unnamed SavingAccount", double balance = 0.0 ,double intrestedRate = 0.0 ):base(name,balance)
		{
            this.InterestedRate = intrestedRate;
        }
        public bool Deposit(double amount) {

           
            amount = amount +(amount *InterestedRate / 100);
         
            return base.Deposit(amount);
        }


        public override string ToString()
        {
            return $"{base.ToString()}";
        }
    }
}

