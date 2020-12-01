using System.Collections.Generic;
using UnityEngine;

namespace Zoo
{
    class Spawner : MonoBehaviour
    {
        [SerializeField]
        private SpawnableAnimal[] animalsToSpawn;

        private List<Animal> animals = new List<Animal>();
        public List<Animal> Animals => animals;

        private void Start()
        {
            foreach (SpawnableAnimal spawnableAnimal in animalsToSpawn)
            {
                Animal animal = Instantiate(spawnableAnimal.AnimalPrefab, transform).GetComponent<Animal>();
                animal.Name = spawnableAnimal.Name;

                animals.Add(animal);
            }         
        }
    }
}
