﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Abstract
{
    public interface ICommentDal : IGenericDal<Comment>
    {
        public List<Comment> GetListCommentWithDestination();
        public List <Comment> GetListCommentWithoutDestinationAndUser(int id);
    }
}
