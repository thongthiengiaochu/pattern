﻿using StructuralPatterns.Base;

namespace StructuralPatterns.Decorators
{
    public class EggPudding : MilkTeaDecorator
    {
        public EggPudding(IMilkTea inner) : base(inner)
        {
        }

        public override double Cost()
        {
            return 3d + base.Cost();
        }
    }
}
