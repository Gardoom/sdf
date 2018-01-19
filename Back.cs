using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{

    void OnMouseDown()
    {
        SceneManager.LoadScene("Golova");
    }
}
