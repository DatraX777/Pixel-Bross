using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chest : MonoBehaviour
{
    private Animator anim;
    private Collider2D coll;
    [SerializeField] private Text openText;
    [SerializeField] private Text Objet;
    
    private bool proxi = false;

    private int rare = 0;

    private void Start()
    {
        anim = GetComponent<Animator>();
        coll = GetComponent<Collider2D>();
    }

    

    private void Update()
    {
        if(Input.GetButtonDown("Fire1") && proxi)
            {
                anim.SetTrigger("ouvrir");
                openText.text = "Vous avez trouvé un truc rare mais vous ne savez pas ce que c'est!!?";
                rare++;
                Objet.text = "Truc rare :" + rare;
                Erase();
            }
    }

    private void OnTriggerEnter2D(Collider2D  collision) {
        if(collision.gameObject.CompareTag("Player"))
        {
            openText.text = "E (Open)";
            proxi = true;
            
        }
        
    } 

    private void OnTriggerExit2D(Collider2D collision)
    {
        openText.text = "";
        proxi = false;
        
        
    }

    private void Erase()
    {
        Destroy(coll);
    }
}
