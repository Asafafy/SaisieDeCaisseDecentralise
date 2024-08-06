namespace SoftCaisse.Models
{
    using SoftCaisse.Utils.Global;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        [Key]
        public int UserId { get; set; }

        public string Login { get; set; }

        public string UserPassword { get; set; }

        public RoleUser RoleId { get; set; }
    }
}
