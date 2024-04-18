using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float timer;
    void Update()
    {
        //Time.deltaTime = 1 / FPS

    }

    private void FixedUpdate()
    {
        timer += 1.5f * Time.fixedDeltaTime;
        print(timer);
    }
}
