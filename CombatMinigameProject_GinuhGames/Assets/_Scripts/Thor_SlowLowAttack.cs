using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thor_SlowLowAttack : MonoBehaviour
{
    public ParticleSystem dust;
    public Animator thor_animator;
    public PlayerController playerController;
    private BoxCollider attackColl;

    // Start is called before the first frame update
    void Start()
    {
        attackColl = thor_animator.gameObject.GetComponentInChildren<BoxCollider>();
        attackColl.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "floor" && playerController._isAttacking)
        {
            Debug.Log("SlowLowAttack!");
            ActivateDust();
            attackColl.enabled = true;
        }     
    }

    private void OnTriggerExit(Collider other)
    {
        attackColl.enabled = false;

    }
    void ActivateDust()
    {
        dust.Play();
    }
}
