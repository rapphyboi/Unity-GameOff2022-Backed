using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scraps : MonoBehaviour
{
    [SerializeField] int numberOfScraps = 1;
    [SerializeField] float animationDelay = 1f;
    [SerializeField] float thurstForce = 5f;
    [SerializeField] float transferSpeed = 10f;
    Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        StartCoroutine(SpawnAnimation());
    }

    IEnumerator SpawnAnimation()
    {
        rb.AddForce(transform.up * thurstForce, ForceMode2D.Impulse);
        yield return new WaitForSeconds(animationDelay);
        rb.gravityScale = 0;
        rb.velocity = Vector3.zero;
        StartCoroutine(GoToPlayer());
    }

    IEnumerator GoToPlayer()
    {
        if (!FindObjectOfType<Player>())
        {

        }
        while (true)
        {
            transform.position = Vector3.MoveTowards(transform.position, FindObjectOfType<Player>().transform.position, transferSpeed * Time.deltaTime);
            yield return null;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>())
        {
            StopAllCoroutines();
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        FindObjectOfType<Currency>().AddCurrency();
    }
}
