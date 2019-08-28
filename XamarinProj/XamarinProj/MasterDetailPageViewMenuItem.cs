﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinProj
{

    public class MasterDetailPageViewMenuItem
    {
        public MasterDetailPageViewMenuItem()
        {
            TargetType = typeof(MasterDetailPageViewDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}