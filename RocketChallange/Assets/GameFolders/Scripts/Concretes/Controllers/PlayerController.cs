using System;
using System.Collections;
using System.Collections.Generic;
using RocketChallange.Inputs;
using RocketChallange.Movements;
using UnityEngine;

namespace RocketChallange.Controllers
{ 
    public class PlayerController : MonoBehaviour
    {
        private DefaultInput _input;
        private Mover _mover;
        
        private bool _isForceUp;

        private void Awake()
        {
            _input = new DefaultInput();
            _mover = new Mover(GetComponent<Rigidbody>());
        }

        private void Update()
        {
            if (_input.IsForceUp)
            {
                _isForceUp = true;
            }
            else
            {
                _isForceUp = false;
            }
        }

        private void FixedUpdate()
        {
            if (_isForceUp)
            {
                _mover.FixedTick();
            }
        }
    }
}


