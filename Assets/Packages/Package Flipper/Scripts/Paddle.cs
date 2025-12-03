using UnityEngine;

public class Paddle : MonoBehaviour
{
	public HingeJoint  hingeJoint;
	public KeyCode     key            = KeyCode.A;
	public float       targetPosition = 75;
	public float       originPosition;
	public AudioSource audioSource;
	private bool pressed = false;
	
	JointSpring jointSpring;

	void Start()
	{
		jointSpring = hingeJoint.spring;
	}

	void Update()
	{
		if (Input.GetKey(key))
		{
			jointSpring.targetPosition = targetPosition;
			

			if (!pressed)
			{
				pressed                    = true;
				audioSource.Play();
			}
			
			
		}
		else
		{
			jointSpring.targetPosition = originPosition;
		}

		hingeJoint.spring = jointSpring;

		if (Input.GetKeyUp(key))
		{
			pressed = false;
		}
	}
}