using ETicaretAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Appplication.Repositories
{
    public interface IRepository<T>where T : BaseEntity
    {

         public DbSet<T> Table { get; }
    }
}
