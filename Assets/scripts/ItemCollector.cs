using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{

    public int pineapples = 0;

    [SerializeField] private Text pineapplesText;
    

    [SerializeField] private AudioSource collectionSoundEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pineapple"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            pineapples++;
        //    Debug.Log("Pineapple: " + pineapples);
            pineapplesText.text = "Pineapple: " + pineapples;
        }

        
    }
}

