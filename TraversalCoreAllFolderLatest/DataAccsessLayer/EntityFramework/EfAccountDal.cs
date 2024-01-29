using DataAccessLayer.Repository;
using DataAccsessLayer.Abstract;
using DataAccsessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.EntityFramework
{
    public class EfAccountDal : GenericUowRepository<Account>,IAccountDal
    {
        public EfAccountDal(Context context):base(context)
        {
            
        }
    }
}
