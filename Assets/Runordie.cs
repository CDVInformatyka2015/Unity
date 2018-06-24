using UnityEngine;
using UnityEngine.UI;

public class Runordie : MonoBehaviour {

    public Button clicker;
    public Animator leftHand;
    public Animator rightHand;
    public Animator body;
    public Animator leftLeg;
    public Animator rightLeg;
    // Use this for initialization
    void Start ()
    {
        clicker.onClick.AddListener(TaskOnClick);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        leftHand.SetBool("Run", !leftHand.GetBool("Run"));
        rightHand.SetBool("Run", !rightHand.GetBool("Run"));
        body.SetBool("Run", !body.GetBool("Run"));
        leftLeg.SetBool("Run", !leftLeg.GetBool("Run"));
        rightLeg.SetBool("Run", !rightLeg.GetBool("Run"));
    }
}
