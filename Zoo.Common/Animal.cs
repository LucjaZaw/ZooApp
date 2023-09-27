namespace Zoo.Common;

public struct Animal
{	
	public string AnimalType { get; init; }
	public bool Predator { get; init; }

	public Animal(string animalType, bool predator) =>
		(AnimalType, Predator) = (animalType, predator);
    }