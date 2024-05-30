using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace RocketChallange.Controllers
{
    public class FinishFloorController : MonoBehaviour
    {
        [SerializeField] private GameObject finishFirework;
        [SerializeField] private GameObject finishLight;
        
        private void OnCollisionEnter(Collision other)
        {
            PlayerController player = other.collider.GetComponent<PlayerController>();

            if (player == null) return;

            if (other.GetContact(0).normal.y == -1)
            {
                finishFirework.SetActive(true);
                finishLight.SetActive(true);
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}
