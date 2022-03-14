using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKiller : MonoBehaviour
{
    private Animator anim;
    private Collider2D coll;


private void Start()
    {
        anim = GetComponent<Animator>();
        coll = GetComponent<Collider2D>();
    }

    [SerializeField] private AudioSource deathSoundEffect;
    private void OnTriggerEnter2D(Collider2D  collision) {
        if(collision.gameObject.CompareTag("Player"))
        {
            Die();
        }
    } 

    private void Die()
    {
        deathSoundEffect.Play();
        Destroy(coll);
        anim.SetTrigger("death");
    }

    private void Erase()
    {
        Destroy(gameObject);
    }
}
