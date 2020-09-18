using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text txt;
    public static int scores = 0;
    // Start is called before the first frame update
    void Start()
    {
        scores = 0;
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = scores.ToString();
       // GetComponent<UnityEngine.UI.Text>().text = scores.ToString();
    }
}
