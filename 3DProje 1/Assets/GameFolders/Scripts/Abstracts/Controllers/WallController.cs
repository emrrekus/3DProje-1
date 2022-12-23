using Proje1.Controllers;
using Proje1.Managers;

using UnityEngine;


namespace Proje1.Abstracts.Controllers
{
    
    public abstract class WallController : MonoBehaviour
    {

        private void OnCollisionEnter(Collision collision)
        {
            PlayerController player = collision.collider.GetComponent<PlayerController>();

            if (player != null && player.CanMove)
            {
                GameManager.Instance.GameOver();
            }
        }

    }

}




