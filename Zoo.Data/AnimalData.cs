using System.Collections;
using Zoo.Common;

namespace Zoo.Data
{
	public struct AnimalData
	{
	Animal[] Animals { get; } = new[] {
		new Animal("Lion", true),
		new Animal("Giraffe", false),
		new Animal("Quakka", false),
		new Animal("Tiger", true),
		};

        public AnimalData()
        {
            
        }

		public IEnumerable<Animal> GetAnimals(bool isPredator) { 
			foreach (var animal in Animals)
				if(animal.Predator.Equals(isPredator))
				yield return animal;
		}
    }
		
}