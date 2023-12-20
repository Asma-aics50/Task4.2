using System;
namespace Task4._2
{
    public class TrustAccount : Account
    {
        private string name;
        private double num;
        private double intersetRate;
        private const double fee = 1.50;
        private const int withdrawPerYear = 2;
        private const double precentage = 0.20;
        private int withdrawalsThisYear;

        public TrustAccount(string name = "Unnamed TrustAccount", double num = 0, double intersetRate = 0.0) : base(name, num)
        {

            this.intersetRate = intersetRate;
            this.withdrawalsThisYear = withdrawalsThisYear;
        }
        public bool Deposit(double amount)
        {

            amount = amount + (amount * intersetRate / 100);
            if (amount >=5000.00)
            {
                amount += 50.00; 
            }
            
            return base.Deposit(amount);
        }

        public bool Withdraw(double amount)
        {
            //amount = amount + fee;
            if (withdrawalsThisYear < withdrawPerYear)
            {
                    amount = balance * precentage;
                    withdrawalsThisYear++;
            }
        

        return base.Withdraw(amount);
        }
        public override string ToString()
        {
            return $"[Trust {base.ToString()}";
        }

    }
}

