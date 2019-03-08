using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityWell : MonoBehaviour
{
    public float force = 1;

    void OnTriggerStay2D(Collider2D other)
    {
        other.attachedRigidbody.AddForce(Vector2.up * force);
    }
}