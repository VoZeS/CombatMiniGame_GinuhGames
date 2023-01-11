using System.Collections;
 using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PressKeyToStart : MonoBehaviour
{
    public GameObject text;
    public Animator cameraAnim;
    private bool pressKey;

    // Start is called before the first frame update
    void Start()
    {
        pressKey = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (text.activeInHierarchy && Keyboard.current.anyKey.wasPressedThisFrame)
        {
            pressKey = true;
            cameraAnim.SetTrigger("Start");
        }

        if (pressKey)
            text.SetActive(false);
    }
}
