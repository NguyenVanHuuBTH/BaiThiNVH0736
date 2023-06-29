using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BaiThiNVH.Models;

    public class NVH : DbContext
    {
        public NVH (DbContextOptions<NVH> options)
            : base(options)
        {
        }

        public DbSet<BaiThiNVH.Models.NVHCau3> NVHCau3 { get; set; } = default!;
    }
