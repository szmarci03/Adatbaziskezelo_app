using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ZH2_M9PVND.Models;

public partial class MyContext : DbContext
{
    public MyContext()
    {
    }

    public MyContext(DbContextOptions<MyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Actor> Actors { get; set; }

    public virtual DbSet<Rating> Ratings { get; set; }

    public virtual DbSet<Show> Shows { get; set; }

    public virtual DbSet<ShowActor> ShowActors { get; set; }

    public virtual DbSet<Type> Types { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=szmarci03.database.windows.net;Initial Catalog=netflix_titles;User ID=szmarci03;Password=Password123");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actor>(entity =>
        {
            entity.HasKey(e => e.ActorId).HasName("pk_Actor");

            entity.ToTable("Actor");

            entity.Property(e => e.ActorId)
                .ValueGeneratedNever()
                .HasColumnName("actor_id");
            entity.Property(e => e.ActorName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("actor_name");
        });

        modelBuilder.Entity<Rating>(entity =>
        {
            entity.HasKey(e => e.RatingId).HasName("pk_Rating");

            entity.ToTable("Rating");

            entity.Property(e => e.RatingId)
                .ValueGeneratedNever()
                .HasColumnName("rating_id");
            entity.Property(e => e.Ratingvalue)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("ratingvalue");
        });

        modelBuilder.Entity<Show>(entity =>
        {
            entity.HasKey(e => e.ShowId).HasName("pk_Show");

            entity.ToTable("Show");

            entity.HasIndex(e => e.Title, "uk_Show").IsUnique();

            entity.Property(e => e.ShowId)
                .ValueGeneratedNever()
                .HasColumnName("show_id");
            entity.Property(e => e.DateAdded)
                .HasColumnType("date")
                .HasColumnName("date_added");
            entity.Property(e => e.RatingId).HasColumnName("rating_id");
            entity.Property(e => e.ReleaseYear)
                .HasDefaultValueSql("('Nincs megadva')")
                .HasColumnName("release_year");
            entity.Property(e => e.Title)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.TypeId).HasColumnName("type_id");

            entity.HasOne(d => d.Rating).WithMany(p => p.Shows)
                .HasForeignKey(d => d.RatingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Show_Rating");

            entity.HasOne(d => d.Type).WithMany(p => p.Shows)
                .HasForeignKey(d => d.TypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Show_Type");
        });

        modelBuilder.Entity<ShowActor>(entity =>
        {
            entity.HasKey(e => e.ShowActorId).HasName("PK__Show_Act__047DDB6B71C1E3BE");

            entity.ToTable("Show_Actor");

            entity.Property(e => e.ShowActorId).HasColumnName("show_actor_id");
            entity.Property(e => e.ActorId).HasColumnName("actor_id");
            entity.Property(e => e.ShowId).HasColumnName("show_id");

            entity.HasOne(d => d.Actor).WithMany(p => p.ShowActors)
                .HasForeignKey(d => d.ActorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_saa_Actor");

            entity.HasOne(d => d.Show).WithMany(p => p.ShowActors)
                .HasForeignKey(d => d.ShowId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_saa_Show");
        });

        modelBuilder.Entity<Type>(entity =>
        {
            entity.HasKey(e => e.TypeId).HasName("pk_Type");

            entity.ToTable("Type");

            entity.Property(e => e.TypeId)
                .ValueGeneratedNever()
                .HasColumnName("type_id");
            entity.Property(e => e.Typename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("typename");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
