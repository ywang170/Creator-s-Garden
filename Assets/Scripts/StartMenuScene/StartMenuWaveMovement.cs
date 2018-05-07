using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenuWaveMovement : MonoBehaviour {

    private float upperHeightLimit;
    private float lowerHeightLimit;

	// Use this for initialization
	void Start () {
        upperHeightLimit = transform.position.y;
        lowerHeightLimit = upperHeightLimit - 50;
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y >= lowerHeightLimit)
        {
            transform.Translate(new Vector3(0, -5f * Time.deltaTime));
        }
	}
}
