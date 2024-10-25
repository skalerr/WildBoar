﻿using DAL.Interfaces;
using Domain.Entites.BaseEntity;
using WildBoar.Models;

namespace DAL.Implementations;

public class ShoppingCartEntity : BaseEntity<long>, IAuditable
{
    public ClientEntity Client { get; set; }
    public List<ProductEntity> Product { get; set; }
    public decimal Price { get { return Product.Sum(item => item.Price); }}
    public bool IsDeleted { get; set; }
    public DateTime? DeleteDate { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime? UpdateDate { get; set; }
}