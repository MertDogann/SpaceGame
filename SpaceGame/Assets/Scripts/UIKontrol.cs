using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIKontrol : MonoBehaviour
{
    [SerializeField] GameObject oyunAdi;
    [SerializeField] GameObject oyunBitti;
    [SerializeField] Text puanText;
    [SerializeField] GameObject playButton;
    int puan;
    // Start is called before the first frame update
    void Start()
    {
        oyunBitti.gameObject.SetActive(false);
        puanText.gameObject.SetActive(false);
    }
    public void OyunuBasladi()
    {
        puan = 0;
        playButton.gameObject.SetActive(false);
        oyunAdi.gameObject.SetActive(false);
        puanText.gameObject.SetActive(true);
        oyunBitti.gameObject.SetActive(false);
        PuaniGŁncelle();
    }
    public void OyunBitti()
    {
        playButton.gameObject.SetActive(true);
        oyunBitti.gameObject.SetActive(true);
    }
    void PuaniGŁncelle()
    {
        puanText.text = "Puan : " + puan.ToString();
    }
    public void AsteroidYokOldu(GameObject asteroid)
    {
        switch (asteroid.gameObject.name[8])
        {
            case '1':
                puan += 5;
                PuaniGŁncelle();
                break;
            case '2':
                puan += 10;
                PuaniGŁncelle();
                break;
            case '3':
                puan += 15;
                PuaniGŁncelle();
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
