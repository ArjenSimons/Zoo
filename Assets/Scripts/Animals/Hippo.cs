
namespace Zoo
{
    class Hippo : Animal, IHerbevore
    {
        public override void SayHello()
        {
            Balloon.SetActive(true);
            text.text = "splash";
        }

        public void EatLeaves()
        {
            Balloon.SetActive(true);
            text.text = "munch munch lovely";
        }
    }   
}
