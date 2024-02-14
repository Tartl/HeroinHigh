using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player; // Reference na hráèe
    public EdgeCollider2D edgeCollider; // EdgeCollider2D oblasti, ve které se hráè mùže pohybovat

    private Vector3 offset; // Odsazení kamery od hráèe
    private Collider2D playerCollider; // Collider hráèe

    void Start()
    {
        if (player != null)
        {
            // Vypoèítá offset kamery od hráèe
            offset = transform.position - player.transform.position;

            // Získá Collider2D z hráèe
            playerCollider = player.GetComponent<Collider2D>();
            if (playerCollider == null)
            {
                Debug.LogError("Chybí Collider2D na hráèi!");
            }
        }
        else
        {
            Debug.LogError("Hráè není pøiøazen!");
        }

        if (edgeCollider == null)
        {
            Debug.LogError("EdgeCollider není pøiøazen!");
        }
    }

    void LateUpdate()
    {
        if (player != null && playerCollider != null && edgeCollider != null)
        {
            // Nastaví pozici kamery tak, aby byla následována hráèem s offsetem
            Vector3 targetPosition = player.transform.position + offset;

            // Získání rozmìrù oblasti, ve které se mùže hráè pohybovat
            float areaWidth = edgeCollider.bounds.size.x;
            float areaHeight = edgeCollider.bounds.size.y;

            // Získání rozmìrù kamery
            float cameraHeight = Camera.main.orthographicSize * 2;
            float cameraWidth = cameraHeight * Camera.main.aspect;

            // Omezení pozice hráèe tak, aby zùstal ve støedu oblasti
            float clampedX = Mathf.Clamp(targetPosition.x, edgeCollider.bounds.min.x + cameraWidth / 2, edgeCollider.bounds.max.x - cameraWidth / 2);
            float clampedY = Mathf.Clamp(targetPosition.y, edgeCollider.bounds.min.y + cameraHeight / 2, edgeCollider.bounds.max.y - cameraHeight / 2);

            // Aktualizace pozice kamery
            transform.position = new Vector3(clampedX, clampedY, transform.position.z);
        }
    }
}

