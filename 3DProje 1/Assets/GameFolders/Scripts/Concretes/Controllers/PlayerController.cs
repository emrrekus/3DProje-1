using Proje1.Inputs;
using Proje1.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Proje1.Controllers 
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float _turnSpeed = 10f;
        [SerializeField] float _force = 500f;
        Mover _mover;
        DInput _input;
        Rototar _rototar;

        bool _isForceUp;
        float _leftRight;

        public float TurnSpeed => _turnSpeed;
        public float Force => _force;

        private void Awake()
        {
           _mover = new Mover(this);
            _input = new DInput();
            _rototar = new Rototar(this);
        }

        private void FixedUpdate()
        {
            if (_isForceUp)
            {
                _mover.FixedTick();
              
            }
            _rototar.FixedTick(_leftRight); 
            
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
            _leftRight = _input.LeftRight;
        }
    }
}

