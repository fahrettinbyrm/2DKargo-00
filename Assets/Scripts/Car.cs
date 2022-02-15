using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Car : MonoBehaviour
{   //Main Car
    [SerializeField] private float yatayHareketHizi=1f;
    [SerializeField] private float dikeyHareketHizi=0.1f;

    [SerializeField] private float ekstraHiz=3;
    [SerializeField] private float normalHiz = 1;

 




    void Update()
    {
        float yatayAcisalHareket = Input.GetAxis("Horizontal")*yatayHareketHizi*Time.deltaTime;
        float dikeyHareket = Input.GetAxis("Vertical")*dikeyHareketHizi*Time.deltaTime;
        
        transform.Translate(0,dikeyHareket,0);
        transform.Rotate(0,0,- yatayAcisalHareket);
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost")
        {
            yatayHareketHizi = ekstraHiz;
        }

     
    }
}
