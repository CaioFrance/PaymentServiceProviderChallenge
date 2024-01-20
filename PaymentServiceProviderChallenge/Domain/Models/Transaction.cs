using PaymentServiceProviderChallenge.Models.Enums;

namespace PaymentServiceProviderChallenge.Models;

public class Transaction
{
    public long Id { get; set; }
    public double Amount { get; set; }
    public string Description { get; set; } = string.Empty;
    public PaymentMethod PaymentMethod { get; set; }
    public string CardNumber { get; set; } = string.Empty;
    public string Holder { get; set; } = string.Empty;
    public string ExpirationDate { get; set; } = string.Empty;
    public int CVV { get; set; }
}
