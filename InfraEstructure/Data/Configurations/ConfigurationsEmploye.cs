using Dominio.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraEstructure.Data.Configurations
{
    public class ConfigurationsEmploye : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            
            builder.HasKey(x => x.ID).HasName("PK_EMPLOYEE");
            builder.HasAlternateKey(x => x.IdentityCard).HasName("ALT_IDENTITY");

            builder.HasIndex(x => x.ID, "UNIQID").IsUnique();
            builder.HasIndex(x => x.IdentityCard, "UNIQ_IDENTITYCARD").IsUnique();
            builder.HasIndex(x => x.NumberPhone, "UNIQ_NUMBERPHONE").IsUnique();

            builder.Property(x => x.ID).HasColumnName("ID").UseIdentityColumn(1, 1);
            builder.Property(x => x.Name).HasColumnName("Name").HasColumnType("VARCHAR").HasMaxLength(30);
            builder.Property(x => x.LastName).HasColumnName("LastName").HasColumnType("VARCHAR").HasMaxLength(30);
            builder.Property(x => x.Email).HasColumnName("Email").HasColumnType("VARCHAR").HasMaxLength(100);
            builder.Property(x => x.Gender).HasColumnName("Gender").HasColumnType("VARCHAR").HasMaxLength(30);
            builder.Property(x => x.IdentityCard).HasColumnName("IdentityCard");
            builder.Property(x => x.IdentityType).HasColumnName("IdentityType").HasColumnType("VARCHAR").HasMaxLength(5);
            builder.Property(x => x.Profession).HasColumnName("Profession").HasColumnType("VARCHAR").HasMaxLength(50);
            builder.Property(x => x.Adress).HasColumnName("Adress").HasColumnType("VARCHAR").HasMaxLength(50);
            builder.Property(x => x.Status).HasColumnName("Status");
            builder.Property(x => x.city).HasColumnName("CityID");
            builder.Property(x => x.NumberPhone).HasColumnName("NumberPhone").HasColumnType("VARCHAR").HasMaxLength(15);
            builder.Property(x => x.CreateDate).HasColumnName("CreateDate").HasColumnType("DATETIME");
            builder.Property(x => x.UpdateDate).HasColumnName("UpdateDate").HasColumnType("DATETIME");
        }
    }
}
