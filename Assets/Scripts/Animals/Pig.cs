using System.Collections;
using UnityEngine;

namespace Zoo
{
    class Pig : Animal, IHerbevore, ICarnivore, ITrickster
    {
        public override void SayHello()
        {
            Balloon.SetActive(true);
            text.text = "oink oink";
        }

        public void EatLeaves()
        {
            Balloon.SetActive(true);
            text.text = "munch munch oink";
        }

        public void EatMeat()
        {
            Balloon.SetActive(true);
            text.text = "nomnomnom oink thx";
        }

        public void PerformTrick()
        {
            StartCoroutine(DoTrick());
        }

        IEnumerator DoTrick()
        {
            for (int i = 0; i < 360; i++)
            {
                transform.localRotation = Quaternion.Euler(i, 0, 0);
                yield return new WaitForEndOfFrame();
            }
        }
    }
}
