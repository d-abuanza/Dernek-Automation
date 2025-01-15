using Dernek.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dernek.Business.Abstract
{
    public interface ICityService
    {
        City Get(string id);
        List<City> GetAll(string filter = null);
        void Add(City entity);
        void Delete(City entity);
        void Update(City entity);

    }
}
