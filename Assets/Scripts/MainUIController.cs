using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainUIController : MonoBehaviour {

	public int score = 0;               //得分
	public int length=0;                //长度

	public Text msgText;
	public Text scoreText;
	public Text lengthText;
	public Image bgImage;
	public Image pauseBtnImage;

	public Sprite[] btnSprites;

	public bool is_Pause=false;
	public bool hasBorder=true;
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


	void Start()
	{
		if (PlayerPrefs.GetInt ("border", 1)==0) {
			hasBorder = false;
			foreach (Transform t in bgImage.gameObject.transform) {
				t.gameObject.GetComponent<Image> ().enabled = false;
			}
		}
	}

	public void UpdateUI(int sco=5, int len=1)   //默认长度+1， 分数+5；
	{
		score += sco;
		length += len;
		scoreText.text = "得  分  ：\n" + score;
		lengthText.text="长  度  ：\n"+length;
	}


	/***
	 * 暂停方法：
	 * */
	public void Pause()
	{
		is_Pause = !is_Pause;
		if(is_Pause)
		{
			Time.timeScale = 0;  //时间冻结
			pauseBtnImage.sprite=btnSprites[1];
		}
		else
		{
			Time.timeScale = 1;  //时间解冻
			pauseBtnImage.sprite=btnSprites[0];
		}
	}


	/***
	 * 
	 * 回首页
	 * 
	 * */
	public void GoHome()
	{
		SceneManager.LoadScene (0);
	} 


	void Update()
	{
		ColorUtility.TryParseHtmlString (hexc, out tempc);
		if (score < 200) {
			hexc="#cccccccc";
			msgText.text = "阶 段"+1;
		} else if (score >= 200 && score < 400) {
			hexc="#cceeffff";
			msgText.text = "阶 段"+2;
		} else if (score >= 400 && score < 600) {
			hexc="#ccffdbff";
			msgText.text = "阶 段"+3;
		} else if (score >= 600 && score < 800) {
			hexc="#ebffccff";
			msgText.text = "阶 段"+4;
		} else if (score >= 800 && score < 1000) {
			hexc="#fff3ccff";
			msgText.text = "阶 段"+5;
		}else{
			hexc="#ffdaccff";
			msgText.text = "无 尽 模 式";
		}
		bgImage.color = tempc;


		/***
		 * 
		 * 
		switch (score / 100) 
		{
		case 0:
		case 1:
			//.....
			break;	

		case 2:
		case 3:
			//....
			break;

		case 4:
		case 5:
			//....
			break;
		}
		***
		*
		*/

	}


}
