using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour

{

    [SerializeField] private Text coinText;

    [SerializeField] private AudioSource collectionSoundEffect;


    private int coins = 0;


    private void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            coins++;
            coinText.text = "Coins" + coins;
        }
    }
}