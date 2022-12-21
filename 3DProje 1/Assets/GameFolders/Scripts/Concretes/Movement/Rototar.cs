using Proje1.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Proje1.Movements
{
    public class Rototar
    {
        Rigidbody _rb;
        PlayerController _playerController;

        public Rototar(PlayerController playerController)
        {
            _playerController = playerController;
            _rb = playerController.GetComponent<Rigidbody>();
        }

        public void FixedTick(float direction)
        {
            if (direction == 0)
            {

                if (_rb.freezeRotation) _rb.freezeRotation = false;
                return;
            }

            if (!_rb.freezeRotation) _rb.freezeRotation = true;
            _playerController.transform.Rotate(Vector3.back * Time.deltaTime * direction * _playerController.TurnSpeed);
        }
    }

}

