using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStatsMVC.Models.ViewModels
{
    public class UserRoleViewModel
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string Username { get; set; }
    }
}
