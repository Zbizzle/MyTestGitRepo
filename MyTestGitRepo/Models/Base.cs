using MyTestGitRepo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTestGitRepo.Models
{
    public class Base : IBase
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
