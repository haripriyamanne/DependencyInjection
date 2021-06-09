using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionServices.Interfaces
{
    public interface ITransientService
    {
        string Time { get; set; }
    }
}
