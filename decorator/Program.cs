using StructuralPatterns.Base;
using StructuralPatterns.Decorators;

var firstMilkTea = new EggPudding(
                    new FruitPudding(
                        new BlackSugar(
                            new Bubble(
                                new MilkTea()))));
Console.WriteLine("EggPudding And FruitPudding BlackSugar Bubble MilkTea: " + firstMilkTea.Cost() + "\n");


var secondMilkTea = new EggPudding(
                        new BlackSugar(
                            new WhiteBubble(
                                new MilkTea())));
Console.WriteLine("EggPudding BlackSugar WhiteBubble MilkTea: " + secondMilkTea.Cost() + "\n");