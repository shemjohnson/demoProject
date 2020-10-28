using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationSwitch : MonoBehaviour
{
	 public int counter = 0;
	 
	 public bool underCanopy;
	
    // Start is called before the first frame update
    void Start()
    {
		underCanopy = true;
    }

    // Update is called once per frame
    void Update()
    {
		OVRInput.Update();
        if(Input.GetKeyDown("m") || OVRInput.Get(OVRInput.RawButton.B) && counter > 20 ){
			if(underCanopy)
				this.transform.position += new Vector3(-6, 0, 0); 
			else
				this.transform.position += new Vector3(6, 0, 0);
			counter = 0;
			underCanopy = !underCanopy;
		}
		counter++;
    }
}
