using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


namespace AGIA
{ 
public class DoWaveAnimation : MonoBehaviour
    {
        public Animator animator;
        public int animBase;
        public int animLayer;

	    // Use this for initialization
	    void Start ()
        {

            animator = GetComponent<Animator>();
			animator.SetInteger("animBaseInt", 0);
            animator.SetInteger("animOtherInt", 2);
        }
	
	    // Update is called once per frame
	    void Update ()
        {
		
	    }

        
    }
}
