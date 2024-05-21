using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limitchildren : MonoBehaviour
{
    public int childmax = 1;

    private void Update()
    {
        if (transform.childCount > childmax)
        {
            for (int i = childmax; i < transform.childCount; i++)
            {
                transform.GetChild(i).SetParent(null);
            }
        }
    }
}
