using System;
using Microsoft.EntityFrameworkCore;
using SectionD.Models;
namespace SectionD.Data
{
    public class MsgDbContext:DbContext
    {
        public MsgDbContext(DbContextOptions<MsgDbContext> options):base(options)
        {

        }
        public DbSet<Message> Message { get; set; }
    }
}

