using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    public class AnimalUI : MonoBehaviour
    {
        [SerializeField]
        private Spawner spawner;

        [SerializeField]
        private Button btnGiveLeaves;

        [SerializeField]
        private Button btnGiveMeat;

        [SerializeField]
        private Button btnTricks;

        [SerializeField]
        private Button btnHello;

        [SerializeField]
        private InputField ifAnimalName;

        private void Start()
        {
            //Set Listeners
            btnGiveLeaves.onClick.AddListener(OnGiveLeavesPressed);
            btnGiveMeat.onClick.AddListener(OnGiveMeatPressed);
            btnTricks.onClick.AddListener(OnTricksPressed);
            btnHello.onClick.AddListener(OnHelloPressed);
        }

        //Handles the GiveLeaves button press
        private void OnGiveLeavesPressed()
        {
            foreach(Animal animal in spawner.Animals)
            {
                if (animal is IHerbevore)
                {
                    ((IHerbevore)animal).EatLeaves();
                }
            }
        }

        //Handles the GiveMeat button press
        private void OnGiveMeatPressed()
        {
            foreach (Animal animal in spawner.Animals)
            {
                if (animal is ICarnivore)
                {
                    ((ICarnivore)animal).EatMeat();
                }
            }
        }

        //Handles the Tricks button press
        private void OnTricksPressed()
        {
            foreach (Animal animal in spawner.Animals)
            {
                if (animal is ITrickster)
                {
                    ((ITrickster)animal).PerformTrick();
                }
            }
        }

        //Handles the Hello button press
        private void OnHelloPressed()
        {
            foreach(Animal animal in spawner.Animals)
            {
                if (ifAnimalName.text == string.Empty || ifAnimalName.text == animal.Name)
                {
                    animal.SayHello();
                }
            }
        }
    }
}
