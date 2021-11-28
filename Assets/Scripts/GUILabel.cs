using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUILabel : MonoBehaviour
{
    Text instructions;

    void Start()
    {
        instructions = GetComponent<Text>();
        instructions.text = "Get This Drunk Rocket Across! " + "\nSpace to boost, AD to move right/left.";
        instructions.fontSize = 40;
        instructions.color = Color.magenta;

        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            Time.timeScale = 1;
            Destroy(instructions);
        }
    }

}
