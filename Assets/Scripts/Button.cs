using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public GameObject UI;

    // Start is called before the first frame update
    void Start()
    {
        UI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

   public void TogglePause() 
   {
        Time.timeScale = Mathf.Approximately(Time.timeScale, 0.0f) ? 1.0f : 0.0f;

        UI.SetActive(true);
   }

    public void OnClickButton(string choice)
    {
        if (choice == "Resume Game")
        {
            UI.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
