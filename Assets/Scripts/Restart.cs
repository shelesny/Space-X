using UnityEngine;
using UnityEngine.SceneManagement;
//Рестарт игры
public class Restart : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("main");
    }
}
