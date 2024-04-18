using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float xRotation = 0.0f;
    public float mouseSensitivity = 100f;
    public GameObject oyuncu;
    

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensitivity;

        xRotation -= mouseY;
        /*bu þu demek mouse x ekseninde hareket ediyorsa y ekseni sabit 
         * kalýr ve onun etrafýnda döner tank namlusu sag sol yaparken
         *sabit kalan eksen y dir ama onun etrafýnda döner yukarý ve 
         *asagý hareket ettirirken de x ekseninde döner
         */

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0.0f, 0.0f);
        oyuncu.transform.Rotate(Vector3.up*mouseX);


        
    }
}
