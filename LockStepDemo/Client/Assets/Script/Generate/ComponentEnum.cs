using UnityEngine;

//自动生成请勿更改

public enum ComponentEnum
 {
	AnimComponent = 0,
	HealthBarComponent = 1,
	OperationWindowComponent = 2,
	PerfabComponent = 3,
	BuffEffectComponent = 4,
	SkillBehaviorCompoent = 5,
	BlowFlyComponent = 6,
	BuffComponent = 7,
	CDComponent = 8,
	LifeComponent = 9,
	LifeSpanComponent = 10,
	MoveComponent = 11,
	PlayerComponent = 12,
	SkillStatusComponent = 13,
	PlayerCameraComponent = 14,
	EntityRecordComponent = 15,
	ConnectStatusComponent = 16,
	GameDataCacheComponent = 17,
	ServerCacheComponent = 18,
	GameTimeComponent = 19,
	RankComponent = 20,
	CommandComponent = 21,
	PlayerCommandRecordComponent = 22,
	RealPlayerComponent = 23,
	SelfComponent = 24,
	ConnectionComponent = 25,
	WaitSyncComponent = 26,
	SyncComponent = 27,
	TheirComponent = 28,
	AssetComponent = 29,
	BlockComponent = 30,
	CampComponent = 31,
	CollisionComponent = 32,
	FlyObjectComponent = 33,
	InputComponent = 34,
	ItemComponent = 35,
	ItemCreatePointComponent = 36,
	TransfromComponent = 37
 	 }
public class ComponentHelper
 {
public static ComponentBase GetInstance(ComponentEnum type)
 {
switch (type)
 {
	case  ComponentEnum.AnimComponent:
	return  new AnimComponent();
	case  ComponentEnum.HealthBarComponent:
	return  new HealthBarComponent();
	case  ComponentEnum.OperationWindowComponent:
	return  new OperationWindowComponent();
	case  ComponentEnum.PerfabComponent:
	return  new PerfabComponent();
	case  ComponentEnum.BuffEffectComponent:
	return  new BuffEffectComponent();
	case  ComponentEnum.SkillBehaviorCompoent:
	return  new SkillBehaviorCompoent();
	case  ComponentEnum.BlowFlyComponent:
	return  new BlowFlyComponent();
	case  ComponentEnum.BuffComponent:
	return  new BuffComponent();
	case  ComponentEnum.CDComponent:
	return  new CDComponent();
	case  ComponentEnum.LifeComponent:
	return  new LifeComponent();
	case  ComponentEnum.LifeSpanComponent:
	return  new LifeSpanComponent();
	case  ComponentEnum.MoveComponent:
	return  new MoveComponent();
	case  ComponentEnum.PlayerComponent:
	return  new PlayerComponent();
	case  ComponentEnum.SkillStatusComponent:
	return  new SkillStatusComponent();
	case  ComponentEnum.PlayerCameraComponent:
	return  new PlayerCameraComponent();
	case  ComponentEnum.EntityRecordComponent:
	return  new EntityRecordComponent();
	case  ComponentEnum.ConnectStatusComponent:
	return  new ConnectStatusComponent();
	case  ComponentEnum.GameDataCacheComponent:
	return  new GameDataCacheComponent();
	case  ComponentEnum.ServerCacheComponent:
	return  new ServerCacheComponent();
	case  ComponentEnum.GameTimeComponent:
	return  new GameTimeComponent();
	case  ComponentEnum.RankComponent:
	return  new RankComponent();
	case  ComponentEnum.CommandComponent:
	return  new CommandComponent();
	case  ComponentEnum.PlayerCommandRecordComponent:
	return  new PlayerCommandRecordComponent();
	case  ComponentEnum.RealPlayerComponent:
	return  new RealPlayerComponent();
	case  ComponentEnum.SelfComponent:
	return  new SelfComponent();
	case  ComponentEnum.ConnectionComponent:
	return  new ConnectionComponent();
	case  ComponentEnum.WaitSyncComponent:
	return  new WaitSyncComponent();
	case  ComponentEnum.SyncComponent:
	return  new SyncComponent();
	case  ComponentEnum.TheirComponent:
	return  new TheirComponent();
	case  ComponentEnum.AssetComponent:
	return  new AssetComponent();
	case  ComponentEnum.BlockComponent:
	return  new BlockComponent();
	case  ComponentEnum.CampComponent:
	return  new CampComponent();
	case  ComponentEnum.CollisionComponent:
	return  new CollisionComponent();
	case  ComponentEnum.FlyObjectComponent:
	return  new FlyObjectComponent();
	case  ComponentEnum.InputComponent:
	return  new InputComponent();
	case  ComponentEnum.ItemComponent:
	return  new ItemComponent();
	case  ComponentEnum.ItemCreatePointComponent:
	return  new ItemCreatePointComponent();
	case  ComponentEnum.TransfromComponent:
	return  new TransfromComponent();
 	 }
 return null;
 }
 }
