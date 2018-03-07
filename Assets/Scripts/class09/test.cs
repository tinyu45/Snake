using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	void OnEnable(){
		EasyButton.On_ButtonDown += On_ButtonDown;
		EasyButton.On_ButtonPress += On_ButtonPress;
		EasyButton.On_ButtonUp += On_ButtonUp;
	}


	void OnDisable(){
		EasyButton.On_ButtonDown -= On_ButtonDown;
		EasyButton.On_ButtonPress -= On_ButtonPress;
		EasyButton.On_ButtonUp -= On_ButtonUp;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void On_ButtonDown(string btnName){
		print ("esay-Button 被点击.....");
	}


	public void On_ButtonPress(string btnName){
		print ("按钮被按下.....");
	}


	public void On_ButtonUp(string btnName){
		print ("按钮弹起");
	}



	/**摇杆 开始移动***/
	void On_JoystickMoveStart(MovingJoystick move){
		print ("23435");
	}

}
