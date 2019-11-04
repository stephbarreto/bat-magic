using UnityEngine;

public class Enemy : MonoBehaviour {
    public Score score;
    public GameObject explosion;
    public int hitPoints = 1;
    public int scorePoints = 0;

    public void OnTriggerEnter2D(Collider2D collision) {

        if(collision.GetComponent<Nave>()) {}
            // if(hitPoints > 1) {
            //     hitPoints --;
            //     return;
            // }
        if(collision.tag == "Point")
        {

            Score.Instance.UpdateScore(scorePoints);

            GameObject boom = Instantiate(explosion, transform.position, transform.rotation);

            Destroy(boom, 3);
            Destroy(gameObject);
        }
        else{
          Destroy (gameObject);
        }
    }

	}
