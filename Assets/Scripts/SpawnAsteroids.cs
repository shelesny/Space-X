using System.Collections;
using UnityEngine;
//Появление астероидов
public class SpawnAsteroids : MonoBehaviour
{
    public GameObject asteroid;
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (!Player.lose)
        {
            Instantiate(asteroid, new Vector2(Random.Range(-2.60f, 2.60f), 5.9f), Quaternion.identity);
            yield return new WaitForSeconds(0.8f);
        }
    }

}
