using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Bluegate : MonoBehaviour
{
    public GameObject Blue;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bluetoken"))
        {
            Destroy(Blue.transform.GetChild(0).GetChild(0).gameObject);
            Debug.Log("destroy");
        }
    }
}
