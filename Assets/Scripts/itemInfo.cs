using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemInfo : MonoBehaviour
{

    public string itemName;
    public int itemValue;

    playerController playerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerScript = GameObject.Find("Player").GetComponent<playerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        Debug.Log(itemName);
        playerScript.itemText.text = itemName;
    }

    void OnMouseDown()
    {
        itemName = "Now I can unlock a door!";
        playerScript.hasKey = true;
        Destroy(gameObject);
    }
}
