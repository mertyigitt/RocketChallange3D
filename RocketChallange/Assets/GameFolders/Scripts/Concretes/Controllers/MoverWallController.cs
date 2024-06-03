using System;
using RocketChallange.Abstracts.Controllers;
using Unity.Mathematics;
using UnityEngine;

namespace RocketChallang.Controllers
{
    public class MoverWallController : WallController
    {
        [SerializeField] private Vector3 direction;
        [SerializeField] float speed;
        
        private float factor;
        private Vector3 _startPosition;
        private const float FULL_CIRCLE = Mathf.PI * 2f;


        private void Awake()
        {
            _startPosition = transform.position;
        }

        private void Update()
        {
            float cycle = Time.time / speed;
            float sinWave = Mathf.Sin(cycle * FULL_CIRCLE);

            factor = sinWave / 2f + 0.5f;
            
            Vector3 offset = direction * factor;
            transform.position = _startPosition + offset;
        }
    }
}
