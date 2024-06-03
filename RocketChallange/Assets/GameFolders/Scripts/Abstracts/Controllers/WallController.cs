using RocketChallange.Controllers;
using RocketChallange.Managers;
using UnityEngine;

namespace RocketChallange.Abstracts.Controllers
{
    public abstract class WallController : MonoBehaviour
    {
        private void OnCollisionEnter(Collision other)
        {
            PlayerController player = other.collider.GetComponent<PlayerController>();

            if (player != null && player.CanMove)
            {
                GameManager.Instance.GameOver();
            }
        }
    }
}

