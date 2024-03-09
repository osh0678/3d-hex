using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxObject : PlayerObject
{
    public Transform playerObject;
    public Transform cameraObject;
    public float distance = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 distanceToCamera = (cameraObject.position - playerObject.position).normalized;
        transform.position = playerObject.position + distanceToCamera * distance;
    }
    public void TakeDamage(int damage)
    {
        playerObject.GetComponent<PlayerHealth>().health -= damage;
        if (playerObject.GetComponent<PlayerHealth>().health <= 0)
        {
            Destroy(playerObject.gameObject);
        }
    }
}
