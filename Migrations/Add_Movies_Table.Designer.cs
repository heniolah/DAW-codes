using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using ExamenAngular.Data;

namespace ExamenAngular.Migrations
{
    [DbContext(typeof(ExamenAngularContext))]
    [Migration("Add_Movies_Table")]
    partial class Add_Duckbills_Table
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
