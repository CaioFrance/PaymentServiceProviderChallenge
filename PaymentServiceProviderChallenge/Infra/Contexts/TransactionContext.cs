using Microsoft.EntityFrameworkCore;
using PaymentServiceProviderChallenge.Models;

namespace PaymentServiceProviderChallenge.Infra.Contexts;

public class TransactionContext(DbContextOptions<TransactionContext> options) : DbContext(options)
{
    public DbSet<Transaction> Transactions { get; set; }

}
