namespace ARCerp.Data.Account
{
    public class AccountService
    {
        public Task<List<Account>> GetAccountsAsync()
        {
            List<Account> accounts = new List<Account>();
            
            accounts.Add(new Account(1, "10000.100.10","Asset" ,"Cash", "Cash", "Assets", "-", "-"));
            accounts.Add(new Account(2, "10500.100.10","Asset" ,"-", "Undeposited Funds", "Current Assets", "-", "-"));
            accounts.Add(new Account(3, "12000.100.10","Asset" ,"Inventory", "Inventory", "Current Assets", "-", "-"));
            accounts.Add(new Account(4, "12100.100.10","Asset" ,"Work In Process", "Work In Process Inventory", "Current Assets", "-", "-"));
            accounts.Add(new Account(5, "12900.100.10","Asset" ,"-", "Inventory Shipped Not Invoiced", "Assets", "-", "-"));
            accounts.Add(new Account(6, "13000.100.10","Asset" ,"Accounts Receivable", "Accounts Receivables", "Accounts Receivable", "-", "-"));
            accounts.Add(new Account(7, "13900.100.10","Liability" ,"-", "Goods Receipt Clearing", "-", "-", "-"));
            accounts.Add(new Account(8, "10000.100.10", "Liability", "Accounts Payable", "Accounts Payable", "Accounts Payable", "-", "-"));

            return Task.FromResult(accounts);
        }
    }
}
