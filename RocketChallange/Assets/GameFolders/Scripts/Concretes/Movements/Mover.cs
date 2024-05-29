using System.Collections;
using System.Collections.Generic;
using RocketChallange.Controllers;
using UnityEngine;

namespace RocketChallange.Movements
{
    public class Mover
    {
        private Rigidbody _rigidbody;
        private PlayerController _playerController;

        public Mover(PlayerController playerController)
        {
            _playerController = playerController;
            _rigidbody = playerController.GetComponent<Rigidbody>();
        }

        public void FixedTick()
        {
            _rigidbody.AddRelativeForce(Vector3.up * _playerController.Force * Time.deltaTime );
        }
    }
}

