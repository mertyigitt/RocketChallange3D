using System.Collections;
using System.Collections.Generic;
using RocketChallange.Managers;
using UnityEngine;

namespace RocketChallange.UIs
{
    public class MenuPanel : MonoBehaviour
    {
        public void StartClick()
        {
            GameManager.Instance.LoadLevelScene(1);
        }
        
        public void ExitClick()
        {
            GameManager.Instance.Exit();
        }
    }
}
