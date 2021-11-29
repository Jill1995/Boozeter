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

    //void Start()
    //{
    //    lifeCount = GetComponent<CollisionHandler>().health;
    //}

    //void Update()
    //{
    //    if(lifeCount > numOfHearts)
    //    {
    //        lifeCount = numOfHearts;
    //    }

    //    ChangeSprite();
       
    //}

    public void ChangeSprite(int x)
    {
        for (int i = 0; i < life.Length; i++)
        {
            if (i < x)
            {
                life[i].sprite = fullLife;
            }
            else
            {
                life[i].sprite = emptyLife;
            }


          /*  //if (i < numOfHearts)
            //{
            //    life[i].enabled = true;
            //}
            //else
            //{
            //    life[i].enabled = false;
            //}*/
        }
    }
}
