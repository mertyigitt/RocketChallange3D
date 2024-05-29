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
        [SerializeField] private float _turnSpeed;
        [SerializeField] private float _force;
        private DefaultInput _input;
        private Mover _mover;
        private Rotator _rotator;
        
        private bool _isForceUp;
        private float _leftRight;
        public float TurnSpeed => _turnSpeed;
        public float Force => _force;

        private void Awake()
        {
            _input = new DefaultInput();
            _mover = new Mover(this);
            _rotator = new Rotator(this);
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

            _leftRight = _input.LeftRight;
        }

        private void FixedUpdate()
        {
            if (_isForceUp)
            {
                _mover.FixedTick();
            }
            
            _rotator.FixedTick(_leftRight);
        }
    }
}


