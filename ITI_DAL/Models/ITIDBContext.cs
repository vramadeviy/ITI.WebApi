using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ITI_DAL.Models
{
    public partial class ITIDBContext : DbContext
    {
        public ITIDBContext()
        {
        }

        public ITIDBContext(DbContextOptions<ITIDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Applicate> Applicates { get; set; } = null!;
        public virtual DbSet<DboMobileRegister> DboMobileRegisters { get; set; } = null!;
        public virtual DbSet<MstCountry> MstCountries { get; set; } = null!;
        public virtual DbSet<OptionsApplied> OptionsApplieds { get; set; } = null!;
        public virtual DbSet<SeatMatrix> SeatMatrices { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=182.156.84.26;Initial Catalog=ITIDB;Integrated Security=False;Persist Security Info=False;User ID=itidbuser;Password=x@Dn9yTqcb5bU1eh");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("itidbuser");

            modelBuilder.Entity<Applicate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Applicates", "dbo");

                entity.Property(e => e.AllocatedCategory)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.AllocatedIticode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AllocatedITICode");

                entity.Property(e => e.AllocatedTrade)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicantName).HasMaxLength(255);

                entity.Property(e => e.ApprovedByVocode)
                    .HasMaxLength(255)
                    .HasColumnName("ApprovedByVOCode");

                entity.Property(e => e.ApprovedByVoname)
                    .HasMaxLength(255)
                    .HasColumnName("ApprovedByVOName");

                entity.Property(e => e.Category).HasMaxLength(255);

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.FatherName).HasMaxLength(255);

                entity.Property(e => e.FinalGp).HasColumnName("FinalGP");

                entity.Property(e => e.Gender).HasMaxLength(255);

                entity.Property(e => e.IsEws)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("IsEWS");

                entity.Property(e => e.IsPh)
                    .HasMaxLength(255)
                    .HasColumnName("IsPH");

                entity.Property(e => e.Isexg)
                    .HasMaxLength(255)
                    .HasColumnName("ISEXG");

                entity.Property(e => e.Isorphan)
                    .HasMaxLength(255)
                    .HasColumnName("ISORPHAN");

                entity.Property(e => e.LocalStatus).HasMaxLength(255);

                entity.Property(e => e.MotherName).HasMaxLength(255);

                entity.Property(e => e.Qualification).HasMaxLength(255);

                entity.Property(e => e.QualificationBoard).HasMaxLength(255);

                entity.Property(e => e.Religion).HasMaxLength(255);

                entity.Property(e => e.VerifiedDate).HasColumnType("datetime");

                entity.Property(e => e.VomobileNo).HasColumnName("VOMobileNo");
            });

            modelBuilder.Entity<DboMobileRegister>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dbo.MobileRegister");

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<MstCountry>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mstCountry");

                entity.Property(e => e.CountryId).HasMaxLength(50);

                entity.Property(e => e.CountryName).HasMaxLength(100);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<OptionsApplied>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OptionsApplied", "dbo");

                entity.Property(e => e.Gender)
                    .HasMaxLength(255)
                    .HasColumnName("gender");

                entity.Property(e => e.Iticode)
                    .HasMaxLength(255)
                    .HasColumnName("ITICode");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Name1)
                    .HasMaxLength(255)
                    .HasColumnName("name1");

                entity.Property(e => e.Name2)
                    .HasMaxLength(255)
                    .HasColumnName("name2");

                entity.Property(e => e.Name3)
                    .HasMaxLength(255)
                    .HasColumnName("name3");

                entity.Property(e => e.Phase)
                    .HasMaxLength(255)
                    .HasColumnName("phase");

                entity.Property(e => e.Trade)
                    .HasMaxLength(255)
                    .HasColumnName("trade");
            });

            modelBuilder.Entity<SeatMatrix>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SeatMatrix", "dbo");

                entity.Property(e => e.Amg).HasColumnName("AMG");

                entity.Property(e => e.Amw).HasColumnName("AMW");

                entity.Property(e => e.Bcag).HasColumnName("BCAG");

                entity.Property(e => e.Bcaw).HasColumnName("BCAW");

                entity.Property(e => e.Bcbg).HasColumnName("BCBG");

                entity.Property(e => e.Bcbw).HasColumnName("BCBW");

                entity.Property(e => e.Bccg).HasColumnName("BCCG");

                entity.Property(e => e.Bccw).HasColumnName("BCCW");

                entity.Property(e => e.Bcdg).HasColumnName("BCDG");

                entity.Property(e => e.Bcdw).HasColumnName("BCDW");

                entity.Property(e => e.Bceg).HasColumnName("BCEG");

                entity.Property(e => e.Bcew).HasColumnName("BCEW");

                entity.Property(e => e.Cmg).HasColumnName("CMG");

                entity.Property(e => e.Cmw).HasColumnName("CMW");

                entity.Property(e => e.Districtname)
                    .HasMaxLength(255)
                    .HasColumnName("DISTRICTNAME");

                entity.Property(e => e.Ewsg).HasColumnName("EWSG");

                entity.Property(e => e.Ewsw).HasColumnName("EWSW");

                entity.Property(e => e.Exg).HasColumnName("EXG");

                entity.Property(e => e.Exw).HasColumnName("EXW");

                entity.Property(e => e.Imc).HasColumnName("IMC");

                entity.Property(e => e.Iticode)
                    .HasMaxLength(255)
                    .HasColumnName("ITICODE");

                entity.Property(e => e.Itiname)
                    .HasMaxLength(255)
                    .HasColumnName("ITINAME");

                entity.Property(e => e.Mmg).HasColumnName("MMG");

                entity.Property(e => e.Mmw).HasColumnName("MMW");

                entity.Property(e => e.Ocg).HasColumnName("OCG");

                entity.Property(e => e.Ocw).HasColumnName("OCW");

                entity.Property(e => e.Org).HasColumnName("ORG");

                entity.Property(e => e.Orw).HasColumnName("ORW");

                entity.Property(e => e.Phg).HasColumnName("PHG");

                entity.Property(e => e.Phw).HasColumnName("PHW");

                entity.Property(e => e.Scg).HasColumnName("SCG");

                entity.Property(e => e.Scw).HasColumnName("SCW");

                entity.Property(e => e.Stg).HasColumnName("STG");

                entity.Property(e => e.Stw).HasColumnName("STW");

                entity.Property(e => e.Total).HasColumnName("TOTAL");

                entity.Property(e => e.Tradecode).HasColumnName("TRADECODE");

                entity.Property(e => e.Tradename)
                    .HasMaxLength(255)
                    .HasColumnName("TRADENAME");

                entity.Property(e => e.Ur).HasColumnName("UR");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
