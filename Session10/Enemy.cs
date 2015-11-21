using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public GameObject waypoints;
    public float speed = 0.1f;

    private int cur = 0;
    private AudioSource sound01;
    private AudioSource sound02;

    void Awake()
    {
        AudioSource[] audioSources = GetComponents<AudioSource>();
        sound01 = audioSources[0];
        sound02 = audioSources[1];
    }
    
    void FixedUpdate()
    {
        Transform child = waypoints.transform.GetChild(cur);
        if (transform.position != child.position)
        {
            Vector2 p = Vector2.MoveTowards(transform.position,
                                            child.position,
                                            speed);
            GetComponent<Rigidbody2D>().MovePosition(p);
        }
        else cur = (cur + 1) % waypoints.transform.childCount;
    }

    public void EnemyDamage()
    {
        sound01.PlayOneShot(sound01.clip); ///敵ダメージ

    }

    public void EnemyDie()
    {
        sound02.PlayOneShot(sound02.clip); //敵死亡
    }
}
