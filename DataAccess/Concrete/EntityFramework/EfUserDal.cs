﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Core.Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, NorthwindContext>, IUserDal
    {
        public List<Role> GetRoles(User user)
        {
            using (var context = new NorthwindContext())
            {
                var result = from c in context.Claims
                             join uc in context.UserClaims
                             on c.Id equals uc.RoleId
                             where uc.UserId == user.Id
                             select new Role
                             {
                                 Id = c.Id,
                                 Name = c.Name
                             };

                return result.ToList();
            }

        }
    }
}
