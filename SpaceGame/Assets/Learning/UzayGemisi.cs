using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UzayGemisi 
{
    /// <summary>
    /// Geminin maksimum h�z�n� verir.
    /// </summary>
    int maksimumHiz;

    /// <summary>
    /// Geminin rengini verir.
    /// </summary>
    string renk;

    /// <summary>
    /// Geminin maksimum h�z�n� d�ner.
    /// </summary>
    public int MaksimumHiz
    {
        get { return maksimumHiz; }
    }
    /// <summary>
    /// Geminin rengini d�ner.
    /// </summary>
    public string Renk
    {
        get { return renk; }
    }

    /// <summary>
    /// maksimum h�z ve rengini verir.
    /// </summary>
    /// <param name="maksimumHiz"></param>
    /// <param name="renk"></param>
    public UzayGemisi(int maksimumHiz, string renk)
    {
        this.maksimumHiz = maksimumHiz;
        this.renk = renk;
    }
    /// <summary>
    /// Geminin maksimum h�z�n� verir.
    /// </summary>
    /// <param name="maksimumHiz"></param>
    public UzayGemisi(int maksimumHiz)
    {
        this.maksimumHiz = maksimumHiz;
    }
    /// <summary>
    /// Gemiyi hizland�r�r.
    /// </summary>
    public void Hizlandirici()
    {
        maksimumHiz += Random.Range(5, 20);
        Debug.Log(maksimumHiz);
    }
    /// <summary>
    /// Gemiyi yava�latir.
    /// </summary>
    public void Yavaslatici()
    {
        maksimumHiz -= Random.Range(5, 10);
        Debug.Log(maksimumHiz);
    }
}
