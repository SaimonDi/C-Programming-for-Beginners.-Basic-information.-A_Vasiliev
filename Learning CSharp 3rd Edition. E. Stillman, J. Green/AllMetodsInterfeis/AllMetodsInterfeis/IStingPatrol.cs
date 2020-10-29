﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllMetodsInterfeis {
    interface IStingPatrol {
            int AllertLevel { get; }
            int StingerLength { get; set; }
            bool LookForEnemies();
            int SharpenStinger(int length);
        }
    }