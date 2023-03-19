using Domain.Entities;
using Domain.Interfaces;

namespace Domain.Interfaces.Account;

public class Registration : IRegistration
{
    public Client Add(Client client)
    {
        return client;
    }
}