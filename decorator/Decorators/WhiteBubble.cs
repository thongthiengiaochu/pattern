﻿using StructuralPatterns.Base;

namespace StructuralPatterns.Decorators
{
    public class WhiteBubble : MilkTeaDecorator
    {
        public WhiteBubble(IMilkTea inner) : base(inner)
        {
        }

        public override double Cost()
        {
            return 1.5 + base.Cost();
        }
    }
}
