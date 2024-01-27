using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float speed;
    public GameObject centre;
    private void Start()
    {
        speed = 150f;
    }
    private void FixedUpdate()
    {
        transform.Rotate(0, 0, speed * Time.fixedDeltaTime);
    }
    public void Click()
    {
        speed = -speed;
    }
}