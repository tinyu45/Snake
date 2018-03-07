using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cn.bmob.api;
using cn.bmob.tools;
using cn.bmob.io;



public class BombTest : MonoBehaviour {

	private BmobUnity Bmob;

	// Use this for initialization
	void Start()
	{
		BmobDebug.Register(print);
		Bmob = gameObject.GetComponent<BmobUnity>();
	}

	void OnGUI()
	{
		if (GUILayout.Button("Insert"))
		{
			InsertData();
		}
		if (GUILayout.Button("GetData"))
		{
			getRecoard();
		}
		if (GUILayout.Button("Update"))
		{
			updateData();
		}
		if (GUILayout.Button("GetAllData"))
		{
			getAllInfo();
		}
		if (GUILayout.Button("删除数据"))
		{
			deleteData();
		}
	}





	#region
	/// <summary>
	/// 插入数据
	/// </summary>
	public void InsertData()
	{
		Players mg = new Players();
		mg.score = 100;
		mg.playerName = "testBmob";

		Bmob.Create(Players.TABLENAME, mg, (resp, exception) =>
			{
				if (exception != null)
				{
					Debug.Log("保存失败，原因： " + exception.Message);
				}
				else
				{
					Debug.Log("保存成功" + resp.createdAt);
				}
			});
	}
	/// <summary>
	/// 获取表所以信息
	/// </summary>
	public void getAllInfo()
	{
		Bmob.Delete(Players.TABLENAME, "4d05c4cd58", (resp, exception) =>
			{
				if (exception != null)
				{
					Debug.Log("删除失败, 失败原因为： " + exception.Message);
					return;
				}
				else
				{
					Debug.Log("删除成功, @" + resp.msg);
				}
			});
	}
	/// <summary>
	/// 查询数据
	/// </summary>
	public void getRecoard()
	{
		Players mg = new Players();

		Bmob.Get<Players>(Players.TABLENAME, "2TLe999G", (resp, exception) =>
			{
				if (exception != null)
				{
					Debug.Log("查询失败, 失败原因为： " + exception.Message);
					return;
				}

				Players game = resp;
				Debug.Log(game.playerName + "," + game.score + "," + game.objectId);
				Debug.Log("获取的对象为： " + game.ToString());
			});
	}
	/// <summary>
	/// 更新数据
	/// </summary>
	public void updateData()
	{
		Players game = new Players();
		game.playerName = "wuzhang";
		Bmob.Update(Players.TABLENAME, "4d05c4cd58", game, (resp, exception) =>
			{
				if (exception != null)
				{
					Debug.Log("保存失败, 失败原因为： " + exception.Message);
					return;
				}

				Debug.Log("保存成功, @" + resp.updatedAt);
			});
	}
	/// <summary>
	/// 删除数据
	/// </summary>
	public void deleteData()
	{
		Bmob.Delete(Players.TABLENAME, "4d05c4cd58", (resp, exception) =>
			{
				if (exception != null)
				{
					Debug.Log("删除失败, 失败原因为： " + exception.Message);
					return;
				}
				else
				{
					Debug.Log("删除成功, @" + resp.msg);
				}
			});
	}
	#endregion


}
