﻿using Core.Base;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_M_Users")]
    public class User : BaseModel
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public Role RoleId { get; set; }

        public User() { }

        public User(UserVM userVM)
        {
            this.Email = userVM.Email;
            this.Password = userVM.Password;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }

        public void Update(UserVM userVM)
        {
            this.Email = userVM.Email;
            this.Password = userVM.Password;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}
