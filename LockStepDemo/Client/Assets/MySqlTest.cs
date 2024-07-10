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
		QueryCommand qc = new QueryCommand();
		qc.frame = 1;
		qc.id = 100;

		ProtocolAnalysisService.SendCommand(qc);

	}

}
