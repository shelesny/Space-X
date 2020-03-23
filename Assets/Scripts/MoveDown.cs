using UnityEngine;
//Перемещение астероидов
public class MoveDown : MonoBehaviour
{
    [SerializeField]
    private float fallSpeed = 3f;

    void Update()
    {
        if (transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
        transform.position -= new Vector3(0, fallSpeed * Time.deltaTime, 0);
    }
}
