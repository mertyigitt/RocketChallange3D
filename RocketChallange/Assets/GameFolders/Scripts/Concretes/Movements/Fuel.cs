using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RocketChallange.Movements
{
    public class Fuel : MonoBehaviour
    {
        [SerializeField] private float maxFuel;
        [SerializeField] private float currentFuel;
        [SerializeField] private ParticleSystem particle;
        public bool IsEmpty => currentFuel < 1f;

        private void Awake()
        {
            currentFuel = maxFuel;
        }

        public void FuelIncrease(float increase)
        {
            currentFuel += increase;
            currentFuel = MathF.Min(currentFuel, maxFuel);

            if (particle.isPlaying)
            {
                particle.Stop();
            }
        }
        
        public void FuelDecrease(float decrease)
        {
            currentFuel -= decrease;
            currentFuel = MathF.Max(currentFuel, 0);
            
            if (particle.isStopped)
            {
                particle.Play();
            }
        }
    }
}

