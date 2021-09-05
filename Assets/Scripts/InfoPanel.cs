using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoPanel : MonoBehaviour
{
    [SerializeField]
    Text _titleText;

    [SerializeField]
    Text _infoText;

    [SerializeField]
    Text _animalText;

    [SerializeField]
    Image _animalImage;

    

    public void FillPanel(PanelTemplate info)
    {
        _titleText.text = info._titleText;
        _infoText.text = info._infoText;
        _animalText.text = info._animalText;
        _animalImage.sprite = info._animalSprite;



    }

}
