using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Utilities;

public class quitApp : MonoBehaviour
{
    // Update is called once per frame

    void Start()
    {
        Screen.sleepTimeout = (int)SleepTimeout.NeverSleep;
    }

    public void quit()
    {
        Application.Quit();
    }

    void Update()
    {
        InputSystem.onAnyButtonPress.Call(
        button =>
        {
            if (button is KeyControl key)
            {
                if (key.name == "escape")
                {
                    Application.Quit();
                }
            }
        });
    }
}
