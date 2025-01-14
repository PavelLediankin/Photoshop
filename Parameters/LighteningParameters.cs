﻿namespace MyPhotoshop.Parameters
{
    public class LighteningParameters : IParameters
    {
        [ParameterInfo(Name = "Коэффициент", MaxValue = 10, MinValue = 0, Increment = 0.1, DefaultValue = 1)]
        public double Coeficient { get; set; }
    }
}
