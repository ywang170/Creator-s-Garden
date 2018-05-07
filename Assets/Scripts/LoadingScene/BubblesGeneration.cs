using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubblesGeneration : MonoBehaviour {

    public GameObject bubble;

    private float nextBubblesTargetTimeDelta;
    private float timePassedSinceLastBubbles;

	// Use this for initialization
	void Start () {
        generateBubbles(Random.Range(6, 8));
        nextBubblesTargetTimeDelta = Random.Range(2f, 5f);
        timePassedSinceLastBubbles = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        timePassedSinceLastBubbles += Time.deltaTime;
        if (timePassedSinceLastBubbles >= nextBubblesTargetTimeDelta)
        {
            generateBubbles(Random.Range(6, 8));
            nextBubblesTargetTimeDelta = Random.Range(2f, 5f);
            timePassedSinceLastBubbles = 0f;
        }
	}

    private void generateBubbles(int num = 1)
    {
        float xPos = Random.Range(-600f, 600f);
        for (int i = 0; i < num; i++)
        {
            GameObject generatedBubble = Instantiate(bubble, gameObject.transform) as GameObject;
            generatedBubble.transform.localPosition = new Vector3(xPos, -360f);
        }
    }
}
