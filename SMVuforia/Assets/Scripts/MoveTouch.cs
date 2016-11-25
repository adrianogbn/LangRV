using UnityEngine;
using System.Collections;

public class MoveTouch : MonoBehaviour {
    public Vector3 startPosition;

    public GameObject gameObjectTodrag; //refer to GO that being dragged

    public Vector3 GOcenter; //gameobjectcenter
    public Vector3 touchPosition; //touch or click position
    public Vector3 offset;//vector between touchpoint/mouseclick to object center
    public Vector3 newGOCenter; //new center of gameObject

    RaycastHit hit; //store hit object information

    public bool draggingMode = false;

    
    
    
	// Use this for initialization
	void Start () {
        startPosition = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
    }

    // Update is called once per frame
    void Update() {

        if (Input.touchCount > 0) {
            switch (Input.GetTouch(0).phase) {
                //When just touch
                case TouchPhase.Began:
                    transform.position = new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, transform.position.z);
                    break;

                    /**
                    //convert mouse click position to a ray
                    Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

                    //if ray hit a Collider ( not 2DCollider)
                    // if (Physics.Raycast(ray, out hit))
                    if (Physics.Raycast(ray, out hit)) {
                        gameObjectTodrag = hit.collider.gameObject;
                        GOcenter = gameObjectTodrag.transform.position;
                        touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                        offset = touchPosition - GOcenter;
                        draggingMode = true;
                    }
                    break;

                case TouchPhase.Moved:
                    if (draggingMode) {
                        touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                        newGOCenter = touchPosition - offset;
                        gameObjectTodrag.transform.position = new Vector3(newGOCenter.x, newGOCenter.y, GOcenter.z);
                    }
                    break;

                case TouchPhase.Ended:
                    draggingMode = false;
                    break;
    **/
            }
        }
    }
}