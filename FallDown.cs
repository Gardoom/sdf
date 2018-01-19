using UnityEngine;

public class FallDown : MonoBehaviour
{
    [SerializeField]
    private float fallSpead = 3f;
    public int score = 0;

    void Update()
    {
         if (transform.position.y < -6f)
         {
            score++;
			Destroy(gameObject);
         }
            
        transform.position -= new Vector3(0, fallSpead * Time.deltaTime, 0);
         GUI.Box(new Rect(0, 0, 100, 100), "Score = " + score);
    }
}
