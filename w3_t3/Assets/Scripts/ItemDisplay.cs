using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ItemDisplay : MonoBehaviour
{

    public ItemData data;
    public TMP_Text nameItem;
    public Image imgItem;
    // Start is called before the first frame update
    void Start()
    {
        nameItem.text = data._item.ToString();
        imgItem.sprite = data.spriteData;
    }

    
}
