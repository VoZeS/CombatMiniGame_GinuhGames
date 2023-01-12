using System.Collections;
 using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
{
    public Animator cameraAnim;
    public Animator panelAnim;

    public PlayerController player1Controller;
    public PlayerController player2Controller;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (Keyboard.current.anyKey.wasPressedThisFrame || Gamepad.current.enabled)
        {
            if (cameraAnim != null)
                cameraAnim.SetTrigger("Start");
        }

        if(player1Controller.Dead)
        {
            panelAnim.SetTrigger("EndGame");
            player1Controller._dead = !player1Controller._dead;
        }

        if (player2Controller.Dead)
        {
            panelAnim.SetTrigger("EndGame");
            player2Controller._dead = !player2Controller._dead;
        }

        if (Input.GetKey(KeyCode.R))
        {
            PlayerStart.nPLayers = 0;
            MovementController._playercount = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (Input.GetKey(KeyCode.Escape))
            Application.Quit();
    }
}
