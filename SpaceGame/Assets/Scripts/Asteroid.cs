using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField] GameObject patlamaPrefab;
    OyunKontrol oyunKontrol;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D myRgdbdy2 = GetComponent<Rigidbody2D>();
        oyunKontrol = Camera.main.GetComponent<OyunKontrol>();
        float yon = Random.Range(0f, 1f);
        if (yon < 0.5f)
        {
            myRgdbdy2.AddForce(new Vector2(Random.Range(-3f, -1f), Random.Range(-1.5f,- 3f)), ForceMode2D.Impulse);
            myRgdbdy2.AddTorque(yon * 8f);
        }else
        {
            myRgdbdy2.AddForce(new Vector2(Random.Range(1.5f, 3f), Random.Range(1.5f, 3f)), ForceMode2D.Impulse);
            myRgdbdy2.AddTorque(-yon * 8f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject.FindGameObjectWithTag("Audio").GetComponent<SesKontrol>().AsteroidPatlama();

        if (collision.tag == "Kursun")
        {
            
            oyunKontrol.AsteroidYokOldu(gameObject);
            AsteroidYokEt();
        }
    }
    public void AsteroidYokEt()
    {
        Instantiate(patlamaPrefab, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    
}
