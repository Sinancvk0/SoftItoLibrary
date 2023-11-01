using Data.Abstract;
using Data.Repository;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.EntityFramework
{
    public class EfUser:GenericRepository<User>,IUser
    {

    }
}
