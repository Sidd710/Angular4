namespace Angular4Api
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataModel : DbContext
    {
        public DataModel()
            : base("name=DataModel")
        {
        }

        public virtual DbSet<userDetail> userDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
