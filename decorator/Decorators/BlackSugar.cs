using StructuralPatterns.Base;

namespace StructuralPatterns.Decorators
{
    public class BlackSugar : MilkTeaDecorator
    {
        public BlackSugar(IMilkTea inner) : base(inner)
        {
        }

        public override double Cost()
        {
            return 2d + base.Cost();
        }
    }
}
