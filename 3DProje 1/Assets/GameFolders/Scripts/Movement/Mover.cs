using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Proje1.Movements
{
    public class Mover
    {
        Rigidbody _rb;

        public Mover(Rigidbody rb)
        {
            _rb = rb;
        }
        public void FixedTick()
        {
            _rb.AddRelativeForce(Vector3.up*Time.deltaTime*750f);

        }

    }

}

