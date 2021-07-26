using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player;

    public float speedH = 2f;
    public float speedV = 2f;
    public Vector3 distance;

  

    void Start()
    {
        distance = transform.position - player.transform.position;
    }

    void Update()
    {
        transform.position = player.transform.position + distance;

    }
}
