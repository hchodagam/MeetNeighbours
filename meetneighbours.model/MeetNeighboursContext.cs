using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using meetneighbours.DTO;
using System.Data.Entity.Validation;

namespace meetneighbours.model
{
    public class MeetNeighboursContext:DbContext
    {
        public MeetNeighboursContext()
        {
            Database.SetInitializer<MeetNeighboursContext>(new DropCreateDatabaseIfModelChanges<MeetNeighboursContext>());
        }
        public void Commit()
        {
            try
            {
                base.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {

                    }
                }
            }
        }
        public DbSet<Category> Category { get; set; }
        public DbSet<SubCategory> SubCategory { get; set; }
        public DbSet<Street> Street { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Locality> Locality { get; set; }
        public DbSet<BusinessLists> BusinessLists { get; set; }
    }

}
