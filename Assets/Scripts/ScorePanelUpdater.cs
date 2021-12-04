using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePanelUpdater : MonoBehaviour
{

    Text score;
    CollisionHandler ch;

    private void Start()
    {
        GameObject go = GameObject.Find("rocket");
        if (go == null)
        {
            Debug.LogError("Failed to find an object named 'GameStatus'");
            return;
        }

         ch = go.GetComponent<CollisionHandler>();
    }
    private void Update()
    {
        

        GetComponent<Text>().text = "Lives Remaining: " + ch.lifeCount.value;

    }
 
}
