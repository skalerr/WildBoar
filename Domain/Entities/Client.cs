using WildBoar.Models;

namespace Domain.Entities;

public class Client
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Patronymic { get; set; }
    public string? Email { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    
    public Role Role { get; set; }
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