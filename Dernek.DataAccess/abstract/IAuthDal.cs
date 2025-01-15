using Dernek.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dernek.DataAccess.Abstract
{
    public interface IAuthDal
    {
        Member Login(string tcKimlik, string password);
        bool IsAdmin(string tcKimlik);
    }
}
