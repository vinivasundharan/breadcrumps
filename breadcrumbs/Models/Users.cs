using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace breadcrumbs.Models
{
    public class Users
    {
        public int ID { get; set; }
        //Should set the value to be unique
        
        [Required]
        [Key]
        
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public bool Reader { get; set; }
        public bool Editor { get; set; }
        public bool Admin { get; set; }
        public bool Exporter { get; set; }
    }
    public class UsersContext : DbContext
    {
        public DbSet<Users> Users { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Users>.HasKey(x => x.UserCode);
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}