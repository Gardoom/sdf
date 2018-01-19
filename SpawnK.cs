using System.Collections;
using UnityEngine;

public class SpawnK : MonoBehaviour
{
   
    public GameObject K;
    void Start()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
         while (!Player.lose)
		{
            Instantiate(K, new Vector2(Random.Range(-3f, 3f), 5.6f), Quaternion.identity);

            yield return new WaitForSeconds(1f);
        }
    }

     /* void OnTriggerEnter2D(Collider2D col)
      {
          if (col.GetComponent<PolygonCollider2D>().tag == "K")
          {
              score++;
          }
      }


      private void OnGUI()
      {
         
      }
     */
}