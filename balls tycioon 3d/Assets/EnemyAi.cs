using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    public float health = 100f;
    // the enemy is not able to move
    public Renderer renderer;
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }
    // make a wait seconds coroutine
    IEnumerator TurnRed()
    {
        renderer.material.color = Color.red;
        yield return new WaitForSeconds(1f);
        renderer.material.color = Color.white;
    }

    void TakeDamage(float damage)
    {
        health -= damage;
        // become red for a short time
        StartCoroutine(TurnRed());

        
    }
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Sphere" || collision.gameObject.name == "Sphere(Clone)")
        {
            // take damage
            TakeDamage(10f);
            // destroy sphere
            Destroy(collision.gameObject);
        }
    }
}
