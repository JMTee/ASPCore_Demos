using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using EFCDemo.Models;

namespace EFCDemo.Migrations
{
    [DbContext(typeof(DemoContext))]
    [Migration("20161014152429_Migration2")]
    partial class Migration2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
