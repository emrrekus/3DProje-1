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
        Fuel _fuel;

        bool _canForceUp;
        float _leftRight;

        public float TurnSpeed => _turnSpeed;
        public float Force => _force;

        private void Awake()
        {
           _mover = new Mover(this);
            _input = new DInput();
            _rototar = new Rototar(this);
            _fuel= GetComponent<Fuel>();
        }

        private void FixedUpdate()
        {
            if (_canForceUp)
            {
                _mover.FixedTick();
                _fuel.FuelDecrease(0.2f);
              
            }
            _rototar.FixedTick(_leftRight); 
            
        }
        private void Update()
        {
            if (_input.IsForceUp &&!_fuel.IsEmpty)
            {
                _canForceUp = true;
            }
            else
            {
                _canForceUp = false;
                _fuel.FuelIncrease(0.01f);
                
            }
            _leftRight = _input.LeftRight;
        }
    }
}

