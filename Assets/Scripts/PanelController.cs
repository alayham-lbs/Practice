using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelController : MonoBehaviour {

    Slider slider;
    Text text;
    string caption = "";


    public void changeText()
    {
        text.text = caption + " " + slider.value.ToString();
    }

    // Use this for initialization
 
	void Start () {
        slider = transform.Find("Slider").gameObject.GetComponent<Slider>();
        text = transform.Find("Text").gameObject.GetComponent<Text>();
        caption = text.text;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
