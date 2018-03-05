using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUIController : MonoBehaviour {

	public int score = 0;               //得分
	public int length=0;                //长度

	public Text msgText;
	public Text scoreText;
	public Text lengthText;
	public Image bgImage;


	private static MainUIController _instance;

	Color tempc;
	string hexc="#ffffffff";


	public static MainUIController Insatnce
	{
		get
		{
			return _instance;
		}
	}
		
	void Awake()
	{
		_instance = this;
	}


	public void UpdateUI(int sco=5, int len=1)   //默认长度+1， 分数+5；
	{
		score += sco;
		length += len;
		scoreText.text = "得  分 ：+\n" + score;
		lengthText.text="长  度 ：+\n"+length;
	}

	void Update()
	{
		ColorUtility.TryParseHtmlString (hexc, out tempc);
		if (score < 100) {
			hexc="#cccccccc";
			bgImage.color = tempc;
			msgText.text = "阶 段"+1;
		} else if (score >= 100 && score < 200) {
			hexc="#cceeffff";
			msgText.text = "阶 段"+2;
		} else if (score >= 200 && score < 300) {
			hexc="#ccffdbff";
			msgText.text = "阶 段"+3;
		} else if (score >= 300 && score < 400) {
			hexc="#ebffccff";
			msgText.text = "阶 段"+4;
		} else if (score >= 300 && score < 400) {
			hexc="#fff3ccff";
			msgText.text = "阶 段"+5;
		}else{
			hexc="#ffdaccff";
			msgText.text = "无 尽 模 式";
		}
	}


}
