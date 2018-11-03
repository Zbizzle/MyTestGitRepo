using MyTestGitRepo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTestGitRepo.Models
{
    public class Team : Base, ITeam
    {
        public string Name { get; set; }
        public string Nickname { get; set; }
    }
}
