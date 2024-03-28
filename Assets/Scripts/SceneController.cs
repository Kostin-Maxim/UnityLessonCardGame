using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] MemoryCard originalCard;
    [SerializeField] Sprite[] images;
    void Start()
    {
        int id = Random.Range(0, images.Length);
        originalCard.SetCard(id, images[id]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
