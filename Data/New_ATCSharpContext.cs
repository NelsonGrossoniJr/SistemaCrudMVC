using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using New_ATCSharp.Models;

namespace New_ATCSharp.Data
{
    public class New_ATCSharpContext : DbContext
    {
        public New_ATCSharpContext(DbContextOptions<New_ATCSharpContext> options)
            : base(options)
        {
        }


        public DbSet<New_ATCSharp.Models.PilotoViewModel> PilotoViewModel { get; set; } = default!;

        public DbSet<New_ATCSharp.Models.CarroViewModel>? CarroViewModel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PilotoViewModel>().HasData(
            new PilotoViewModel()
            {
                Id = 1,
                Nome = "Dominic Toreto",
                Idade = 52,
                Equipe = "velozes e furiosos",
                CorridasGanhas = 100,
                Data = DateTime.Now

            },
            new PilotoViewModel()
            {
                Id = 2,
                Nome = "Brian O´Conner",
                Idade = 43,
                Equipe = "velozes e furiosos",
                CorridasGanhas = 85,
                Data = DateTime.Now
            }
            );

            modelBuilder.Entity<CarroViewModel>().HasData(
            new CarroViewModel() 
            {
                Id = 1,
                Marca = "Nissan",
                Modelo = "Skyline",
                Cor = "Azul e prata",
                Potencia = 100,
                CarImgFileName = "skylinevelozesefuriosos.jpeg"

            },
            new CarroViewModel() 
            {
                Id = 2,
                Marca = "Toyota",
                Modelo = "Supra",
                Cor = "Laranja",
                Potencia = 200,
                CarImgFileName = "toyota-supra.jpg"
            }
            );
        }
    }
}
