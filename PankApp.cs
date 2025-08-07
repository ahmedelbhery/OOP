namespace ConsoleApp1.Pank_System;

public class BankAccount
{
    public const string BankCode = "BNK001";
    public readonly DateTime CreatedDate;

    private int _accountNumber;
    private string _fullName;
    private string _nationalID;
    private string _phoneNumber;
    private string _address;
    private decimal _balance;
    
    public string FullName
    {
        get
        {
            return _fullName;
        }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                _fullName = value;
            }
        }
    }


    public string NationalID
    {
        get
        {
            return _nationalID;
        }
        set
        {
            if (value.Length == 14)
            {
                _nationalID = value;
            }
        }
    }


    public string PhoneNumber
    {
        get
        {
            return _phoneNumber;
        }
        set
        {
            if (IsValidPhoneNumber(value))
            {
                _phoneNumber = value;
            }
        }
    }


    public string Address
    {
        get
        {
            return _address;
        }
        set
        {
            _address = value;
        }
    }
    
    public decimal Balance
    {
        get
        {
            return _balance;
        }
        set
        {
            if (value > 0)
            {
                _balance = value;
            }
        }
    }
    
    public BankAccount()
    {
        CreatedDate = DateTime.Now;
        FullName = "Unknown";
        NationalID = "00000000000000";
        PhoneNumber = "01000000000";
        Address = "N/A";
        Balance = 0;
    }
    
    public BankAccount(string fullName, string nationalID, string phoneNumber, string address, decimal balance)
    {
        CreatedDate = DateTime.Now;
        FullName = fullName;
        NationalID = nationalID;
        PhoneNumber = phoneNumber;
        Address = address;
        Balance = balance;
    }
    
    

    public void ShowAccountDetails()
    {
        Console.WriteLine("========== Bank Account Details ==========");
        Console.WriteLine($"Bank Code     : {BankCode}");
        Console.WriteLine($"Full Name     : {FullName}");
        Console.WriteLine($"National ID   : {NationalID}");
        Console.WriteLine($"Phone Number  : {PhoneNumber}");
        Console.WriteLine($"Address       : {Address}");
        Console.WriteLine($"Balance       : {Balance} EGP");
        Console.WriteLine($"Created Date  : {CreatedDate}");
        Console.WriteLine("==========================================");
    }
    

    public bool IsValidPhoneNumber(string number)
    {
        return number.Length == 11;
    }
}

