using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    float yDif;

    void Start()
    {
        yDif = transform.position.y - player.transform.position.y;
    }

    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y + yDif, transform.position.z);
    }
}