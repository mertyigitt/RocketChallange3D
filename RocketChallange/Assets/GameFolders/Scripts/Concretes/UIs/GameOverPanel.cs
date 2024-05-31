
using System.Collections;
using System.Collections.Generic;
using RocketChallange.Managers;
using UnityEngine;

namespace RocketChallange.UIs
{
    public class GameOverPanel : MonoBehaviour
    {
        public void RestartClick()
        {
            GameManager.Instance.LoadLevelScene();
        }
        
        public void MenuClick()
        {
            GameManager.Instance.LoadMenuScene();
        }
    }
}
