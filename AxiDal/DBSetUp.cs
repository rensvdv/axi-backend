using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using AxiInterfaces.DTO;

public class SetUp : DbContext
{
    public string DbPath { get; }

    public SetUp()
    {
        OnConfiguring(new DbContextOptionsBuilder());
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Server=mssqlstud.fhict.local;Database=dbi483663_dbaxi;User Id=dbi483663_dbAxi;Password=AxiFeedbackdb;Encrypt=True;TrustServerCertificate=False;");
}