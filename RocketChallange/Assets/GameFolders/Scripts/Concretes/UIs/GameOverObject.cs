using System;
using System.Collections;
using System.Collections.Generic;
using RocketChallange.Managers;
using UnityEngine;

namespace RocketChallange.UIs
{
    public class GameOverObject : MonoBehaviour
    {
        [SerializeField] GameObject gameOverPanel;

        private void Awake()
        {
            if (gameOverPanel.activeSelf)
            {
                gameOverPanel.SetActive(false);
            }
        }

        private void OnEnable()
        {
            GameManager.Instance.OnGameOver += HandleOnGameOver;
        }

        private void HandleOnGameOver()
        {
            if (!gameOverPanel.activeSelf)
            {
                gameOverPanel.SetActive(true);
            }
        }

        private void OnDisable()
        {
            GameManager.Instance.OnGameOver -= HandleOnGameOver;
        }
    }
}
