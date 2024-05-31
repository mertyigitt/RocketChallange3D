using System;
using System.Collections;
using System.Collections.Generic;
using RocketChallange.Managers;
using UnityEngine;

namespace RocketChallange.UIs
{
    public class WinConditionObject : MonoBehaviour
    {
        [SerializeField] GameObject winConditionPanel;

        private void Awake()
        {
            if (winConditionPanel.activeSelf)
            {
                winConditionPanel.SetActive(false);
            }
        }

        private void OnEnable()
        {
            GameManager.Instance.OnMissionSucced += HandleOnMissionSucced;
        }

        private void HandleOnMissionSucced()
        {
            if (!winConditionPanel.activeSelf)
            {
                winConditionPanel.SetActive(true);
            }
        }

        private void OnDisable()
        {
            GameManager.Instance.OnMissionSucced -= HandleOnMissionSucced;
        }
    }
}
