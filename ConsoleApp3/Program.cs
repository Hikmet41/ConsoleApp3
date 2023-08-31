using System;
using System.Collections.Generic;

class Animal
{
    public string Nickname { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public int Energy { get; set; }
    public double Price { get; set; }
    public int MealQuantity { get; set; }

    public void Eat()
    {
        Energy += 10;
        MealQuantity++;
    }

    public void Sleep()
    {
        Energy = Math.Min(Energy + 15, 100);
    }

    public void Play()
    {
        if (Energy >= 20)
        {
            Energy -= 20;
        }
        else
        {
            Console.WriteLine($"{Nickname} doesn't have enough energy to play.");
        }
    }
}

class Cat : Animal { }

class Dog : Animal { }

class Bird : Animal { }

class Fish : Animal { }

class PetShop
{
    public List<Cat> Cats { get; set; }
    public List<Dog> Dogs { get; set; }
    public List<Bird> Birds { get; set; }
    public List<Fish> Fishes { get; set; }

    public PetShop()
    {
        Cats = new List<Cat>();
        Dogs = new List<Dog>();
        Birds = new List<Bird>();
        Fishes = new List<Fish>();
    }

    public void RemoveByNickname(string nickname)
    {
        Cats.RemoveAll(cat => cat.Nickname == nickname);
        Dogs.RemoveAll(dog => dog.Nickname == nickname);
        Birds.RemoveAll(bird => bird.Nickname == nickname);
        Fishes.RemoveAll(fish => fish.Nickname == nickname);
    }

    public double CalculateTotalPrice()
    {
        double total = 0;
        foreach (Cat cat in Cats) total += cat.Price;
        foreach (Dog dog in Dogs) total += dog.Price;
        foreach (Bird bird in Birds) total += bird.Price;
        foreach (Fish fish in Fishes) total += fish.Price;
        return total;
    }

    public int CalculateTotalMealQuantity()
    {
        int totalMeals = 0;
        foreach (Cat cat in Cats) totalMeals += cat.MealQuantity;
        foreach (Dog dog in Dogs) totalMeals += dog.MealQuantity;
        foreach (Bird bird in Birds) totalMeals += bird.MealQuantity;
        foreach (Fish fish in Fishes) totalMeals += fish.MealQuantity;
        return totalMeals;
    }
}

