using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AuthTask.Models;


namespace AuthTask.Models
{
    public static class DAL
    {

        public static Demo ValidateUser(String pLogin, String pPassword)
        {
            using (var D = new DotNetTrainingEntities1()) 
            {
                var user = D.Logins
                    .Where(u => u.UserName == pLogin && u.Password == pPassword)
                    .Select(u => new Demo
                    {
                        PK_LoginID = u.PK_LoginID.ToString(),
                        UserName = u.UserName,
                        Password = u.Password,

                    }).FirstOrDefault();

                return user;
            }

        }
    }

       
    }
