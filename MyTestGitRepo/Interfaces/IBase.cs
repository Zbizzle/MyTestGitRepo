using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTestGitRepo.Interfaces
{
    interface IBase
    {
        int Id { get; set; }
        DateTime DateCreated { get; set; }
    }
}
