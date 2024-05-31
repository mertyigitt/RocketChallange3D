using System.Collections;
using System.Collections.Generic;
using RocketChallange.Managers;
using UnityEngine;

namespace RocketChallange.UIs
{
    public class WinConditionPanel : MonoBehaviour
    {
        public void NextLevelClick()
        {
            GameManager.Instance.LoadLevelScene(1);
        }
    }
}
