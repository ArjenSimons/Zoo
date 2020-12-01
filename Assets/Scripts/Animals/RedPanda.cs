
namespace Zoo
{
    class RedPanda : Animal, IHerbevore
    {
        public override void SayHello()
        {
            Balloon.SetActive(true);
            text.text = "piep piep";
        }

        public void EatLeaves()
        {
            Balloon.SetActive(true);
            text.text = "nom nom piep";
        }
    }
}
