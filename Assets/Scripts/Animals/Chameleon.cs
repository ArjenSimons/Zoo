using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Chameleon : Animal, ICarnivore, ITrickster
    {
        [SerializeField]
        private Image image;

        public override void SayHello()
        {
            Balloon.SetActive(true);
            text.text = "krrrr";
        }

        public void EatMeat()
        {
            Balloon.SetActive(true);
            text.text = "nomnomnom thx krrrr";
        }

        public void PerformTrick()
        {
            StartCoroutine(DoTrick());
        }

        private IEnumerator DoTrick()
        {
            //Fade out
            for (int i = 0; i < 100; i++)
            {
                var tempColor = image.color;
                tempColor.a -= 1 / 100f;
                image.color = tempColor;
                yield return new WaitForEndOfFrame();
            }

            yield return new WaitForSeconds(0.5f);

            //Fade In
            for (int i = 0; i < 100; i++)
            {
                var tempColor = image.color;
                tempColor.a += 1 / 100f;
                image.color = tempColor;
                yield return new WaitForEndOfFrame();
            }
        }
    }
}
