using Proje1.Inputs;
using Proje1.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Proje1.Controllers 
{
    public class PlayerController : MonoBehaviour
    {

        Mover _mover;
        DInput _input;

        bool _isForceUp;
        
        private void Awake()
        {
           _mover = new Mover(GetComponent<Rigidbody>());
            _input = new DInput();
        }

        private void FixedUpdate()
        {
            if (_isForceUp)
            {
                _mover.FixedTick();
              
            }
            
        }
        private void Update()
        {
            if (_input.IsForceUp)
            {
                _isForceUp = true;
            }
            else
            {
                _isForceUp = false;
            }
        }
    }
}

