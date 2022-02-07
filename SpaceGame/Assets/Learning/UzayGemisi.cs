using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UzayGemisi 
{
    /// <summary>
    /// Geminin maksimum hýzýný verir.
    /// </summary>
    int maksimumHiz;

    /// <summary>
    /// Geminin rengini verir.
    /// </summary>
    string renk;

    /// <summary>
    /// Geminin maksimum hýzýný döner.
    /// </summary>
    public int MaksimumHiz
    {
        get { return maksimumHiz; }
    }
    /// <summary>
    /// Geminin rengini döner.
    /// </summary>
    public string Renk
    {
        get { return renk; }
    }

    /// <summary>
    /// maksimum hýz ve rengini verir.
    /// </summary>
    /// <param name="maksimumHiz"></param>
    /// <param name="renk"></param>
    public UzayGemisi(int maksimumHiz, string renk)
    {
        this.maksimumHiz = maksimumHiz;
        this.renk = renk;
    }
    /// <summary>
    /// Geminin maksimum hýzýný verir.
    /// </summary>
    /// <param name="maksimumHiz"></param>
    public UzayGemisi(int maksimumHiz)
    {
        this.maksimumHiz = maksimumHiz;
    }
    /// <summary>
    /// Gemiyi hizlandýrýr.
    /// </summary>
    public void Hizlandirici()
    {
        maksimumHiz += Random.Range(5, 20);
        Debug.Log(maksimumHiz);
    }
    /// <summary>
    /// Gemiyi yavaþlatir.
    /// </summary>
    public void Yavaslatici()
    {
        maksimumHiz -= Random.Range(5, 10);
        Debug.Log(maksimumHiz);
    }
}
