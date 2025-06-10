using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bol : MonoBehaviour
{
    [SerializeField]
    ParticleSystem feedBackEtoile;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("1");
        if (collision.gameObject.tag == "Carotte")
        {
            Debug.Log("2");

            feedBackEtoile.Play();
            GameManager.Instance.WinRoom();
        }
        else
        {
            Debug.Log(collision.gameObject.tag);
        }
          
        }
}
