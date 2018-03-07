using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cn.bmob.io;

public class Players : BmobTable {

	/// <summary>
	/// Bmob服务器端我们定义的表名
	/// </summary>
	public const string TABLENAME = "Players";

	/// <summary>
	/// 玩家姓名
	/// </summary>
	public string playerName { get; set; }
	/// <summary>
	/// 玩家得分
	/// </summary>
	public BmobInt score { get; set; }

	/// <summary>
	/// 成员函数
	/// </summary>
	/// <param name="input"></param>
	public override void readFields(BmobInput input)
	{
		base.readFields(input);
		this.score = input.getInt("score");
		this.playerName = input.getString("playerName");

	}  
	public override void write(BmobOutput output, bool all)
	{
		base.write(output, all);
		output.Put("score", this.score);
		output.Put("playerName", this.playerName);
	}
}




