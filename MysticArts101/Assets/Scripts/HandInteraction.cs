using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandInteraction : MonoBehaviour
{

	public SteamVR_TrackedObject trackedObj;
	private SteamVR_Controller.Device device;
	//private bool oculus;

	public GameObject movableObject;
	private Vector3 destination = new Vector3();
	public float speed = 10.0f;

	void Start()
	{
		trackedObj = GetComponent<SteamVR_TrackedObject>();
		//oculus = (UnityEngine.XR.XRDevice.model.Contains("Oculus")) ? true : false;
	}

	void Update()
	{
		if (User.HasFocus)
		{
			device = SteamVR_Controller.Input((int)trackedObj.index);
			if (device.GetPressDown(SteamVR_Controller.ButtonMask.Touchpad))
			{
				destination = new Vector3(this.transform.position.x*-1.0f, movableObject.transform.position.y, this.transform.position.z*-1.0f);
				Vector3.Lerp(movableObject.transform.position, destination, Time.deltaTime * speed);
			}
			else if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
			{
				destination = new Vector3(this.transform.position.x, movableObject.transform.position.y, this.transform.position.z);
				Vector3.Lerp(movableObject.transform.position, destination, Time.deltaTime * speed);
			}
		}
	}

}
