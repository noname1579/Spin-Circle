using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : MonoBehaviour
{
    public GameObject effect;
    public GameObject pl;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(pl);
            Instantiate(effect, transform.position, Quaternion.identity);
        }
    }
}
