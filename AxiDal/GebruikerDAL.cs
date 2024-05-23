﻿using AxiInterfaces.DTO;
using AxiInterfaces.InterFaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiDal
{
    public class GebruikerDAL : DbContext, IGebruiker
    {
        public List<GebruikerDTO> GetAll()
        {
            using var db = new SetUp();
            try
            {
                List<GebruikerDTO> gebruikerDTOs = db.GebruikerDTO.ToList();
                return gebruikerDTOs;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public GebruikerDTO GetUserById(int id)
        {
            using var db = new SetUp();
            try
            {
                GebruikerDTO dto = db.GebruikerDTO
                    .Where(x => x.Id == id)
                    .FirstOrDefault();
                return dto;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public bool MaakGebruiker(GebruikerDTO gebruikerDTO)
        {
            using var db = new SetUp();

            try
            {
                Console.WriteLine("Gebruiker aanmaken");
                db.Add(gebruikerDTO);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool UpdateGebruiker(GebruikerDTO gebruikerDTO)
        {
            using var db = new SetUp();
            try
            {
                Console.WriteLine("Gebruiker bijwerken");
                db.Attach(gebruikerDTO);
                db.Entry(gebruikerDTO).State = EntityState.Modified;

                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public bool VerwijderGebruiker(GebruikerDTO gebruikerDTO)
        {
            using var db = new SetUp();
            try
            {
                Console.WriteLine("Gebruiker verwijderen");
                db.Remove(gebruikerDTO);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
    }
}
