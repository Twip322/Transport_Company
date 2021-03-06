// <auto-generated />
using System;
using Controller.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Controller.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20220408101741_testOrderCargo")]
    partial class testOrderCargo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Controller.Models.Cargo", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int?>("OrderId")
                        .IsRequired();

                    b.Property<int>("Weight");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Cargos");
                });

            modelBuilder.Entity("Controller.Models.Order", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("CustomerName");

                    b.Property<string>("CustomerSurName");

                    b.Property<int>("WorkerId");

                    b.Property<DateTime>("endTime");

                    b.Property<int>("orderEnum");

                    b.Property<DateTime>("startTime");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Controller.Models.Vehicle", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Carrying");

                    b.Property<string>("Name");

                    b.Property<int>("Speed");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("Controller.Models.Worker", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsFree");

                    b.Property<string>("Name");

                    b.Property<string>("Surname");

                    b.Property<int?>("VehicleId");

                    b.HasKey("Id");

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("Controller.Models.Cargo", b =>
                {
                    b.HasOne("Controller.Models.Order", "Order")
                        .WithMany("orderCargo")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
