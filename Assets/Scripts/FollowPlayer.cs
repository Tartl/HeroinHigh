using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player; // Reference na hráèe
    public GameObject area; // Reference na objekt oblasti, ve které se hráè mùže pohybovat

    private Vector3 offset; // Odsazení kamery od hráèe
    private Collider2D playerCollider; // Collider hráèe
    private Collider2D areaCollider; // Collider oblasti

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

        if (area != null)
        {
            // Získá Collider2D z oblasti
            areaCollider = area.GetComponent<Collider2D>();
            if (areaCollider == null)
            {
                Debug.LogError("Chybí Collider2D na objektu oblasti!");
            }
        }
        else
        {
            Debug.LogError("Objekt oblasti není pøiøazen!");
        }
    }

    void LateUpdate()
    {
        if (player != null && playerCollider != null && area != null && areaCollider != null)
        {
            // Nastaví pozici kamery tak, aby byla následována hráèem s offsetem
            Vector3 targetPosition = player.transform.position + offset;

            // Omezení pozice kamery tak, aby zùstala uvnitø okrajù oblasti
            Vector3 clampedPosition = new Vector3(
                Mathf.Clamp(targetPosition.x, areaCollider.bounds.min.x, areaCollider.bounds.max.x),
                Mathf.Clamp(targetPosition.y, areaCollider.bounds.min.y, areaCollider.bounds.max.y),
                transform.position.z // Zachovává stávající z pozice z
            );

            // Aktualizace pozice kamery
            transform.position = clampedPosition;
        }
    }
}
