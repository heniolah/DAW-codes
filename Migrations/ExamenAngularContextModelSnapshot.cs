using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using ExamenAngular.Data;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(ExamenAngularContext))]
    partial class ExamenAngularContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExamenAngular.Models.Duckbill", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<string>("Name");

                b.HasKey("Id");

                b.ToTable("Movies");
            });

            modelBuilder.Entity("ExamenAngular.Models.Value", b =>
            {
                b.Property<Guid>("ID")
                    .ValueGeneratedOnAdd();

                b.Property<string>("Name");

                b.HasKey("ID");

                b.ToTable("Values");
            });
#pragma warning restore 612, 618
        }
    }
}
