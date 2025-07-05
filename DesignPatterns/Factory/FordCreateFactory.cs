using System;
using DesignPatterns.BuilderModels;
using DesignPatterns.Models;

namespace DesignPatterns.Factories;

public class FordCreateFactory : CarFactory
{
    public override Vehicle Create()
    {
        return new CarModelBuilder()
            .SetModel("Escape")
            .Build();
    }
}