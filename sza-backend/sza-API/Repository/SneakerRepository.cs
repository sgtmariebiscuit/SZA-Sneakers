using Repository.EntityFramework.Concrete;
using Repository.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sza_API.Models;

public class SneakerRepository :
    EntityFrameworkRepository<Sneaker>
{
    public SneakerRepository(SZADbContext context) : base(context)
    {
    }
}
