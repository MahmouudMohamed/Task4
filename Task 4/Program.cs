namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Accounts
            var accounts = new List<Account>();
            accounts.Add(new Account());
            accounts.Add(new Account("Larry"));
            accounts.Add(new Account("Moe", 2000));
            accounts.Add(new Account("Curly", 5000));

            AccountUtil.Display(accounts);
            AccountUtil.Deposit(accounts, 1000);
            AccountUtil.Withdraw(accounts, 2000);

            // Savings
            var saveAccounts = new List<Account>();
            saveAccounts.Add(new SavingsAccount());
            saveAccounts.Add(new SavingsAccount("Superman"));
            saveAccounts.Add(new SavingsAccount("Batman", 2000));
            saveAccounts.Add(new SavingsAccount("Wonderwoman", 5000, 5.0));

            AccountUtil.Display(saveAccounts);
            AccountUtil.Deposit(saveAccounts, 1000);
            AccountUtil.Withdraw(saveAccounts, 2000);

            // Checking
            var checkAccounts = new List<Account>();
            checkAccounts.Add(new CheckingAccount());
            checkAccounts.Add(new CheckingAccount("Larry2"));
            checkAccounts.Add(new CheckingAccount("Moe2", 2000));
            checkAccounts.Add(new CheckingAccount("Curly2", 5000));

            AccountUtil.Display(checkAccounts);
            AccountUtil.Deposit(checkAccounts, 1000);
            AccountUtil.Withdraw(checkAccounts, 2000);
            AccountUtil.Withdraw(checkAccounts, 2000);

            // Trust
            var trustAccounts = new List<Account>();
            trustAccounts.Add(new TrustAccount());
            trustAccounts.Add(new TrustAccount("Superman2"));
            trustAccounts.Add(new TrustAccount("Batman2", 2000));
            trustAccounts.Add(new TrustAccount("Wonderwoman2", 5000, 5.0));

            AccountUtil.Display(trustAccounts);
            AccountUtil.Deposit(trustAccounts, 1000);
            AccountUtil.Deposit(trustAccounts, 6000);
            AccountUtil.Withdraw(trustAccounts, 2000);
            AccountUtil.Withdraw(trustAccounts, 3000);
            AccountUtil.Withdraw(trustAccounts, 3000);
            AccountUtil.Withdraw(trustAccounts, 500);
            AccountUtil.Withdraw(trustAccounts, 500);
            // for testing limit of withdraw == Account of Wonder Woman
            AccountUtil.Withdraw(trustAccounts, 500);

            Console.WriteLine();
        }
    }
}
