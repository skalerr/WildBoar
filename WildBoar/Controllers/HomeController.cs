using System.Diagnostics;
using DAL.EntityFramework;
using DAL.Implementations;
using DAL.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;
using WildBoar.Models;

namespace WildBoar.Controllers;

public class HomeController : Controller
{
    
    public HomeController(IRepository<ProductEntity> repository)
    {
    }


    public void eftest()
    {
    }
}