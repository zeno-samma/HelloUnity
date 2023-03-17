using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Qua bong da va cham voi gia do");        
        }
        if (collision.gameObject.CompareTag("DeathZone"))
        {
            Debug.Log("Qua bong da va cham voi deathzone");
        }
    }
}
