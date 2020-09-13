using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaBox : MonoBehaviour
{
    public Sprite PortaAberta;

    // Start is called before the first frame update
    void Start()
    {

    }
 
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<BoxCollider2D>().enabled = false;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = PortaAberta;
            SoundManager.PlaySound("portaabrindo");
        }
    }
     // Update is called once per frame
    void Update()
    {
        
    }
}
