using DataAccsessLayer.Abstract;
using DataAccsessLayer.Concrete;
using DataAccsessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.EntityFramework
{

    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        public List<Comment> GetListCommentWithDestination()
        {
            using ( var c = new Context())
            {
                return c.Comments.Include( x=>x.Destination).ToList();
            }
        }

        public List<Comment> GetListCommentWithoutDestinationAndUser(int id)
        {
            using (var c = new Context())
            {
                return c.Comments.Where(x=>x.DestinationID== id).Include(x=>x.AppUser).ToList();
            }
        }
    }
}
