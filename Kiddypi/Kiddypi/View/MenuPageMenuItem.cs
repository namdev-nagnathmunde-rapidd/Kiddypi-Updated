﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiddypi.View
{

    public class MenuPageMenuItem
    {
        public MenuPageMenuItem()
        {
            TargetType = typeof(MenuPageDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }

        public Type TargetType { get; set; }
    }
}