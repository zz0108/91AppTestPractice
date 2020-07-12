using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _91APPtest.Models
{
    public class AppTest: DbContext
    {
        public AppTest(DbContextOptions<AppTest> options) : base(options) { }
    }
}
