using UnityEngine;

//自动生成请勿更改

public  partial class ComponentType :ComponentTypeBase
 {
	 public const int AnimComponent = 0;
	 public const int HealthBarComponent = 1;
	 public const int OperationWindowComponent = 2;
	 public const int PerfabComponent = 3;
	 public const int BuffEffectComponent = 4;
	 public const int SkillBehaviorCompoent = 5;
	 public const int AIComponentBase = 6;
	 public const int BlowFlyComponent = 7;
	 public const int BuffComponent = 8;
	 public const int CDComponent = 9;
	 public const int LifeComponent = 10;
	 public const int LifeSpanComponent = 11;
	 public const int MoveComponent = 12;
	 public const int PlayerComponent = 13;
	 public const int SkillStatusComponent = 14;
	 public const int PlayerCameraComponent = 15;
	 public const int EntityRecordComponent = 16;
	 public const int RecordComponent_T = 17;
	 public const int ConnectStatusComponent = 18;
	 public const int GameDataCacheComponent = 19;
	 public const int ServerCacheComponent = 20;
	 public const int GameTimeComponent = 21;
	 public const int RankComponent = 22;
	 public const int SyncComponentBase = 23;
	 public const int PlayerCommandBase = 24;
	 public const int CommandComponent = 25;
	 public const int PlayerCommandRecordComponent = 26;
	 public const int RealPlayerComponent = 27;
	 public const int SelfComponent = 28;
	 public const int ServiceComponent = 29;
	 public const int WaitSyncComponent = 30;
	 public const int SyncComponent = 31;
	 public const int TheirComponent = 32;
	 public const int AssetComponent = 33;
	 public const int BlockComponent = 34;
	 public const int CampComponent = 35;
	 public const int CollisionComponent = 36;
	 public const int FlyObjectComponent = 37;
	 public const int InputComponent = 38;
	 public const int ItemComponent = 39;
	 public const int ItemCreatePointComponent = 40;
	 public const int TransfromComponent = 41;
	public override int Count()
	  {
		 return 42;
	   }



	 public override int GetComponentIndex(string name) 
	 {
		 switch (name) 
		 {

			 case "AnimComponent" : 
				 return AnimComponent ; 
			 case "HealthBarComponent" : 
				 return HealthBarComponent ; 
			 case "OperationWindowComponent" : 
				 return OperationWindowComponent ; 
			 case "PerfabComponent" : 
				 return PerfabComponent ; 
			 case "BuffEffectComponent" : 
				 return BuffEffectComponent ; 
			 case "SkillBehaviorCompoent" : 
				 return SkillBehaviorCompoent ; 
			 case "AIComponentBase" : 
				 return AIComponentBase ; 
			 case "BlowFlyComponent" : 
				 return BlowFlyComponent ; 
			 case "BuffComponent" : 
				 return BuffComponent ; 
			 case "CDComponent" : 
				 return CDComponent ; 
			 case "LifeComponent" : 
				 return LifeComponent ; 
			 case "LifeSpanComponent" : 
				 return LifeSpanComponent ; 
			 case "MoveComponent" : 
				 return MoveComponent ; 
			 case "PlayerComponent" : 
				 return PlayerComponent ; 
			 case "SkillStatusComponent" : 
				 return SkillStatusComponent ; 
			 case "PlayerCameraComponent" : 
				 return PlayerCameraComponent ; 
			 case "EntityRecordComponent" : 
				 return EntityRecordComponent ; 
			 case "RecordComponent_T" : 
				 return RecordComponent_T ; 
			 case "ConnectStatusComponent" : 
				 return ConnectStatusComponent ; 
			 case "GameDataCacheComponent" : 
				 return GameDataCacheComponent ; 
			 case "ServerCacheComponent" : 
				 return ServerCacheComponent ; 
			 case "GameTimeComponent" : 
				 return GameTimeComponent ; 
			 case "RankComponent" : 
				 return RankComponent ; 
			 case "SyncComponentBase" : 
				 return SyncComponentBase ; 
			 case "PlayerCommandBase" : 
				 return PlayerCommandBase ; 
			 case "CommandComponent" : 
				 return CommandComponent ; 
			 case "PlayerCommandRecordComponent" : 
				 return PlayerCommandRecordComponent ; 
			 case "RealPlayerComponent" : 
				 return RealPlayerComponent ; 
			 case "SelfComponent" : 
				 return SelfComponent ; 
			 case "ServiceComponent" : 
				 return ServiceComponent ; 
			 case "WaitSyncComponent" : 
				 return WaitSyncComponent ; 
			 case "SyncComponent" : 
				 return SyncComponent ; 
			 case "TheirComponent" : 
				 return TheirComponent ; 
			 case "AssetComponent" : 
				 return AssetComponent ; 
			 case "BlockComponent" : 
				 return BlockComponent ; 
			 case "CampComponent" : 
				 return CampComponent ; 
			 case "CollisionComponent" : 
				 return CollisionComponent ; 
			 case "FlyObjectComponent" : 
				 return FlyObjectComponent ; 
			 case "InputComponent" : 
				 return InputComponent ; 
			 case "ItemComponent" : 
				 return ItemComponent ; 
			 case "ItemCreatePointComponent" : 
				 return ItemCreatePointComponent ; 
			 case "TransfromComponent" : 
				 return TransfromComponent ; 
		 }
	  Debug.Log("未找到对应的组件 ：" + name); 
	 return -1 ; 
 	 }
}
