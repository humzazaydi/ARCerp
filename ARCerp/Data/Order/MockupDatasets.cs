using Bogus.DataSets;
using Bogus;

namespace ARCerp.Data.Order
{
    #region DataModels
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public string Category { get; set; }
    }

    public class Company
    {
        public string Name { get; set; }
        public string CatchPhrase { get; set; }
        public string BsPhrase { get; set; }
        public string Suffix { get; set; }
    }

    public class Dates
    {
        public DateTime Past { get; set; }
        public DateTime Future { get; set; }
        public DateTime Recent { get; set; }
        public DateTime Soon { get; set; }

        public string RandomMonth { get; set; }
        public string RandomWeekday { get; set; }
    }

    public class PaymentAccount
    {
        public string AccountNumber { get; set; }
        public string RoutingNumber { get; set; }
        public string Iban { get; set; }
        public Decimal TotalAmount { get; set; }

        public string CreditCardNumber { get; set; }
        public string BitcoinAddress { get; set; }
    }

    public class WebServer
    {
        public string Domain { get; set; }
        public string IpAddress { get; set; }
        public string Ipv6Address { get; set; }

        public UserLogin AdminLogin { get; set; }
    }

    public class UserLogin
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class LoremExample
    {
        public string Word { get; set; }
        public string Words { get; set; }
        public string Sentence { get; set; }
        public string Sentences { get; set; }
        public string Paragraph { get; set; }
        public string Text { get; set; }
    }

    public class Employee
    {
        public string Prefix { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }

        public string JobTitle { get; set; }
        public string JobArea { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }
    }
    #endregion
    public class MockupDatasets
    {
        public Task<List<Address>> TestAddress()
        {
            var addressFaker = new Faker<Address>()
                .RuleFor(c => c.Street, f => f.Address.StreetAddress())
                .RuleFor(c => c.City, f => f.Address.City())
                .RuleFor(c => c.State, f => f.Address.State())
                .RuleFor(c => c.ZipCode, f => f.Address.ZipCode());

            return Task.FromResult(addressFaker.GenerateBetween(1, 10));
        }

        public Task<List<Product>> TestCommerce()
        {
            var productFaker = new Faker<Product>()
                .RuleFor(c => c.Name, f => f.Commerce.ProductName())
                .RuleFor(c => c.Price, f => Decimal.Parse(f.Commerce.Price(10, 100)))
                .RuleFor(c => c.Color, f => f.Commerce.Color())
                .RuleFor(c => c.Category, f => f.Commerce.Categories(1)[0]);

            return Task.FromResult(productFaker.GenerateBetween(1, 10));
        }

        public Task<List<Company>> TestCompany()
        {
            var companyFaker = new Faker<Company>()
                .RuleFor(c => c.Name, f => f.Company.CompanyName())
                .RuleFor(c => c.CatchPhrase, f => f.Company.CatchPhrase())
                .RuleFor(c => c.BsPhrase, f => f.Company.Bs())
                .RuleFor(c => c.Suffix, f => f.Company.CompanySuffix());

            return Task.FromResult(companyFaker.GenerateBetween(1, 10));
        }

        public Task<List<Dates>> TestDates()
        {
            var datesFaker = new Faker<Dates>()
                .RuleFor(c => c.Past, f => f.Date.Past())
                .RuleFor(c => c.Future, f => f.Date.Future())
                .RuleFor(c => c.Recent, f => f.Date.Recent())
                .RuleFor(c => c.Soon, f => f.Date.Soon())
                .RuleFor(c => c.RandomMonth, f => f.Date.Month())
                .RuleFor(c => c.RandomWeekday, f => f.Date.Weekday());

            return Task.FromResult(datesFaker.GenerateBetween(1, 10));
        }

        public Task<List<PaymentAccount>> TestFinance()
        {
            var paymentAccountFaker = new Faker<PaymentAccount>()
                .RuleFor(c => c.AccountNumber, f => f.Finance.Account())
                .RuleFor(c => c.RoutingNumber, f => f.Finance.RoutingNumber())
                .RuleFor(c => c.Iban, f => f.Finance.Iban())
                .RuleFor(c => c.TotalAmount, f => f.Finance.Amount(10000, 100000))
                .RuleFor(c => c.CreditCardNumber, f => f.Finance.CreditCardNumber())
                .RuleFor(c => c.BitcoinAddress, f => f.Finance.BitcoinAddress());

            return Task.FromResult(paymentAccountFaker.GenerateBetween(1, 10));
        }

        public Task<List<WebServer>> TestInternet()
        {
            var userLoginFaker = new Faker<UserLogin>()
                .RuleFor(c => c.Email, f => f.Internet.Email())
                .RuleFor(c => c.Username, f => f.Internet.UserName())
                .RuleFor(c => c.Password, f => f.Internet.Password());

            var webServerFaker = new Faker<WebServer>()
                .RuleFor(c => c.Domain, f => f.Internet.DomainName())
                .RuleFor(c => c.IpAddress, f => f.Internet.Ip())
                .RuleFor(c => c.Ipv6Address, f => f.Internet.Ipv6())
                .RuleFor(c => c.AdminLogin, f => userLoginFaker.Generate());

            return Task.FromResult(webServerFaker.GenerateBetween(1, 10));
        }

        public Task<List<LoremExample>> TestLorem()
        {
            var loremExampleFaker = new Faker<LoremExample>()
                .RuleFor(c => c.Word, f => f.Lorem.Word())
                .RuleFor(c => c.Words, f => String.Join(',', f.Lorem.Words(3)))
                .RuleFor(c => c.Sentence, f => f.Lorem.Sentence())
                .RuleFor(c => c.Sentences, f => String.Join(' ', f.Lorem.Sentences(3)))
                .RuleFor(c => c.Paragraph, f => f.Lorem.Paragraph())
                .RuleFor(c => c.Text, f => f.Lorem.Text())
                ;

            return Task.FromResult(loremExampleFaker.GenerateBetween(1, 10));
        }

        public Task<List<Employee>> TestName()
        {
            var employeeFaker = new Faker<Employee>()
                .RuleFor(c => c.Prefix, f => f.Name.Prefix())
                .RuleFor(c => c.FirstName, f => f.Name.FirstName())
                .RuleFor(c => c.LastName, f => f.Name.LastName())
                .RuleFor(c => c.Suffix, f => f.Name.Suffix())
                .RuleFor(c => c.JobTitle, f => f.Name.JobTitle())
                .RuleFor(c => c.JobArea, f => f.Name.JobArea())
                .RuleFor(c => c.Phone, f => f.Phone.PhoneNumber())
                .RuleFor(c => c.Email, f => f.Internet.Email());

            return Task.FromResult(employeeFaker.GenerateBetween(1, 10));
        }
    }
}
