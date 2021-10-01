using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class NG : MonoBehaviour
{
    public Button newButton;

    // Start is called before the first frame update
    void Start()
    {
        Button Clickbutton = newButton.GetComponent<Button>();
        Clickbutton.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        Debug.Log("New Game Pressed.");
    }

    void Update()
    {
        
    }


}
