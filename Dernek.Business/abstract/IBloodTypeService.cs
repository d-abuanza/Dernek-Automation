using Dernek.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dernek.Business.Abstract
{
    public interface IBloodTypeService
    {
        BloodType Get(string id);
        List<BloodType> GetAll(string filter = null);
        void Add(BloodType entity);
        void Delete(BloodType entity);
        void Update(BloodType entity);

    }
}
