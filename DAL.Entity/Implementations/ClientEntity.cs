﻿using DAL.Enums;
using DAL.Implementations;
using DAL.Interfaces;
using Domain.Entites.BaseEntity;

namespace WildBoar.Models;

public class ClientEntity : BaseEntity<long>, IAuditable
{
    
    public string FullName { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Patronymic { get; set; }
    public string? Email { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public Role Role { get; set; }
    
    public List<ShoppingCartEntity> ShoppingsCart { get; set; }
    public List<OrderEntity> Orders { get; set; }
    
    public DateTime? UpdateDate { get; set; }
    public DateTime CreateDate { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime? DeleteDate { get; set; }
    

}