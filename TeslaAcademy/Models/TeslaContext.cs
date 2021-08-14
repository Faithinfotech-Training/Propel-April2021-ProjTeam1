using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TeslaAcademy.Models
{
    public partial class TeslaContext : DbContext
    {
        public TeslaContext()
        {
        }

        public TeslaContext(DbContextOptions<TeslaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Candidatedetails> Candidatedetails { get; set; }
        public virtual DbSet<Coursemain> Coursemain { get; set; }
        public virtual DbSet<Degreelist> Degreelist { get; set; }
        public virtual DbSet<Lookup> Lookup { get; set; }
        public virtual DbSet<Organization> Organization { get; set; }
        public virtual DbSet<Streamlist> Streamlist { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Userpermission> Userpermission { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=faithpropelapril.cyjryyniianp.ap-south-1.rds.amazonaws.com;Initial Catalog=Tesla;Persist Security Info=True;User ID=team1;Password=team1");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidatedetails>(entity =>
            {
                entity.HasKey(e => e.Candidateid);

                entity.ToTable("candidatedetails");

                entity.Property(e => e.Candidateid).HasColumnName("candidateid");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Backlogs).HasColumnName("backlogs");

                entity.Property(e => e.Candidateimage)
                    .HasColumnName("candidateimage")
                    .IsUnicode(false);

                entity.Property(e => e.Candidatenumber)
                    .HasColumnName("candidatenumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Collegename)
                    .HasColumnName("collegename")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Courseid).HasColumnName("courseid");

                entity.Property(e => e.Coursename)
                    .HasColumnName("coursename")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("date");

                entity.Property(e => e.Degreeid).HasColumnName("degreeid");

                entity.Property(e => e.Dob)
                    .HasColumnName("dob")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Experience).HasColumnName("experience");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Percentage).HasColumnName("percentage");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Yop).HasColumnName("yop");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Candidatedetails)
                    .HasForeignKey(d => d.Courseid)
                    .HasConstraintName("FK__candidate__cours__4CA06362");

                entity.HasOne(d => d.Degree)
                    .WithMany(p => p.Candidatedetails)
                    .HasForeignKey(d => d.Degreeid)
                    .HasConstraintName("FK__candidate__degre__4D94879B");
            });

            modelBuilder.Entity<Coursemain>(entity =>
            {
                entity.HasKey(e => e.Courseid);

                entity.ToTable("coursemain");

                entity.Property(e => e.Courseid).HasColumnName("courseid");

                entity.Property(e => e.Backlog)
                    .HasColumnName("backlog")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Closingdate)
                    .HasColumnName("closingdate")
                    .HasColumnType("date");

                entity.Property(e => e.Courseduration).HasColumnName("courseduration");

                entity.Property(e => e.Coursename)
                    .HasColumnName("coursename")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("date");

                entity.Property(e => e.Experience).HasColumnName("experience");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Maxnoofcandidate).HasColumnName("maxnoofcandidate");

                entity.Property(e => e.Orgid).HasColumnName("orgid");

                entity.Property(e => e.Percentage).HasColumnName("percentage");

                entity.Property(e => e.Qualification)
                    .HasColumnName("qualification")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("date");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Timeslot)
                    .HasColumnName("timeslot")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.Coursemain)
                    .HasForeignKey(d => d.Orgid)
                    .HasConstraintName("FK__coursemai__orgid__47DBAE45");
            });

            modelBuilder.Entity<Degreelist>(entity =>
            {
                entity.HasKey(e => e.Degreeid);

                entity.ToTable("degreelist");

                entity.Property(e => e.Degreeid).HasColumnName("degreeid");

                entity.Property(e => e.Courseid).HasColumnName("courseid");

                entity.Property(e => e.Degreename)
                    .HasColumnName("degreename")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Degreelist)
                    .HasForeignKey(d => d.Courseid)
                    .HasConstraintName("FK__degreelis__cours__49C3F6B7");
            });

            modelBuilder.Entity<Lookup>(entity =>
            {
                entity.ToTable("lookup");

                entity.Property(e => e.Lookupid).HasColumnName("lookupid");

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("date");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Lookupname)
                    .HasColumnName("lookupname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Parentid).HasColumnName("parentid");

                entity.Property(e => e.Position).HasColumnName("position");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Organization>(entity =>
            {
                entity.HasKey(e => e.Orgid);

                entity.ToTable("organization");

                entity.Property(e => e.Orgid).HasColumnName("orgid");

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("date");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Orgaddress)
                    .HasColumnName("orgaddress")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Orgcountry)
                    .HasColumnName("orgcountry")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Orgdistrict)
                    .HasColumnName("orgdistrict")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Orglocality)
                    .HasColumnName("orglocality")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Orgname)
                    .HasColumnName("orgname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Orgpin)
                    .HasColumnName("orgpin")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Orgstate)
                    .HasColumnName("orgstate")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Streamlist>(entity =>
            {
                entity.HasKey(e => e.Streamid);

                entity.ToTable("streamlist");

                entity.Property(e => e.Streamid).HasColumnName("streamid");

                entity.Property(e => e.Courseid).HasColumnName("courseid");

                entity.Property(e => e.Degreeid).HasColumnName("degreeid");

                entity.Property(e => e.Stream)
                    .HasColumnName("stream")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Streamlist)
                    .HasForeignKey(d => d.Courseid)
                    .HasConstraintName("FK__streamlis__cours__4AB81AF0");

                entity.HasOne(d => d.Degree)
                    .WithMany(p => p.Streamlist)
                    .HasForeignKey(d => d.Degreeid)
                    .HasConstraintName("FK__streamlis__degre__4BAC3F29");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Contact)
                    .HasColumnName("contact")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Orgid).HasColumnName("orgid");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Permissionid).HasColumnName("permissionid");

                entity.Property(e => e.Rolename)
                    .HasColumnName("rolename")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Setpermission)
                    .HasColumnName("setpermission")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Userimage)
                    .HasColumnName("userimage")
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.Orgid)
                    .HasConstraintName("FK__user__orgid__440B1D61");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.Permissionid)
                    .HasConstraintName("FK__user__permission__44FF419A");
            });

            modelBuilder.Entity<Userpermission>(entity =>
            {
                entity.HasKey(e => e.Permissionid);

                entity.ToTable("userpermission");

                entity.Property(e => e.Permissionid).HasColumnName("permissionid");

                entity.Property(e => e.Courseid).HasColumnName("courseid");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Userpermission1)
                    .HasColumnName("userpermission")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Userpermission)
                    .HasForeignKey(d => d.Courseid)
                    .HasConstraintName("FK__userpermi__cours__46E78A0C");

                entity.HasOne(d => d.UserNavigation)
                    .WithMany(p => p.Userpermission)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("FK__userpermi__useri__45F365D3");
            });
        }
    }
}
