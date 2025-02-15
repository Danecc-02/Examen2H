﻿using Examen2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace Examen2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Examen2.Models.Priority> Priority { get; set; }
    }
}
