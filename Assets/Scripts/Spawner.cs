using System;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo
{
    class Spawner : MonoBehaviour
    {
        [SerializeField]
        private SpawnableAnimal[] animalsToSpawn;


        private void Start()
        {
            foreach (SpawnableAnimal spawnableAnimal in animalsToSpawn)
            {
                Animal animal = Instantiate(spawnableAnimal.AnimalPrefab, transform).GetComponent<Animal>();
                animal.Name = spawnableAnimal.Name;
            }

            //Lion henk = Instantiate(lion.AnimalPrefab, transform).GetComponent<Lion>();
            //henk.Name = "henk";
            //Hippo elsa = Instantiate(hippo.AnimalPrefab, transform).GetComponent<Hippo>();
            //elsa.Name = "elsa";
            //Pig dora = Instantiate(pig.AnimalPrefab, transform).GetComponent<Pig>();
            //dora.Name = "dora";
            //Tiger wally = Instantiate(tiger.AnimalPrefab, transform).GetComponent<Tiger>();
            //wally.Name = "wally";
            //Zebra marty = Instantiate(zebra.AnimalPrefab, transform).GetComponent<Zebra>();
            //marty.Name = "marty";            
        }
    }
}
