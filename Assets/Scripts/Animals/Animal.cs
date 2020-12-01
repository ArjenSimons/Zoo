using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    public abstract class Animal : MonoBehaviour
    {
        [SerializeField]
        protected GameObject Balloon;

        [SerializeField]
        protected Text text;

        public string Name;

        public abstract void SayHello();
    }
}
