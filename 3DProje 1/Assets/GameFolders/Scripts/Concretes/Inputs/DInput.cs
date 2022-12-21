using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Proje1.Inputs
{
    public class DInput
    {
        DefualtInput _ýnput;

        public bool IsForceUp { get; private set; }
        public float LeftRight { get; private set; }

        public DInput()
        {
            _ýnput = new DefualtInput();

            _ýnput.Rocket.ForceUp.performed += context => IsForceUp = context.ReadValueAsButton();
            _ýnput.Rocket.LeftRight.performed += context =>LeftRight = context.ReadValue<float>();

            _ýnput.Enable();
        }
        

    }

}

