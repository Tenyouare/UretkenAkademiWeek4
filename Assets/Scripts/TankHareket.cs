using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankHareket : MonoBehaviour
{
    
    public float speed = 5.0f;
    private void Hareket()
    {
        Vector3 hareket = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));


        Vector3 hizEklentisi = hareket * Time.deltaTime * speed;
        transform.Translate(hizEklentisi);

        
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Hareket();
    }
}
