﻿using ProjectLemonade.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Interfaces
{
    public interface IRace
    {
        string Name { get; set; }
        int ID { get; set; }
        List<IRaceBaseAttribute> BaseMaxAttributes { get; set; }
        List<int> Classes { get; set; }
        List<IEducation> Educations { get; set; }
    }
}
