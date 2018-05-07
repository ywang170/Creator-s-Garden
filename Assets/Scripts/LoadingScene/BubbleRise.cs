using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleRise : MonoBehaviour {

    private Vector3 targetScale;
    private float scaleSpeed;
    private float horizontalAccelerationDirection;
    private float horizontalSpeed;
    private float verticalSpeed;

	// Use this for initialization
	void Start () {
        // Rescale to desired scale
        transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        // Scale target
        float targetScaleFactor = Random.Range(0.2f, 0.3f);
        targetScale = new Vector3(targetScaleFactor, targetScaleFactor, targetScaleFactor);
        scaleSpeed = Random.Range(0.02f, 0.03f);
        // Horizontal speed
        horizontalSpeed = Random.Range(-0.1f, 0.1f);
        horizontalAccelerationDirection = 1f;
        // Vertical speed
        verticalSpeed = Random.Range(3f, 4f);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        horizontalSpeed += Random.Range(0, 0.03f) * horizontalAccelerationDirection;
        if (Mathf.Abs(horizontalSpeed) > 0.2f)
        {
            horizontalAccelerationDirection = -horizontalAccelerationDirection;
        }
        verticalSpeed = Mathf.Max(verticalSpeed - 0.015f, 2f);
        transform.Translate(new Vector3(horizontalSpeed, verticalSpeed));
        transform.localScale = Vector3.Lerp(transform.localScale, targetScale, scaleSpeed);

        if (transform.localPosition.y > 360f)
        {
            Destroy(gameObject);
        }
	}
}
