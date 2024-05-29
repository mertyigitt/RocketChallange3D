using System;
using System.Collections;
using System.Collections.Generic;
using RocketChallange.Inputs;
using UnityEngine;

namespace RocketChallange.Controllers
{ 
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float force;
        private Rigidbody _rigidbody;
        private DefaultInput _input;

        private bool _isForceUp;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _input = new DefaultInput();
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
                _rigidbody.AddForce(Vector3.up * force, ForceMode.Force);
            }
        }
    }
}


