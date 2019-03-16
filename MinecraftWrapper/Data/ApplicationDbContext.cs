﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MinecraftWrapper.Models;

namespace MinecraftWrapper.Data
{
    public class ApplicationDbContext : IdentityDbContext<AuthorizedUser>
    {
        public ApplicationDbContext ( DbContextOptions<ApplicationDbContext> options )
            : base ( options )
        {
        }

        public DbSet<AuthorizationKey> AuthorizationKey { get; set; }
        public DbSet<ApplicationLog> ApplicationLog { get; set; }
        public DbSet<NewsItem> NewsItem { get; set; }
        public DbSet<UserPreference> UserPreference { get; set; }
        public DbSet<UtilityRequest> UtilityRequest { get; set; }
    }
}
