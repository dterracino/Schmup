﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOutText : MonoBehaviour
{
    [SerializeField]
    private float duration;

    private Text text;

    private float startTime;

    private void Start()
    {
        this.text = this.GetComponent<Text>();
        this.startTime = Time.time;
    }
	
	private void Update()
	{
	    if (text.color != Color.clear)
	    {
	        text.color = Color.Lerp(text.color, Color.clear, (Time.time - this.startTime) / this.duration);
	    }
    }
}
