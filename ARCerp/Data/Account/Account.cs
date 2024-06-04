namespace ARCerp.Data.Account
{
    public class Account
    {
        public int Id { get; set; }
        public string? AccountNumber { get; set; }
        public string? AccountType { get; set; }
        public string? ControlType { get; set; }
        public string? Category { get; set; }
        public string? SubCategory { get; set; }
        public string? Description { get; set; }
        public string? GroupKey { get; set; }
        public Account(int id, string? accountNumber, string? accountType, string? controlType, string? category, string? subCategory, string? description, string? groupKey)
        {
            Id = id;
            AccountNumber = accountNumber;
            AccountType = accountType;
            ControlType = controlType;
            Category = category;
            SubCategory = subCategory;
            Description = description;
            GroupKey = groupKey;
        }
     
    }
}
