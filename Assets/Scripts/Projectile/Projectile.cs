using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float projectileSpeed = 20f;
    [SerializeField] float rotationSpeed = 10f;

    public List<GameObject> items = new List<GameObject>();
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.right * projectileSpeed;
        Debug.Log(rb.velocity);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<EnemyMovement>())
        {
            GameObject item = Instantiate(collision.gameObject.GetComponent<EnemyDeath>().scraps, collision.gameObject.transform.position, Quaternion.identity) as GameObject;
            items.Add(item);
            Debug.Log(items.Count);
            collision.gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
