using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour {

    private int number;
    public Text NumberText;

	// Use this for initialization
	void Start ()
    {
        StartCoroutine(Timer());
	}
	
    private IEnumerator Timer()
    {
        while (true)
        {
            NumberText.text = number.ToString();
            yield return new WaitForSeconds(1.0f);
            number++;
        }
    }

}
