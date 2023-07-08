using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBola : MonoBehaviour
{
    public float maxX;
    public float maxY;
    public Vector3 posicionInicial;
    public bool enJuego = true;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Inicio());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Inicio()
    {
        yield return new WaitForSeconds(2f);
        posicionInicial = transform.position;
        float x = 0;
        while (enJuego)
        {
            float bx=x;
            x = Random.Range(-1f, 1f);
            for (int i = 0; i <= 40; i++)
            {
                float angulo = Mathf.Lerp(0, Mathf.PI, i / 40f);
                transform.position = posicionInicial+ new Vector3(Mathf.Lerp(bx, x, (i / 40f))*maxX, Mathf.Sin(angulo)*maxY, 0);
                yield return new WaitForSeconds(1 / 40f);
            }
        }

    }
}
