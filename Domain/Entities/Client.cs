using WildBoar.Models;

namespace Domain.Entities;

public class Client : ClientEntity
{
    public Client(string fistName, string lastName, string patronymic, string phoneNumber, string email, string address)
    {
        FirstName = fistName;
        LastName = lastName;
        Patronymic = patronymic;
        Phone = phoneNumber;
        Email = email;
        Address = address;
    }
}