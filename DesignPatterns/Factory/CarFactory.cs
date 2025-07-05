using System;
using DesignPatterns.Models;

namespace DesignPatterns.Factories;

public abstract class CarFactory
{
    public abstract Vehicle Create();
}