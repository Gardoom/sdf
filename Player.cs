using UnityEngine;


public class Player : MonoBehaviour {

     public GameObject restart;
     public GameObject back;
    public static bool lose = false;

    void Awake()
     {
         lose = false;
     }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "K") { 
            lose = true;
            restart.SetActive(true);
            back.SetActive(true);
        }
}

}
