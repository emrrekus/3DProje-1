using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Proje1.Inputs
{
    public class DInput
    {
        DefualtInput _�nput;

        public bool IsForceUp { get; private set; }
        public float LeftRight { get; private set; }

        public DInput()
        {
            _�nput = new DefualtInput();

            _�nput.Rocket.ForceUp.performed += context => IsForceUp = context.ReadValueAsButton();
            _�nput.Rocket.LeftRight.performed += context =>LeftRight = context.ReadValue<float>();

            _�nput.Enable();
        }
        

    }

}

