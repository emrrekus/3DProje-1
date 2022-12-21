using Proje1.Inputs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Proje1.Controllers 
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float _force;
        Rigidbody _rb;
        DInput _input;

        bool _isForceUp;
        
        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();   
            _input = new DInput();
        }

        private void FixedUpdate()
        {
            if (_isForceUp)
            {

                _rb.AddForce(Vector3.up*Time.deltaTime*_force);
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

