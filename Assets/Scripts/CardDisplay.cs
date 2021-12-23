using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card card;

    public Text nameText;
    public Text descriptionText;

    public Image typeImage;
    

    public Text pesoText;
    public Text alturaText;
    public Text habilidadText;

    public Image shinyImage;

    void Start()
    {
        nameText.text = card.name;
        descriptionText.text = card.description;

        typeImage.sprite = card.type;
        

        pesoText.text = card.peso;
        alturaText.text = card.altura;
        habilidadText.text = card.habilidad;

        shinyImage.sprite = card.shiny;
    }

}
