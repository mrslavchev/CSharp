using System;
using System.Text;

/// <summary>
/// A bank account has a holder name (first name, middle name and last name), 
/// available amount of money (balance), bank name, IBAN, BIC code and 
/// 3 credit card numbers associated with the account. Declare the variables need	
/// ed to keep the information for a single bank account using the appropriate data types and descriptive names.
/// </summary>
class BankAccount
{
    public class Account 
    {
        //fields 
        private string firstName;
        private string middleName;
        private string lastName;
        private int balance;
        private string bankName;
        private string iban;
        private string bicCode;
        private string cardNo1;
        private string cardNo2;
        private string cardNo3;

        //Constructor
        public Account(string firstName, string middleName, string lastName, int balance, string bankName, string iban,
            string bicCode, string cardNo1, string cardNo2, string cardNo3) 
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.balance = balance;
            this.bankName = bankName;
            this.iban = iban;
            this.bicCode = bicCode;
            this.cardNo1 = cardNo1;
            this.cardNo2 = cardNo2;
            this.cardNo3 = cardNo3;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("Holder name: {0}\n", this.firstName + " " + this.middleName + " " + this.lastName);
            output.AppendFormat("Money in account: {0}$\n", this.balance.ToString());
            output.AppendFormat("Bank: {0}\n", this.bankName);
            output.AppendFormat("IBAN: {0}\n", this.iban);
            output.AppendFormat("Card# 1: {0}\n", this.cardNo1);
            output.AppendFormat("Card# 2: {0}\n", this.cardNo2);
            output.AppendFormat("Card# 3: {0}\n", this.cardNo3);
            return output.ToString();
        }
    }

    
    static void Main(string[] args)
    {
        Account test = new Account("Mr.", "Buggs", "Bunny", 10000000, "Bank of Amerika", "IUYUY87765568", "US8765", "36137236163",
            "981238173917398713", "99301938019830183");
        Console.WriteLine(test);
    }
}

