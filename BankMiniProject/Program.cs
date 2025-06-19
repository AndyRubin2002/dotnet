using System.Reflection;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Bank b = new SavingAccount(255,"Rohan","SBIN0000517","male",25000);
        b.CheckBalance();
        b.DepositAmount(300);
        b.WithDraw(2000);
        b.toString();

        
    }
    public abstract class Bank
    {
         private int AccountNo;
         private string Name;
        private string Ifsc;
        private string gender;
        private double balance;

        public Bank(int AccountNo, string Name, string Ifsc, string gender, double bal)
        {
            this.AccountNo = AccountNo;
            this.Name = Name;
            this.Ifsc = Ifsc;
            this.gender = gender;
            balance = bal;

        }
        public virtual void DepositAmount(double amt)
        {
            balance = balance + amt;
            Console.WriteLine($"Balance is Deposit {balance}");
        }

        public virtual void WithDraw(double amt)
        {
            balance = balance - amt;
            Console.WriteLine($"Balance is Withdraw {balance}");
        }

        public virtual  void CheckBalance()
        {
            Console.WriteLine($"Balance is {balance}");
        }

        public void toString()
        {
            Console.WriteLine($"Name : {Name}, Account No : {AccountNo}, IFSC Code : {Ifsc}, Gender : {gender}, Balance : {balance} ");
        }
    }

    public class SavingAccount : Bank
    {
        public SavingAccount(int AccountNo, string Name, string Ifsc, string Gender,double Balance)
         : base(AccountNo, Name, Ifsc, Gender,Balance) 
        {
            Console.WriteLine("Saving Account Created!");
        }

        public void getIntersetRate()
        {
            Console.WriteLine($"Interset Rate is 2.60% to 8.00% per annum");
        }
    }

    public class CurrentAccount : Bank
    {

        public CurrentAccount(int AccountNo, string Name, string Ifsc, string Gender, double Balance)
         : base(AccountNo, Name, Ifsc, Gender, Balance) 
        {
            Console.WriteLine("Current Account Created!");
        }
        public void getLoan()
        {
            Console.WriteLine($"Interest Rate is 2.60% to 8.00% per annum");
        }

    }

}