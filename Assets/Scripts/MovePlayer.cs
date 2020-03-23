using UnityEngine;
//Возможность перемещения игрока
public class MovePlayer : MonoBehaviour
{
    public Transform player;
    [SerializeField]
    private float speed = 10f;
    void OnMouseDrag()
    {
        if (!Player.lose)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.x = mousePos.x > 2.20f ? 2.20f : mousePos.x;
            mousePos.x = mousePos.x < -2.20f ? -2.20f : mousePos.x;
            player.position = Vector2.MoveTowards(player.position, new Vector2(mousePos.x, player.position.y), speed * Time.deltaTime);
        }     
    }
}
