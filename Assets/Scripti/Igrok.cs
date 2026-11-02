using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Igrok : MonoBehaviour
{
    public int points;

    public SharikStrelyaushi projectilePrefab;
    public Transform shootPoint;

    public float shootInterval = 0.3f;
    private float shootTimer = 0f;

    void Update()
    {
        Move();
        Shoot();
    }

    void Move()
    {
        // Движение за мышью БЕЗ нажатия кнопки (если хочешь только при нажатии — добавь if)
        Vector2 mousePos = Input.mousePosition;
        Vector3 realPos = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = new Vector3(realPos.x, realPos.y, 0f);
    }

    void Shoot()
    {
        shootTimer -= Time.deltaTime;

        if (shootTimer <= 0f)
        {
            if (projectilePrefab != null && shootPoint != null)
            {
                Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            }
            shootTimer = shootInterval;
        }
    }
}