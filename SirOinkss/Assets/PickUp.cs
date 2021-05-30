using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickUp : MonoBehaviour
{
    public float Hat = 0;
    public TextMeshProUGUI textHat;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.tag == "Hat")
        {
            Hat++;
            textHat.text = Hat.ToString();
            Destroy(other.gameObject);
        }
    }
}
