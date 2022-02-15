using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] private Color32 ilkRenk;
    [SerializeField] private Color32 teslimatRengi;
    
    //Game Event
    [SerializeField] private bool paketAlindiMi = false;


    private SpriteRenderer _spriteRenderer;
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }


   
    
    private void OnTriggerEnter2D(Collider2D other)
    {  
        // Paket alındıktan sonraki olay kurguları
        if (other.tag == "Package" && !paketAlindiMi)
        {
            Debug.Log("Paket Alındı..");
            Destroy(other.gameObject);
            paketAlindiMi = true;
            _spriteRenderer.color = teslimatRengi;
        }
        // Paket teslim edildikten sonraki olay kurguları
        if (other.tag == "Delivery Point" && paketAlindiMi)
        {
            Debug.Log("Paket Teslim Edildi");
            other.GetComponent<SpriteRenderer>().color=Color.white;
            paketAlindiMi = false;
            _spriteRenderer.color = ilkRenk;


        }
    }
}
