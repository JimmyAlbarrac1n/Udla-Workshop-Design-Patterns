using System;
using DesignPatterns.Models;

namespace DesignPatterns.BuilderModels;

public class CarModelBuilder
{
    private string color = "Red";
    private string model = "Sedan";
    private int year = DateTime.Now.Year;
    private string brand = "Toyota";


    public CarModelBuilder SetColor(string color)
    {
        this.color = color;
        return this;
    }

    public CarModelBuilder SetModel(string model)
    {
        this.model = model;
        return this;
    }

    public CarModelBuilder SetYear(int year)
    {
        this.year = year;
        return this;
    }

    public CarModelBuilder SetBrand(string brand)
    {
        this.brand = brand;
        return this;
    }

    public Vehicle Build()
    {
        return new Car(color, brand, model, year);
    }
}