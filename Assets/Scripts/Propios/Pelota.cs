using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public RigidbodyConstraints2D constrains;
    public float velocidadInicial;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(5);
        rb2d.constraints = constrains;
        rb2d.velocity = (new Vector2(Random.Range(-1f, 1f), 1f)).normalized*velocidadInicial;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Player"))
		{
            rb2d.velocity = (transform.position - collision.transform.position).normalized*velocidadInicial;
		}
	}
}
