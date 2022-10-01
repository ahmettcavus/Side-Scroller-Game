using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollecCoi : MonoBehaviour
{
    public int coinCount;
    public Text coinText;
    public Text coinText2;
    public Text coinText3;
    [SerializeField] private AudioClip coinSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Coin")
        {
            SoundManager.instance.PlaySound(coinSound);
            coinCount += 1;
            coinText.text = coinCount.ToString();
            coinText2.text = coinCount.ToString();
            coinText3.text = coinCount.ToString();
            Destroy(collision.gameObject);
        }
    }
}
