using System;
using System.Collections;
using System.Collections.Generic;
using RocketChallange.Inputs;
using RocketChallange.Managers;
using RocketChallange.Movements;
using Unity.VisualScripting;
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
        private Fuel _fuel;

        private bool _canMove;
        private bool _canForceUp;
        private float _leftRight;
        public float TurnSpeed => _turnSpeed;
        public float Force => _force;

        private void Awake()
        {
            _input = new DefaultInput();
            _mover = new Mover(this);
            _rotator = new Rotator(this);
            _fuel = GetComponent<Fuel>();
        }

        private void Start()
        {
            _canMove = true;
        }

        private void OnEnable()
        {
            GameManager.Instance.OnGameOver += HandleOnEventTrigger;
            GameManager.Instance.OnMissionSucced += HandleOnEventTrigger;
        }
        
        private void OnDisable()
        {
            GameManager.Instance.OnGameOver -= HandleOnEventTrigger;
            GameManager.Instance.OnMissionSucced -= HandleOnEventTrigger;
        }

        private void Update()
        {
            if (!_canMove) return;
            
            if (_input.IsForceUp && !_fuel.IsEmpty)
            {
                _canForceUp = true;
            }
            else
            {
                _canForceUp = false;
                _fuel.FuelIncrease(0.02f);
            }

            _leftRight = _input.LeftRight;
        }

        private void FixedUpdate()
        {
            if (_canForceUp)
            {
                _mover.FixedTick();
                _fuel.FuelDecrease(0.2f);
            }
            
            _rotator.FixedTick(_leftRight);
        }
        
        private void HandleOnEventTrigger()
        {
            _canMove = false;
            _canForceUp = false;
            _leftRight = 0f;
            _fuel.FuelIncrease(0f);

        }
    }
}


