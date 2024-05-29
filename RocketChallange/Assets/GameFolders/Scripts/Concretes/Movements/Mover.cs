using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RocketChallange.Movements
{
    public class Mover
    {
        private Rigidbody _rigidbody;

        public Mover(Rigidbody rigidbody)
        {
            _rigidbody = rigidbody;
        }

        public void FixedTick()
        {
            _rigidbody.AddRelativeForce(Vector3.up * 100f * Time.deltaTime );
        }
    }
}

