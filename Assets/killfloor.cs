using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killfloor : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawn_point;

    private void OnTriggerEnter(Collider other)
    {
        player.transform.position =respawn_point.position;

    }
}

