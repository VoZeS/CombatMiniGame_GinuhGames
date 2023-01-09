using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thor_SlowLowAttack : MonoBehaviour
{
    public ParticleSystem dust;
    public Animator thor_animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "floor" && thor_animator.GetInteger("ThorController") == 0)
        {
            Debug.Log("SlowLowAttack!");
            ActivateDust();
        }     
    }
    void ActivateDust()
    {
        dust.Play();
    }
}
