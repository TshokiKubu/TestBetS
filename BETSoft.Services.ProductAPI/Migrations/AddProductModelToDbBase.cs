using BETSoft.Services.ProductAPI.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BETSoft.Services.ProductAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext)), Migration("20210501172009_AddProductModelToDb")]
    internal class AddProductModelToDbBase : AddProductModelToDbBaseBase
    {
    }
}