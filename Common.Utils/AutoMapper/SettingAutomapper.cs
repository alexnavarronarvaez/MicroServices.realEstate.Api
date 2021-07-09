using AutoMapper;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Utils.AutoMapper
{
    [ExcludeFromCodeCoverage]
    public partial class SettingAutomapper
    {


        protected SettingAutomapper()
        {


        }
        public static void CreateMaps()
        {
            Mapper.Reset();                                     
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMissingTypeMaps = true;
                cfg.ValidateInlineMaps = false;

            });

        }

    }
}
