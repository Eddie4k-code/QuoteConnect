using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Application.Interfaces
{
    public interface ILogger
    {
        void Log(string message);
    }
}