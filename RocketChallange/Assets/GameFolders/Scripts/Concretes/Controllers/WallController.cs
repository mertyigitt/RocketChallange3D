using System;
using System.Collections;
using System.Collections.Generic;
using RocketChallange.Managers;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace RocketChallange.Controllers
{
    public class WallController : MonoBehaviour
    {
        private void OnCollisionEnter(Collision other)
        {
            PlayerController player = other.collider.GetComponent<PlayerController>();

            if (player != null)
            {
                GameManager.Instance.GameOver();
            }
        }
    }
}

