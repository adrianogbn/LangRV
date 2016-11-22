using UnityEngine;
using System.Collections;

public class MoveTouch : MonoBehaviour {
    public float speed;

	// Use this for initialization
	void Start () {
        speed = 0.20f;	
	}

    // Update is called once per frame
    void Update() {
        if (Input.touchCount > 0) {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit = new RaycastHit();

            if (Physics.Raycast(ray, out hit, 500)) {
                if (hit.collider.gameObject == this.gameObject) {
                    switch (Input.GetTouch(0).phase) {
                        case TouchPhase.Began:
                            break;
                        case TouchPhase.Moved:
                            break;
                        case TouchPhase.Ended:
                            break;
                        case TouchPhase.Canceled:
                            break;
                    }
                }
            }            
        }
        transform.Translate(Input.touches[0].deltaPosition.x * speed,
            Input.touches[0].deltaPosition.y * speed, 0);
    }
}