﻿using Cozy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cozy.Data.Interfaces
{
   public interface IHomeDataService
    {
        // create homes 
        Home Create(Home newHome);

        //read homes 
        Home GetById(int homeId);
        ICollection<Home> GetByLandlordId(int landlordId);

        //update homes 
        Home Update(Home updatedHome);

        //delete homes 
        bool DeleteById(int homeId);
    }
}
