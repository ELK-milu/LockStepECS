using MiniJSON;
using Protocol;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class TESTCompent
{
	public int a = 1;
	public string name = "www";
}

public class MySqlTest : MonoBehaviour
{
	public void TestSendMsg()
	{
		PlayerLoginMsg_s logininfo = new PlayerLoginMsg_s();
		logininfo.playerID = "1111";
		logininfo.passWord = "dick";

		ProtocolAnalysisService.SendCommand(logininfo);

	}

}
