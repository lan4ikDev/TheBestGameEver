using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float speed;
    public float lifetime;
    public float damage = 10;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DesctroyFireball", lifetime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveFixedUpdate();
    }

    private void OnCollisionEnter(Collision collision)
    {
        DamageEnemy(collision);
        DesctroyFireball();
    }

    private void MoveFixedUpdate()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    private void DesctroyFireball()
    {
        Destroy(gameObject);
    }

    private void DamageEnemy(Collision collision)
    {
        var enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
        if (enemyHealth != null)
        {
            enemyHealth.DealDamage(damage);
        }
    }

}
