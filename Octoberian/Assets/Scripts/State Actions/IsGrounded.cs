using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{
    [CreateAssetMenu(menuName = "Actions/State Actions/Is Grounded")]
    public class IsGrounded : StateActions
    {
        
        public override void Execute(StateManager states)
        {
            //sets the origin point of the ray
            Vector3 origin = states.mTransform.position;
            origin.y += .7f;
            //sets the direction od the ray
            Vector3 dir = -Vector3.up;
            //sets the distance that the maximum ray will travel
            float dis = 1.4f;

            RaycastHit hit;
            //if the ray hits something
            if(Physics.Raycast(origin, dir, out hit, dis))
            {
                states.isGrounded = true;
            }
            else{
                states.isGrounded = false;
            }
            states.anim.SetBool(states.hashes.isGrounded, states.isGrounded);
        }
    }
}