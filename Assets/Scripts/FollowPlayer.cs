using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    private void Start()
    {
        offset = transform.position;
    }

    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
