using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NamluSc : MonoBehaviour
{
    RaycastHit hit;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward,Color.red);
        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(Camera.main.transform.position, transform.forward, out hit, Mathf.Infinity))
            {
                if (hit.collider.gameObject.tag == "dusman")
                {
                    Destroy(hit.collider.gameObject);
                    print(hit.collider.gameObject.name + " yok edildi");
                }
            }
        }
       
        
        
    }



}
