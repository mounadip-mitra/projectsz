using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMusicStore.Models;

namespace MvcMusicStore.Models
{
    public class MusicStoreDB : DbContext
    {
        public MusicStoreDB (DbContextOptions<MusicStoreDB> options)
            : base(options)
        {
        }

        public DbSet<MvcMusicStore.Models.Album> Album { get; set; }
        public DbSet<MvcMusicStore.Models.Artist> Artists { get; set; }
        public DbSet<MvcMusicStore.Models.Genre> Genres { get; set; }
        public DbSet<MvcMusicStore.Models.Order> Order { get; set; } = default!;
    }
}
