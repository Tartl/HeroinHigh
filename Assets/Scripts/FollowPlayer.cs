using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player; // Reference na hráèe
    public GameObject area; // Reference na objekt oblasti, ve které se hráè mùže pohybovat

    private Vector3 offset; // Odsazení kamery od hráèe
    private Collider2D playerCollider; // Collider hráèe

    void Start()
    {
        // Získejte referenci na hráèùv herní objekt
        GameObject playerObject = GameObject.Find("Player");

        // Pøidejte BoxCollider2D, pokud hráè nemá Collider2D
        if (playerObject != null && playerObject.GetComponent<Collider2D>() == null)
        {
            playerObject.AddComponent<BoxCollider2D>();
        }

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
            Debug.LogError("Chybí hráè!");
        }
    }

    void LateUpdate()
    {
        if (player != null && playerCollider != null)
        {
            // Nastaví pozici kamery tak, aby byla následována hráèem s offsetem
            Vector3 targetPosition = player.transform.position + offset;

            // Získá rozmìry kamery
            float cameraHeight = 2f * Camera.main.orthographicSize;
            float cameraWidth = cameraHeight * Camera.main.aspect;

            // Omezení pozice hráèe tak, aby zùstal uprostøed obrazovky
            float clampedX = Mathf.Clamp(targetPosition.x, transform.position.x - cameraWidth / 2f, transform.position.x + cameraWidth / 2f);
            float clampedY = Mathf.Clamp(targetPosition.y, transform.position.y - cameraHeight / 2f, transform.position.y + cameraHeight / 2f);
            targetPosition = new Vector3(clampedX, clampedY, targetPosition.z);

            // Aktualizace pozice kamery
            transform.position = targetPosition;
        }
    }
}
