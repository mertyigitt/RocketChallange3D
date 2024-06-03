using RocketChallange.Movements;
using UnityEngine;
using UnityEngine.UI;

namespace RocketChallange.UIs
{
    public class FuelSlider : MonoBehaviour
    {
        private Slider _slider;
        private Fuel _fuel;
        private void Awake()
        {
            _slider = GetComponent<Slider>();
            _fuel = FindObjectOfType<Fuel>();
        }

        private void Update()
        {
            _slider.value = _fuel.CurrentFuel;
        }
    }
}
