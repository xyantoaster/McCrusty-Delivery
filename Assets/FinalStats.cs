using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinalStats : MonoBehaviour
{
    Delivery delivery;
    public TextMeshProUGUI finalTime;
    public TextMeshProUGUI finalHits;

    // Start is called before the first frame update
    void Start()
    {
        delivery = GameObject.Find("McCrusty Car").GetComponent<Delivery>();
        finalTime.text = "Final " + delivery.timerText.text;
        delivery.timerText.text = null;
        finalHits.text = "Crashes: " + delivery.hits;
        delivery.deliverText.text = null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
