using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tasi : MonoBehaviour
{
    Camera kamera;
    Vector2 baslangic_poziyonu;
   // GameObject[] kutu_dizisi= { };

    private void OnMouseDrag()
    {
        Vector3 pozisyon = kamera.ScreenToWorldPoint(Input.mousePosition);
        pozisyon.z = 0;
        transform.position = pozisyon;
    }
    void Start()
    {
        kamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        baslangic_poziyonu = transform.position;
       // kutu_dizisi = GameObject.FindGameObjectWithTag("kutu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
