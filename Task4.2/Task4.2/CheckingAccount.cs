using System;
namespace Task4._2
{
    public class CheckingAccount : Account
    {
        public const double fee = 1.50;

        public CheckingAccount(string name = "Unnamed CheckingAccount", double num = 0.0):base(name,num)
        {
            

        }
        public bool Withdraw(double amount)
        {
            amount = amount + fee;

            return base.Withdraw(amount);
            
        }
     
        public override string ToString()
        {
            
            return $"[Checking{base.ToString()} ]";
            
        }
    }
}

