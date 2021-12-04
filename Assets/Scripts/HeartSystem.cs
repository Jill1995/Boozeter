using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HeartSystem : MonoBehaviour
{
    //public int lifeCount;
    //public int numOfHearts;

    public Image[] life;
    public Sprite fullLife;
    public Sprite emptyLife;

    void Update()
    {
  

    }

    public void ChangeSprite(int health)
    {
        
        for (int i = 0; i < life.Length; i++)
        {
            if (i < health)
            {
                life[i].sprite = fullLife;
                //Debug.Log(i);
            }
            else
            {
                life[i].sprite = emptyLife;
            }
        }
    }
}
