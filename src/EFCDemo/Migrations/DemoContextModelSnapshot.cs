using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using EFCDemo.Models;

namespace EFCDemo.Migrations
{
    [DbContext(typeof(DemoContext))]
    partial class DemoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCDemo.Models.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("email");

                    b.Property<string>("password");

                    b.HasKey("AccountId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("EFCDemo.Models.Purchase", b =>
                {
                    b.Property<int>("PurchaseId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatePurchased");

                    b.Property<string>("ProductDescription");

                    b.Property<string>("ProductName");

                    b.Property<int>("accountIdFK");

                    b.HasKey("PurchaseId");

                    b.HasIndex("accountIdFK");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("EFCDemo.Models.Purchase", b =>
                {
                    b.HasOne("EFCDemo.Models.Account", "account")
                        .WithMany("Purchases")
                        .HasForeignKey("accountIdFK")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
