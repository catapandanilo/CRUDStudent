using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Entity.EntityConfig
{
    public class ConfigurationStudent : EntityTypeConfiguration<Student>
    {
        public ConfigurationStudent()
        {
            HasKey(s => s.Id);

            Property(s => s.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(s => s.Name)
                .IsVariableLength()
                .IsRequired()
                .HasMaxLength(150);

            //mapStudent.Property(s => s.BirthDate)
            //    .IsOptional();

            //mapStudent.HasKey(s => s.Id);

            Property(s => s.BirthDate).IsRequired();
        }
    }
}
