using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{
    public class StateManager : MonoBehaviour
    {
        public float health;
        
        public State currentState;
        public MovementVariables movementVariables;


        [HideInInspector]
        public new Rigidbody rigidbody;
        [HideInInspector]
        public float delta;
        [HideInInspector]
        public Transform mTransform;
        [HideInInspector]
        public Animator anim;
        [HideInInspector]
        public AnimHashes hashes;

        private void Start()
        {
            mTransform = this.transform;
            rigidbody = GetComponent<Rigidbody>();
            anim = GetComponentInChildren<Animator>();
            hashes = new AnimHashes();
        }

        private void Update()
        {
            delta = Time.deltaTime;
            if(currentState != null)
            {
                currentState.Tick(this);
            }
        }
        private void FixedUpdate()
        {
            delta = Time.fixedDeltaTime;
            if(currentState != null)
            {
                currentState.FixedTick(this);
            }
        }
    }
}
