using UnityEngine;
using UnityEngine.UI;

public class Runordie : MonoBehaviour {

    public Button clicker;
    public Animator left;
    public Animator right;
    public Animator body;
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
        left.SetBool("Run", !left.GetBool("Run"));
        right.SetBool("Run", !right.GetBool("Run"));
        body.SetBool("Run", !body.GetBool("Run"));
    }
}
