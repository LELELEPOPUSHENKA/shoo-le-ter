using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharikStrelyaushi : MonoBehaviour
{
    public float speed = 10f;
    public GameObject explosion;

    void Start()
    {
        Destroy(gameObject, 2f);
    }

    void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pripyatstvie"))
        {
            if (explosion != null)
            {
                GameObject effect = Instantiate(explosion, transform.position, transform.rotation);
                Destroy(effect, 2f);
            }
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}