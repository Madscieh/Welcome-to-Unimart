using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickPickup : MonoBehaviour
{
    public GameObject stick;
    public GameObject stickPickup;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(stickPickup);
            stick.SetActive(true);
        }

    }
}
