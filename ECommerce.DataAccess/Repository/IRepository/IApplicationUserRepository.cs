﻿using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccess.Repository.IRepository
{
    public interface IApplicationUserRepository: IRepository<ApplicationUser>
    {
        void Update(ApplicationUser obj);
    }
}
