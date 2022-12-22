using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Proje1.Controllers
{
    public class StartFloorController : MonoBehaviour
    {
        private void OnCollisionExit(Collision collision)
        {
            PlayerController player= collision.collider.GetComponent<PlayerController>();

            if(player != null)
            {
                gameObject.SetActive(false);
            }
        }


    }

}

