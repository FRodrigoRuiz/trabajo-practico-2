using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JuegoDeRol;

namespace JuegoDeRol.Data
{
    public class UserContext : DbContext
    {
        public UserContext (DbContextOptions<UserContext> options)
            : base(options)
        {
        }

        public DbSet<JuegoDeRol.User> User { get; set; } = default!;
        public DbSet<JuegoDeRol.Character> Character { get; set; } = default!;
        public DbSet<JuegoDeRol.Weapon> Weapon { get; set; } = default!;
        public DbSet<JuegoDeRol.Skill> Skill { get; set; } = default!;

        public DbSet<JuegoDeRol.CharacterSkill> CharacterSkill { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
            .HasMany(e => e.Characters)
            .WithOne(e => e.User)
            .HasForeignKey(e => e.UserId)
            .IsRequired();

            modelBuilder.Entity<Character>()
            .HasOne(e => e.Weapon)
            .WithOne(e => e.Character)
            .HasForeignKey<Weapon>(e => e.CharacterId)
            .IsRequired();

            modelBuilder.Entity<Character>()
            .HasMany(e => e.Skills)
            .WithMany(e => e.Characters)
            .UsingEntity<CharacterSkill>();
        }
    }
}
