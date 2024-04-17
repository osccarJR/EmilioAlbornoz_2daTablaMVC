using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmilioAlbornoz_WebCF.Models;

namespace EmilioAlbornoz_WebCF.Data
{
    public class EmilioAlbornoz_WebCFContext : DbContext
    {
        public EmilioAlbornoz_WebCFContext (DbContextOptions<EmilioAlbornoz_WebCFContext> options)
            : base(options)
        {
        }

        public DbSet<EmilioAlbornoz_WebCF.Models.Burger> Burger { get; set; } = default!;
    }
}
