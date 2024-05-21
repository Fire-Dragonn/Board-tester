using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public SpriteRenderer square;

    public bool isredturn = true;
    public bool isblueturn = false;

    public void Update () 
    {
        if (isredturn == true)
        {
            //isredturn = true;
            square.color = Color.red; 
        }
        else
        {
            square.color = Color.blue;
        }
        
        if (isblueturn == true)
        {
            //isblueturn = true;
            square.color = Color.blue;
        }
        else
        {
            square.color = Color.red;
        }
    }
}
