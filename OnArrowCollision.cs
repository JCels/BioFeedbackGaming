using UnityEngine;
using System.Collections;

public class OnArrowCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Arrow")
        {
            Destroy(gameObject);
            //Destoy arrow
            Destroy(other.gameObject);
        }
        

    }
}
