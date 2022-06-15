using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewsLatterManager : INewsLatterService
    {
        INewsLatterDAL _newsLatterDAL;

        public NewsLatterManager(INewsLatterDAL newsLatterDAL)
        {
            _newsLatterDAL = newsLatterDAL;
        }

        public void NewsLatterAdd(NewsLatter newslatter)
        {
            _newsLatterDAL.Insert(newslatter);
        }
    }
}
