using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainbow_Announce_EXILED_SCPSL
{
    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
    }
}
