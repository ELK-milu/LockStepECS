#pragma warning disable
using Protocol;
using System;
using System.Collections.Generic;
using UnityEngine;

//指令解析类
//该类自动生成，请勿修改
public class ProtocolAnalysisService
{
	#region 外部调用
	public static void Init()
	{
		InputManager.AddListener<InputNetworkMessageEvent>("affirmmsg",ReceviceAffirmMsg);
		InputManager.AddListener<InputNetworkMessageEvent>("changecomponentmsg",ReceviceChangeComponentMsg);
		InputManager.AddListener<InputNetworkMessageEvent>("changesingletoncomponentmsg",ReceviceChangeSingletonComponentMsg);
		InputManager.AddListener<InputNetworkMessageEvent>("commandmsg",ReceviceCommandMsg);
		InputManager.AddListener<InputNetworkMessageEvent>("debugmsg",ReceviceDebugMsg);
		InputManager.AddListener<InputNetworkMessageEvent>("destroyentitymsg",ReceviceDestroyEntityMsg);
		InputManager.AddListener<InputNetworkMessageEvent>("pursuemsg",RecevicePursueMsg);
		InputManager.AddListener<InputNetworkMessageEvent>("querycommand",ReceviceQueryCommand);
		InputManager.AddListener<InputNetworkMessageEvent>("samecommand",ReceviceSameCommand);
		InputManager.AddListener<InputNetworkMessageEvent>("startsyncmsg",ReceviceStartSyncMsg);
		InputManager.AddListener<InputNetworkMessageEvent>("syncentitymsg",ReceviceSyncEntityMsg);
		InputManager.AddListener<InputNetworkMessageEvent>("verificationmsg",ReceviceVerificationMsg);
		InputManager.AddListener<InputNetworkMessageEvent>("commandcomponent",ReceviceCommandComponent);
		InputManager.AddListener<InputNetworkMessageEvent>("playerbuycharacter",RecevicePlayerBuyCharacter_c);
		InputManager.AddListener<InputNetworkMessageEvent>("playerloginmsg",RecevicePlayerLoginMsg_c);
		InputManager.AddListener<InputNetworkMessageEvent>("playermatchmsg",RecevicePlayerMatchMsg_c);
		InputManager.AddListener<InputNetworkMessageEvent>("playerrename",RecevicePlayerRename_c);
		InputManager.AddListener<InputNetworkMessageEvent>("playerresurgence",RecevicePlayerResurgence_c);
		InputManager.AddListener<InputNetworkMessageEvent>("playerselectcharacter",RecevicePlayerSelectCharacter_c);
		InputManager.AddListener<InputNetworkMessageEvent>("playersettlement",RecevicePlayerSettlement_c);
	}

	public static void Dispose()
	{
		InputManager.RemoveListener<InputNetworkMessageEvent>("affirmmsg",ReceviceAffirmMsg);
		InputManager.RemoveListener<InputNetworkMessageEvent>("changecomponentmsg",ReceviceChangeComponentMsg);
		InputManager.RemoveListener<InputNetworkMessageEvent>("changesingletoncomponentmsg",ReceviceChangeSingletonComponentMsg);
		InputManager.RemoveListener<InputNetworkMessageEvent>("commandmsg",ReceviceCommandMsg);
		InputManager.RemoveListener<InputNetworkMessageEvent>("debugmsg",ReceviceDebugMsg);
		InputManager.RemoveListener<InputNetworkMessageEvent>("destroyentitymsg",ReceviceDestroyEntityMsg);
		InputManager.RemoveListener<InputNetworkMessageEvent>("pursuemsg",RecevicePursueMsg);
		InputManager.RemoveListener<InputNetworkMessageEvent>("querycommand",ReceviceQueryCommand);
		InputManager.RemoveListener<InputNetworkMessageEvent>("samecommand",ReceviceSameCommand);
		InputManager.RemoveListener<InputNetworkMessageEvent>("startsyncmsg",ReceviceStartSyncMsg);
		InputManager.RemoveListener<InputNetworkMessageEvent>("syncentitymsg",ReceviceSyncEntityMsg);
		InputManager.RemoveListener<InputNetworkMessageEvent>("verificationmsg",ReceviceVerificationMsg);
		InputManager.RemoveListener<InputNetworkMessageEvent>("commandcomponent",ReceviceCommandComponent);
		InputManager.RemoveListener<InputNetworkMessageEvent>("playerbuycharacter",RecevicePlayerBuyCharacter_c);
		InputManager.RemoveListener<InputNetworkMessageEvent>("playerloginmsg",RecevicePlayerLoginMsg_c);
		InputManager.RemoveListener<InputNetworkMessageEvent>("playermatchmsg",RecevicePlayerMatchMsg_c);
		InputManager.RemoveListener<InputNetworkMessageEvent>("playerrename",RecevicePlayerRename_c);
		InputManager.RemoveListener<InputNetworkMessageEvent>("playerresurgence",RecevicePlayerResurgence_c);
		InputManager.RemoveListener<InputNetworkMessageEvent>("playerselectcharacter",RecevicePlayerSelectCharacter_c);
		InputManager.RemoveListener<InputNetworkMessageEvent>("playersettlement",RecevicePlayerSettlement_c);
	}
	public static void SendCommand (IProtocolMessageInterface cmd)
	{
		if(cmd is Protocol.AffirmMsg )
		{
			SendAffirmMsg(cmd);
		}
		else if(cmd is Protocol.ChangeComponentMsg )
		{
			SendChangeComponentMsg(cmd);
		}
		else if(cmd is Protocol.ChangeSingletonComponentMsg )
		{
			SendChangeSingletonComponentMsg(cmd);
		}
		else if(cmd is Protocol.CommandMsg )
		{
			SendCommandMsg(cmd);
		}
		else if(cmd is Protocol.DebugMsg )
		{
			SendDebugMsg(cmd);
		}
		else if(cmd is Protocol.DestroyEntityMsg )
		{
			SendDestroyEntityMsg(cmd);
		}
		else if(cmd is Protocol.PursueMsg )
		{
			SendPursueMsg(cmd);
		}
		else if(cmd is Protocol.QueryCommand )
		{
			SendQueryCommand(cmd);
		}
		else if(cmd is Protocol.SameCommand )
		{
			SendSameCommand(cmd);
		}
		else if(cmd is Protocol.StartSyncMsg )
		{
			SendStartSyncMsg(cmd);
		}
		else if(cmd is Protocol.SyncEntityMsg )
		{
			SendSyncEntityMsg(cmd);
		}
		else if(cmd is Protocol.VerificationMsg )
		{
			SendVerificationMsg(cmd);
		}
		else if(cmd is CommandComponent )
		{
			SendCommandComponent(cmd);
		}
		else if(cmd is PlayerBuyCharacter_s )
		{
			SendPlayerBuyCharacter_s(cmd);
		}
		else if(cmd is PlayerLoginMsg_s )
		{
			SendPlayerLoginMsg_s(cmd);
		}
		else if(cmd is PlayerMatchMsg_s )
		{
			SendPlayerMatchMsg_s(cmd);
		}
		else if(cmd is PlayerRename_s )
		{
			SendPlayerRename_s(cmd);
		}
		else if(cmd is PlayerResurgence_s )
		{
			SendPlayerResurgence_s(cmd);
		}
		else if(cmd is PlayerSelectCharacter_s )
		{
			SendPlayerSelectCharacter_s(cmd);
		}
		else
		{
			throw new Exception("SendCommand Exception : 不支持的消息类型!" + cmd.GetType());
		}
	}
	static void SendAffirmMsg(IProtocolMessageInterface msg)
	{
		Protocol.AffirmMsg e = (Protocol.AffirmMsg)msg;
		Dictionary<string, object> data = new Dictionary<string, object>();
		data.Add("index", e.index);
		data.Add("time", e.time);
		NetworkManager.SendMessage("affirmmsg",data);
	}
	static void SendChangeComponentMsg(IProtocolMessageInterface msg)
	{
		Protocol.ChangeComponentMsg e = (Protocol.ChangeComponentMsg)msg;
		Dictionary<string, object> data = new Dictionary<string, object>();
		data.Add("frame", e.frame);
		data.Add("id", e.id);
			{
				Dictionary<string, object> data2 = new Dictionary<string, object>();
				data2.Add("m_compname", e.info.m_compName);
				data2.Add("content", e.info.content);
				data.Add("info",data2);
			}
		NetworkManager.SendMessage("changecomponentmsg",data);
	}
	static void SendChangeSingletonComponentMsg(IProtocolMessageInterface msg)
	{
		Protocol.ChangeSingletonComponentMsg e = (Protocol.ChangeSingletonComponentMsg)msg;
		Dictionary<string, object> data = new Dictionary<string, object>();
		data.Add("frame", e.frame);
			{
				Dictionary<string, object> data2 = new Dictionary<string, object>();
				data2.Add("m_compname", e.info.m_compName);
				data2.Add("content", e.info.content);
				data.Add("info",data2);
			}
		NetworkManager.SendMessage("changesingletoncomponentmsg",data);
	}
	static void SendCommandMsg(IProtocolMessageInterface msg)
	{
		Protocol.CommandMsg e = (Protocol.CommandMsg)msg;
		Dictionary<string, object> data = new Dictionary<string, object>();
		data.Add("index", e.index);
		data.Add("servertime", e.serverTime);
		{
			List<object> list2 = new List<object>();
			for(int i2 = 0;i2 <e.msg.Count ; i2++)
			{
				Dictionary<string, object> data2 = new Dictionary<string, object>();
				data2.Add("frame", e.msg[i2].frame);
				data2.Add("id", e.msg[i2].id);
					{
						Dictionary<string, object> data4 = new Dictionary<string, object>();
						data4.Add("x", e.msg[i2].moveDir.x);
						data4.Add("y", e.msg[i2].moveDir.y);
						data4.Add("z", e.msg[i2].moveDir.z);
						data2.Add("movedir",data4);
					}
					{
						Dictionary<string, object> data4 = new Dictionary<string, object>();
						data4.Add("x", e.msg[i2].skillDir.x);
						data4.Add("y", e.msg[i2].skillDir.y);
						data4.Add("z", e.msg[i2].skillDir.z);
						data2.Add("skilldir",data4);
					}
				data2.Add("element1", e.msg[i2].element1);
				data2.Add("element2", e.msg[i2].element2);
				data2.Add("isfire", e.msg[i2].isFire);
				list2.Add( data2);
			}
			data.Add("msg",list2);
		}
		NetworkManager.SendMessage("commandmsg",data);
	}
	static void SendDebugMsg(IProtocolMessageInterface msg)
	{
		Protocol.DebugMsg e = (Protocol.DebugMsg)msg;
		Dictionary<string, object> data = new Dictionary<string, object>();
		data.Add("frame", e.frame);
		data.Add("seed", e.seed);
		{
			List<object> list2 = new List<object>();
			for(int i2 = 0;i2 <e.infos.Count ; i2++)
			{
				Dictionary<string, object> data2 = new Dictionary<string, object>();
				data2.Add("id", e.infos[i2].id);
				{
					List<object> list4 = new List<object>();
					for(int i4 = 0;i4 <e.infos[i2].infos.Count ; i4++)
					{
						Dictionary<string, object> data4 = new Dictionary<string, object>();
						data4.Add("m_compname", e.infos[i2].infos[i4].m_compName);
						data4.Add("content", e.infos[i2].infos[i4].content);
						list4.Add( data4);
					}
					data2.Add("infos",list4);
				}
				list2.Add( data2);
			}
			data.Add("infos",list2);
		}
		{
			List<object> list2 = new List<object>();
			for(int i2 = 0;i2 <e.singleCompInfo.Count ; i2++)
			{
				Dictionary<string, object> data2 = new Dictionary<string, object>();
				data2.Add("m_compname", e.singleCompInfo[i2].m_compName);
				data2.Add("content", e.singleCompInfo[i2].content);
				list2.Add( data2);
			}
			data.Add("singlecompinfo",list2);
		}
		data.Add("msg", e.msg);
		NetworkManager.SendMessage("debugmsg",data);
	}
	static void SendDestroyEntityMsg(IProtocolMessageInterface msg)
	{
		Protocol.DestroyEntityMsg e = (Protocol.DestroyEntityMsg)msg;
		Dictionary<string, object> data = new Dictionary<string, object>();
		data.Add("frame", e.frame);
		data.Add("id", e.id);
		NetworkManager.SendMessage("destroyentitymsg",data);
	}
	static void SendPursueMsg(IProtocolMessageInterface msg)
	{
		Protocol.PursueMsg e = (Protocol.PursueMsg)msg;
		Dictionary<string, object> data = new Dictionary<string, object>();
		data.Add("id", e.id);
		data.Add("recalcframe", e.recalcFrame);
		data.Add("frame", e.frame);
		data.Add("advancecount", e.advanceCount);
		data.Add("servertime", e.serverTime);
		data.Add("updatespeed", e.updateSpeed);
		{
			List<object> list = new List<object>();
			for(int i = 0;i <e.m_commandList.Count ; i++)
			{
				list.Add( e.m_commandList[i]);
			}
			data.Add("m_commandlist",list);
		}
		NetworkManager.SendMessage("pursuemsg",data);
	}
	static void SendQueryCommand(IProtocolMessageInterface msg)
	{
		Protocol.QueryCommand e = (Protocol.QueryCommand)msg;
		Dictionary<string, object> data = new Dictionary<string, object>();
		data.Add("frame", e.frame);
		data.Add("id", e.id);
		NetworkManager.SendMessage("querycommand",data);
	}
	static void SendSameCommand(IProtocolMessageInterface msg)
	{
		Protocol.SameCommand e = (Protocol.SameCommand)msg;
		Dictionary<string, object> data = new Dictionary<string, object>();
		data.Add("time", e.time);
		data.Add("frame", e.frame);
		data.Add("id", e.id);
		NetworkManager.SendMessage("samecommand",data);
	}
	static void SendStartSyncMsg(IProtocolMessageInterface msg)
	{
		Protocol.StartSyncMsg e = (Protocol.StartSyncMsg)msg;
		Dictionary<string, object> data = new Dictionary<string, object>();
		data.Add("frame", e.frame);
		data.Add("advancecount", e.advanceCount);
		data.Add("intervaltime", e.intervalTime);
		data.Add("createentityindex", e.createEntityIndex);
		data.Add("randomseed", e.randomSeed);
		data.Add("syncrule", (int)e.SyncRule);
		NetworkManager.SendMessage("startsyncmsg",data);
	}
	static void SendSyncEntityMsg(IProtocolMessageInterface msg)
	{
		Protocol.SyncEntityMsg e = (Protocol.SyncEntityMsg)msg;
		Dictionary<string, object> data = new Dictionary<string, object>();
		data.Add("frame", e.frame);
		{
			List<object> list2 = new List<object>();
			for(int i2 = 0;i2 <e.infos.Count ; i2++)
			{
				Dictionary<string, object> data2 = new Dictionary<string, object>();
				data2.Add("id", e.infos[i2].id);
				{
					List<object> list4 = new List<object>();
					for(int i4 = 0;i4 <e.infos[i2].infos.Count ; i4++)
					{
						Dictionary<string, object> data4 = new Dictionary<string, object>();
						data4.Add("m_compname", e.infos[i2].infos[i4].m_compName);
						data4.Add("content", e.infos[i2].infos[i4].content);
						list4.Add( data4);
					}
					data2.Add("infos",list4);
				}
				list2.Add( data2);
			}
			data.Add("infos",list2);
		}
		{
			List<object> list = new List<object>();
			for(int i = 0;i <e.destroyList.Count ; i++)
			{
				list.Add( e.destroyList[i]);
			}
			data.Add("destroylist",list);
		}
		NetworkManager.SendMessage("syncentitymsg",data);
	}
	static void SendVerificationMsg(IProtocolMessageInterface msg)
	{
		Protocol.VerificationMsg e = (Protocol.VerificationMsg)msg;
		Dictionary<string, object> data = new Dictionary<string, object>();
		data.Add("frame", e.frame);
		data.Add("hash", e.hash);
		NetworkManager.SendMessage("verificationmsg",data);
	}
	static void SendCommandComponent(IProtocolMessageInterface msg)
	{
		CommandComponent e = (CommandComponent)msg;
		Dictionary<string, object> data = new Dictionary<string, object>();
			{
				Dictionary<string, object> data2 = new Dictionary<string, object>();
				data2.Add("x", e.moveDir.x);
				data2.Add("y", e.moveDir.y);
				data2.Add("z", e.moveDir.z);
				data.Add("movedir",data2);
			}
			{
				Dictionary<string, object> data2 = new Dictionary<string, object>();
				data2.Add("x", e.skillDir.x);
				data2.Add("y", e.skillDir.y);
				data2.Add("z", e.skillDir.z);
				data.Add("skilldir",data2);
			}
		data.Add("element1", e.element1);
		data.Add("element2", e.element2);
		data.Add("isfire", e.isFire);
		data.Add("id", e.id);
		data.Add("frame", e.frame);
		data.Add("time", e.time);
		data.Add("isenable", e.isEnable);
		NetworkManager.SendMessage("commandcomponent",data);
	}
	static void SendPlayerBuyCharacter_s(IProtocolMessageInterface msg)
	{
		PlayerBuyCharacter_s e = (PlayerBuyCharacter_s)msg;
		Dictionary<string, object> data = new Dictionary<string, object>();
		data.Add("characterid", e.characterID);
		NetworkManager.SendMessage("playerbuycharacter",data);
	}
	static void SendPlayerLoginMsg_s(IProtocolMessageInterface msg)
	{
		PlayerLoginMsg_s e = (PlayerLoginMsg_s)msg;
		Dictionary<string, object> data = new Dictionary<string, object>();
		data.Add("playerid", e.playerID);
		data.Add("password", e.passWord);
		NetworkManager.SendMessage("playerloginmsg",data);
	}
	static void SendPlayerMatchMsg_s(IProtocolMessageInterface msg)
	{
		PlayerMatchMsg_s e = (PlayerMatchMsg_s)msg;
		Dictionary<string, object> data = new Dictionary<string, object>();
		data.Add("iscancel", e.isCancel);
		NetworkManager.SendMessage("playermatchmsg",data);
	}
	static void SendPlayerRename_s(IProtocolMessageInterface msg)
	{
		PlayerRename_s e = (PlayerRename_s)msg;
		Dictionary<string, object> data = new Dictionary<string, object>();
		data.Add("newname", e.newName);
		NetworkManager.SendMessage("playerrename",data);
	}
	static void SendPlayerResurgence_s(IProtocolMessageInterface msg)
	{
		PlayerResurgence_s e = (PlayerResurgence_s)msg;
		Dictionary<string, object> data = new Dictionary<string, object>();
		NetworkManager.SendMessage("playerresurgence",data);
	}
	static void SendPlayerSelectCharacter_s(IProtocolMessageInterface msg)
	{
		PlayerSelectCharacter_s e = (PlayerSelectCharacter_s)msg;
		Dictionary<string, object> data = new Dictionary<string, object>();
		data.Add("characterid", e.characterID);
		NetworkManager.SendMessage("playerselectcharacter",data);
	}
	#endregion

	#region 事件接收
	static void ReceviceAffirmMsg(InputNetworkMessageEvent e)
	{
		Protocol.AffirmMsg msg = new Protocol.AffirmMsg();
		msg.index = (int)e.Data["index"];
		msg.time = (int)e.Data["time"];
		
		GlobalEvent.DispatchTypeEvent(msg);
	}
	static void ReceviceChangeComponentMsg(InputNetworkMessageEvent e)
	{
		Protocol.ChangeComponentMsg msg = new Protocol.ChangeComponentMsg();
		msg.frame = (int)e.Data["frame"];
		msg.id = (int)e.Data["id"];
		{
			Dictionary<string, object> data2 = (Dictionary<string, object>)e.Data["info"];
			Protocol.ComponentInfo tmp2 = new Protocol.ComponentInfo();
			tmp2.m_compName = data2["m_compname"].ToString();
			tmp2.content = data2["content"].ToString();
			msg.info = tmp2;
		}
		
		GlobalEvent.DispatchTypeEvent(msg);
	}
	static void ReceviceChangeSingletonComponentMsg(InputNetworkMessageEvent e)
	{
		Protocol.ChangeSingletonComponentMsg msg = new Protocol.ChangeSingletonComponentMsg();
		msg.frame = (int)e.Data["frame"];
		{
			Dictionary<string, object> data2 = (Dictionary<string, object>)e.Data["info"];
			Protocol.ComponentInfo tmp2 = new Protocol.ComponentInfo();
			tmp2.m_compName = data2["m_compname"].ToString();
			tmp2.content = data2["content"].ToString();
			msg.info = tmp2;
		}
		
		GlobalEvent.DispatchTypeEvent(msg);
	}
	static void ReceviceCommandMsg(InputNetworkMessageEvent e)
	{
		Protocol.CommandMsg msg = new Protocol.CommandMsg();
		msg.index = (int)e.Data["index"];
		msg.serverTime = (int)e.Data["servertime"];
		{
			List<Dictionary<string, object>> data2 = (List<Dictionary<string, object>>)e.Data["msg"];
			List<Protocol.CommandInfo> list2 = new List<Protocol.CommandInfo>();
			for (int i2 = 0; i2 < data2.Count; i2++)
			{
				Protocol.CommandInfo tmp2 = new Protocol.CommandInfo();
				tmp2.frame = (int)data2[i2]["frame"];
				tmp2.id = (int)data2[i2]["id"];
				{
					Dictionary<string, object> data4 = (Dictionary<string, object>)data2[i2]["movedir"];
					SyncVector3 tmp4 = new SyncVector3();
					tmp4.x = (int)data4["x"];
					tmp4.y = (int)data4["y"];
					tmp4.z = (int)data4["z"];
					tmp2.moveDir = tmp4;
				}
				{
					Dictionary<string, object> data4 = (Dictionary<string, object>)data2[i2]["skilldir"];
					SyncVector3 tmp4 = new SyncVector3();
					tmp4.x = (int)data4["x"];
					tmp4.y = (int)data4["y"];
					tmp4.z = (int)data4["z"];
					tmp2.skillDir = tmp4;
				}
				tmp2.element1 = (int)data2[i2]["element1"];
				tmp2.element2 = (int)data2[i2]["element2"];
				tmp2.isFire = (bool)data2[i2]["isfire"];
				list2.Add(tmp2);
			}
			msg.msg =  list2;
		}
		
		GlobalEvent.DispatchTypeEvent(msg);
	}
	static void ReceviceDebugMsg(InputNetworkMessageEvent e)
	{
		Protocol.DebugMsg msg = new Protocol.DebugMsg();
		msg.frame = (int)e.Data["frame"];
		msg.seed = (int)e.Data["seed"];
		{
			List<Dictionary<string, object>> data2 = (List<Dictionary<string, object>>)e.Data["infos"];
			List<Protocol.EntityInfo> list2 = new List<Protocol.EntityInfo>();
			for (int i2 = 0; i2 < data2.Count; i2++)
			{
				Protocol.EntityInfo tmp2 = new Protocol.EntityInfo();
				tmp2.id = (int)data2[i2]["id"];
				{
					List<Dictionary<string, object>> data4 = (List<Dictionary<string, object>>)data2[i2]["infos"];
					List<Protocol.ComponentInfo> list4 = new List<Protocol.ComponentInfo>();
					for (int i4 = 0; i4 < data4.Count; i4++)
					{
						Protocol.ComponentInfo tmp4 = new Protocol.ComponentInfo();
						tmp4.m_compName = data4[i4]["m_compname"].ToString();
						tmp4.content = data4[i4]["content"].ToString();
						list4.Add(tmp4);
					}
					tmp2.infos =  list4;
				}
				list2.Add(tmp2);
			}
			msg.infos =  list2;
		}
		{
			List<Dictionary<string, object>> data2 = (List<Dictionary<string, object>>)e.Data["singlecompinfo"];
			List<Protocol.ComponentInfo> list2 = new List<Protocol.ComponentInfo>();
			for (int i2 = 0; i2 < data2.Count; i2++)
			{
				Protocol.ComponentInfo tmp2 = new Protocol.ComponentInfo();
				tmp2.m_compName = data2[i2]["m_compname"].ToString();
				tmp2.content = data2[i2]["content"].ToString();
				list2.Add(tmp2);
			}
			msg.singleCompInfo =  list2;
		}
		msg.msg = e.Data["msg"].ToString();
		
		GlobalEvent.DispatchTypeEvent(msg);
	}
	static void ReceviceDestroyEntityMsg(InputNetworkMessageEvent e)
	{
		Protocol.DestroyEntityMsg msg = new Protocol.DestroyEntityMsg();
		msg.frame = (int)e.Data["frame"];
		msg.id = (int)e.Data["id"];
		
		GlobalEvent.DispatchTypeEvent(msg);
	}
	static void RecevicePursueMsg(InputNetworkMessageEvent e)
	{
		Protocol.PursueMsg msg = new Protocol.PursueMsg();
		msg.id = (int)e.Data["id"];
		msg.recalcFrame = (int)e.Data["recalcframe"];
		msg.frame = (int)e.Data["frame"];
		msg.advanceCount = (int)e.Data["advancecount"];
		msg.serverTime = (int)e.Data["servertime"];
		msg.updateSpeed = (float)(double)e.Data["updatespeed"];
		msg.m_commandList = (List<String>)e.Data["m_commandlist"];
		
		GlobalEvent.DispatchTypeEvent(msg);
	}
	static void ReceviceQueryCommand(InputNetworkMessageEvent e)
	{
		Protocol.QueryCommand msg = new Protocol.QueryCommand();
		msg.frame = (int)e.Data["frame"];
		msg.id = (int)e.Data["id"];
		
		GlobalEvent.DispatchTypeEvent(msg);
	}
	static void ReceviceSameCommand(InputNetworkMessageEvent e)
	{
		Protocol.SameCommand msg = new Protocol.SameCommand();
		msg.time = (int)e.Data["time"];
		msg.frame = (int)e.Data["frame"];
		msg.id = (int)e.Data["id"];
		
		GlobalEvent.DispatchTypeEvent(msg);
	}
	static void ReceviceStartSyncMsg(InputNetworkMessageEvent e)
	{
		Protocol.StartSyncMsg msg = new Protocol.StartSyncMsg();
		msg.frame = (int)e.Data["frame"];
		msg.advanceCount = (int)e.Data["advancecount"];
		msg.intervalTime = (int)e.Data["intervaltime"];
		msg.createEntityIndex = (int)e.Data["createentityindex"];
		msg.randomSeed = (int)e.Data["randomseed"];
		msg.SyncRule = (SyncRule)e.Data["syncrule"];
		
		GlobalEvent.DispatchTypeEvent(msg);
	}
	static void ReceviceSyncEntityMsg(InputNetworkMessageEvent e)
	{
		Protocol.SyncEntityMsg msg = new Protocol.SyncEntityMsg();
		msg.frame = (int)e.Data["frame"];
		{
			List<Dictionary<string, object>> data2 = (List<Dictionary<string, object>>)e.Data["infos"];
			List<Protocol.EntityInfo> list2 = new List<Protocol.EntityInfo>();
			for (int i2 = 0; i2 < data2.Count; i2++)
			{
				Protocol.EntityInfo tmp2 = new Protocol.EntityInfo();
				tmp2.id = (int)data2[i2]["id"];
				{
					List<Dictionary<string, object>> data4 = (List<Dictionary<string, object>>)data2[i2]["infos"];
					List<Protocol.ComponentInfo> list4 = new List<Protocol.ComponentInfo>();
					for (int i4 = 0; i4 < data4.Count; i4++)
					{
						Protocol.ComponentInfo tmp4 = new Protocol.ComponentInfo();
						tmp4.m_compName = data4[i4]["m_compname"].ToString();
						tmp4.content = data4[i4]["content"].ToString();
						list4.Add(tmp4);
					}
					tmp2.infos =  list4;
				}
				list2.Add(tmp2);
			}
			msg.infos =  list2;
		}
		msg.destroyList = (List<Int32>)e.Data["destroylist"];
		
		GlobalEvent.DispatchTypeEvent(msg);
	}
	static void ReceviceVerificationMsg(InputNetworkMessageEvent e)
	{
		Protocol.VerificationMsg msg = new Protocol.VerificationMsg();
		msg.frame = (int)e.Data["frame"];
		msg.hash = (int)e.Data["hash"];
		
		GlobalEvent.DispatchTypeEvent(msg);
	}
	static void ReceviceCommandComponent(InputNetworkMessageEvent e)
	{
		CommandComponent msg = new CommandComponent();
		{
			Dictionary<string, object> data2 = (Dictionary<string, object>)e.Data["movedir"];
			SyncVector3 tmp2 = new SyncVector3();
			tmp2.x = (int)data2["x"];
			tmp2.y = (int)data2["y"];
			tmp2.z = (int)data2["z"];
			msg.moveDir = tmp2;
		}
		{
			Dictionary<string, object> data2 = (Dictionary<string, object>)e.Data["skilldir"];
			SyncVector3 tmp2 = new SyncVector3();
			tmp2.x = (int)data2["x"];
			tmp2.y = (int)data2["y"];
			tmp2.z = (int)data2["z"];
			msg.skillDir = tmp2;
		}
		msg.element1 = (int)e.Data["element1"];
		msg.element2 = (int)e.Data["element2"];
		msg.isFire = (bool)e.Data["isfire"];
		msg.id = (int)e.Data["id"];
		msg.frame = (int)e.Data["frame"];
		msg.time = (int)e.Data["time"];
		msg.isEnable = (bool)e.Data["isenable"];
		
		GlobalEvent.DispatchTypeEvent(msg);
	}
	static void RecevicePlayerBuyCharacter_c(InputNetworkMessageEvent e)
	{
		PlayerBuyCharacter_c msg = new PlayerBuyCharacter_c();
		msg.code = (int)e.Data["code"];
		
		GlobalEvent.DispatchTypeEvent(msg);
	}
	static void RecevicePlayerLoginMsg_c(InputNetworkMessageEvent e)
	{
		PlayerLoginMsg_c msg = new PlayerLoginMsg_c();
		msg.code = (int)e.Data["code"];
		msg.characterID = e.Data["characterid"].ToString();
		msg.ownCharacter = (List<String>)e.Data["owncharacter"];
		msg.coin = (int)e.Data["coin"];
		msg.diamond = (int)e.Data["diamond"];
		
		GlobalEvent.DispatchTypeEvent(msg);
	}
	static void RecevicePlayerMatchMsg_c(InputNetworkMessageEvent e)
	{
		PlayerMatchMsg_c msg = new PlayerMatchMsg_c();
		msg.predictTime = (int)e.Data["predicttime"];
		msg.isMatched = (bool)e.Data["ismatched"];
		
		GlobalEvent.DispatchTypeEvent(msg);
	}
	static void RecevicePlayerRename_c(InputNetworkMessageEvent e)
	{
		PlayerRename_c msg = new PlayerRename_c();
		msg.code = (int)e.Data["code"];
		msg.newName = e.Data["newname"].ToString();
		
		GlobalEvent.DispatchTypeEvent(msg);
	}
	static void RecevicePlayerResurgence_c(InputNetworkMessageEvent e)
	{
		PlayerResurgence_c msg = new PlayerResurgence_c();
		
		GlobalEvent.DispatchTypeEvent(msg);
	}
	static void RecevicePlayerSelectCharacter_c(InputNetworkMessageEvent e)
	{
		PlayerSelectCharacter_c msg = new PlayerSelectCharacter_c();
		msg.code = (int)e.Data["code"];
		
		GlobalEvent.DispatchTypeEvent(msg);
	}
	static void RecevicePlayerSettlement_c(InputNetworkMessageEvent e)
	{
		PlayerSettlement_c msg = new PlayerSettlement_c();
		msg.rank = (int)e.Data["rank"];
		msg.score = (int)e.Data["score"];
		msg.historicalHighest = (int)e.Data["historicalhighest"];
		msg.diamond = (int)e.Data["diamond"];
		
		GlobalEvent.DispatchTypeEvent(msg);
	}
	#endregion
}
