using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using AxiInterfaces.DTO;
using System.Reflection.Emit;

public class SetUp : DbContext
{
    public DbSet<FeedbackDTO> FeedbackDTO { get; set; }
    public DbSet<GebruikerDTO> GebruikerDTO { get; set; }
    public DbSet<ProfielDTO> ProfielDTO { get; set; }
    public DbSet<TeamDTO> TeamDTO { get; set; }
    public DbSet<VraagDTO> VraagDTO { get; set; }
    public DbSet<LijstDTO> LijstDTO { get; set; }
    public DbSet<TeamLijstDTO> TeamLijstDTO { get; set; }
    public DbSet<VraagLijstDTO> VraagLijstDTO { get; set; }
    public DbSet<GebruikerTeamProfielDTO> gebruikerTeamProfielDTO { get; set; }

    public SetUp()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Server=mssqlstud.fhict.local;Database=dbi483663_dbaxi;User Id=dbi483663_dbAxi;Password=AxiFeedbackdb;Encrypt=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<GebruikerTeamProfielDTO>(builder =>
        {
            builder.HasKey(e => e.GebruikerId);
        });
        modelBuilder.Entity<VraagLijstDTO>(builder =>
        {
            builder.HasKey(e => e.VraagId);
        });
        modelBuilder.Entity<TeamLijstDTO>(builder =>
        {
            builder.HasKey(e => e.TeamId);
        });
        //modelBuilder.Ignore<GebruikerTeamProfielDTO>(); // Ignore GebruikerTeamProfielDTO
        //modelBuilder.Ignore<VraagLijstDTO>(); // Ignore VraagLijstDTO
        //modelBuilder.Ignore<TeamLijstDTO>(); // Ignore TeamLijstDTO


        base.OnModelCreating(modelBuilder);
    }
}