﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
 public  interface IReservationService : IGenericService<Reservation>
    {

        List<Reservation> GetListReservationByWaitApproval(int id);
        List<Reservation> GetListReservationByAccepted(int id);
        List<Reservation> GetListReservationByPrevious(int id);
       
       
    }
}
