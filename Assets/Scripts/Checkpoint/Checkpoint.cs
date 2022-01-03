
using UnityEngine;


public class Checkpoint : MonoBehaviour
{

    private GameMaster gm;

     void Start()
    {
        gm = GameMaster.instance;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gm.lastCheckPointPos = transform.position;
        }
    }

}
