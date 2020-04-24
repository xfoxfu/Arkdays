using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Noha.Arkdays.Models
{
    public class ArkdaysContext : DbContext
    {
        public ArkdaysContext()
        {
        }

        public ArkdaysContext(DbContextOptions<ArkdaysContext> options)
            : base(options)
        {
        }
    }
}
