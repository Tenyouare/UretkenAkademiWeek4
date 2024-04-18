using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindWithTag : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("ozel").SetActive(false);
        GameObject.FindGameObjectWithTag("ozel2").GetComponent<Light>().intensity = 0;
        GameObject.Find("Kapsul2").SetActive(false);
    }


}
