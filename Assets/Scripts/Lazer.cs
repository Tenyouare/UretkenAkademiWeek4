using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer : MonoBehaviour
{
    RaycastHit hit;
    void Update()
    {
        if (Physics.Raycast(transform.position,transform.forward, out hit,Mathf.Infinity))
        {
            print(hit.collider.gameObject);
        }
    }
}
