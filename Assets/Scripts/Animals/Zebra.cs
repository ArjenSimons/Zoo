
namespace Zoo
{
    class Zebra : Animal, IHerbevore
    {
        public override void SayHello()
        {
            Balloon.SetActive(true);
            text.text = "zebra zebra";
        }

        public void EatLeaves()
        {
            Balloon.SetActive(true);
            text.text = "munch munch zank yee bra";
        }
    }
}
