using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carpma : MonoBehaviour
{


    /*
    private void OnCollisionEnter(Collision col)
    {
        print(col.gameObject.name + "e �arpt�");
    }
    */

    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name + "ile temas ger�ekle�ti");
    }
}
