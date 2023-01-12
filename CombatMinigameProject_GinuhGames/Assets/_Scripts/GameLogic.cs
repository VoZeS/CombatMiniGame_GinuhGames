using System.Collections;
 using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
{
    public Text win_P1;
    public Text win_P2;

    public int wins_P1;
    public int wins_P2;

    public Animator cameraAnim;
    public Animator panelAnim;

    public PlayerController player1Controller;
    public PlayerController player2Controller;

    // Start is called before the first frame update
    void Start()
    {
        wins_P1 = 0;
        wins_P2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        win_P1.text = PlayerPrefs.GetInt("wins_P1").ToString();
        win_P2.text = PlayerPrefs.GetInt("wins_P2").ToString();

        if (Keyboard.current.anyKey.wasPressedThisFrame || Gamepad.current.enabled)
        {
            cameraAnim.SetTrigger("Start");
        }

        if(player1Controller.Dead)
        {
            wins_P1++;
            PlayerPrefs.SetInt("wins_P1", wins_P1);
            panelAnim.SetTrigger("EndGame");
            player1Controller._dead = !player1Controller._dead;
        }

        if (player2Controller.Dead)
        {
            wins_P2++;
            PlayerPrefs.SetInt("wins_P2", wins_P2);
            panelAnim.SetTrigger("EndGame");
            player2Controller._dead = !player2Controller._dead;
        }

        //if(InputAction.CallbackContext)
        //    SceneManager.LoadScene(SceneManager.GetActiveScene().name);


        PlayerPrefs.Save();

    }
}
