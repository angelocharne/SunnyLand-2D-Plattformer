using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformAttach : MonoBehaviour {

    public GameObject Player;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject == Player)
        {
            Player.transform.parent = transform;
        }
    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject == Player)
        {
            Player.transform.parent = null;
        }
    }
    


    
}








