﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Utils.DTO
{
    public class ResoponseDto<T>
    {

        public bool IsSucess { get; set; }

        public string Message { get; set; }

        public T Result { get; set; }

    }
}
