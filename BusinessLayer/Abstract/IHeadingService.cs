using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHeadingService
    {
        List<Heading> GetList();
        List<Heading> GetListByWriter();
        void HeadingAdd(Heading heading);
        Heading GetById(int id); //sadece id e göre işlem yapılacak
        void HeadingDelete(Heading heading);
        void HeadingUpdate(Heading heading);
    }
}
