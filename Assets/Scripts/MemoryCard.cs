using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCard : MonoBehaviour
{
    [SerializeField] GameObject cardBack;
    [SerializeField] SceneController controller;

    private int _id;
    public int Id
    {
        get => _id;
    }

    public void SetCard(int id, Sprite image)
    { 
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image;
    }

    private void OnMouseDown()
    {
        if(cardBack.activeSelf)
        { 
            cardBack.SetActive(false); 
        }
    }
}
