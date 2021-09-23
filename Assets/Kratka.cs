using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Wybrane
{
    KRZYZYK,
    KOLKO
}

public class Kratka : MonoBehaviour
{
    public Sprite kolko, krzyzyk;
    Wybrane aktualnyWybor = Wybrane.KOLKO;

    SpriteRenderer sr;
    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    private void OnMouseDown()
    {
        if (aktualnyWybor == Wybrane.KOLKO)
        {
            sr.sprite = krzyzyk;
            aktualnyWybor = Wybrane.KRZYZYK;
        }
        else 
        {
            sr.sprite = kolko;
            aktualnyWybor = Wybrane.KOLKO;
        }
    }
}
