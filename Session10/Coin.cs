using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

    public int speed = 2;
    private static int count = 0;

    void Start ()
    {
        GetComponent<Rigidbody2D>().velocity = transform.right.normalized * speed;
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "DamageObject")
        {
            FindObjectOfType<Enemy>().EnemyDamage();
            if (++count >= 6)
            {
                FindObjectOfType<Enemy>().EnemyDie();
                Destroy(other.gameObject, 0.3f);
            }
            Destroy(this.gameObject);
        }
    }
}
