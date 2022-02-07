using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemiKontrol : MonoBehaviour
{
    const float hareketGucu = 10;
    [SerializeField] GameObject kursun;
    [SerializeField] GameObject patlamaPrefab;
    OyunKontrol oyunKontrol;
    // Start is called before the first frame update
    void Start()
    {
        oyunKontrol = Camera.main.GetComponent<OyunKontrol>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;

        float yatayInput = Input.GetAxis("Horizontal");
        float dikeyInput = Input.GetAxis("Vertical");

        if (yatayInput != 0)
        {
            position.x += yatayInput * hareketGucu * Time.deltaTime;
        }

        if (dikeyInput != 0)
        {
            position.y += dikeyInput * hareketGucu * Time.deltaTime;
        }

        transform.position = position;

        if (Input.GetButtonDown("Jump"))
        {
            GameObject.FindGameObjectWithTag("Audio").GetComponent<SesKontrol>().Ates();
            Vector3 kursunPosition = gameObject.transform.position;
            kursunPosition.y += 1;

            Instantiate(kursun, kursunPosition, Quaternion.identity);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Asteroid")
        {
            GameObject.FindGameObjectWithTag("Audio").GetComponent<SesKontrol>().GemiPatlama();
            Instantiate(patlamaPrefab, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
            oyunKontrol.OyunuBitir();
        }
        
    }
}
