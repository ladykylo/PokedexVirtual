using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    public new string name;
    public string description;

    public Sprite type;
    

    public string peso;
    public string altura;
    public string habilidad;

    public Sprite shiny;

    public void Print()
    {
        Debug.Log(name + ":" + description);
    }

}
