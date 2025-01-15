using Dernek.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dernek.Business.Abstract
{
    public interface IDuesService
    {
        void Add(Dues entity);
        void Update(Dues entity);
        void Delete(Dues entity);

        Dues GetById(string id);
        Dues Get(int month, int year);
        List<Dues> GetAll();
    }
}
