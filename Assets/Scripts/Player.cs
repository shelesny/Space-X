using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public GameObject lose_restart;
    public static bool lose = false;

    void Awake()
    {
        lose = false;
    }
//Проверка на столкновение с астероидом
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Asteroid")
        {
            lose = true;
            lose_restart.SetActive(true);
        }
    }
}
