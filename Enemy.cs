using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float movementSpeed = 500;

    void Start()
    {

    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, -634, 0), movementSpeed * Time.deltaTime);
    }
}
