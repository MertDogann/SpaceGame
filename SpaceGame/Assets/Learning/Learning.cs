using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learning : MonoBehaviour
{
    //int saldiranDusman =10;
    //bool saldiriDevam = false;
    // Start is called before the first frame update
    void Start()
    {
        UzayGemisi gemi1 = new UzayGemisi(Random.Range(40, 80));
        UzayGemisi gemi2 = new UzayGemisi(Random.Range(40, 80), "Mavi");
        gemi1.Hizlandirici();
        gemi2.Hizlandirici();
        gemi1.Yavaslatici();
        gemi2.Yavaslatici();
        
        if (gemi1.MaksimumHiz > gemi2.MaksimumHiz)
        {
            Debug.Log("Gemi 1 kazand�.");
        }else { Debug.Log("Gemi 2. kazand�"); }

        //while (saldiriDevam)
        //{
        //    saldiranDusman--;
        //    if (saldiranDusman < 3)
        //    {
        //        saldiriDevam = false;
        //    }
        //    Debug.Log("Sald�r� alt�nday�z. D��man say�s� : " + saldiranDusman);
        //}
        //do
        //{
        //    saldiranDusman--;
        //    if (saldiranDusman < 3)
        //    {
        //        saldiriDevam = false;
        //    }
        //    Debug.Log("Sald�r� alt�nday�z. D��man say�s� : " + saldiranDusman);
        //} while (saldiriDevam);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
