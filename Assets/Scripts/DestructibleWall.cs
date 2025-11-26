using System;
using UnityEngine;

public class DestructibleWall : MonoBehaviour
{
    [SerializeField] GameObject wall;

    void OnCollisionEnter(Collision collision)
    {
        Destroy(wall);
    }
}
