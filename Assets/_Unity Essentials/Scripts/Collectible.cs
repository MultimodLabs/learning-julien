using UnityEngine;

public class Collectible : MonoBehaviour
{
    [Range(0f, 1f)]
    public float rotationSpeed;
    
    public GameObject onCollectEffect;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0);
    }
    
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            Debug.Log("Contact avec le joueur");
            Destroy(gameObject);
            Instantiate(onCollectEffect, transform.position, transform.rotation);
        } else {
            Debug.Log("Contact avec un autre objet: " + other.tag);
            return;
        }

    }
}
