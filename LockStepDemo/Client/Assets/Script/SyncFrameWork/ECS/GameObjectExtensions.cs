using System;
using System.Linq;
using UnityEngine;

public static class GameObjectExtensions
{
	
	
	/// <summary>
	/// 手动创建物体与实体的联系
	/// </summary>
	/// <param name="obj"></param>
	/// <param name="world"></param>
	/// <param name="comps"></param>
	/// <returns></returns>
	public static EntityBase CreateEntity(this GameObject obj,WorldBase world, params ComponentBase[] comps)
	{
		var entity = world.CreateEntity(obj, comps);
		return entity;
	}
	
	/// <summary>
	/// 根据物体身上获取的脚本类型自动设定实体
	/// </summary>
	/// <param name="obj"></param>
	/// <param name="world"></param>
	/// <returns></returns>
	public static EntityBase AutoCreateEntity(this GameObject obj,WorldBase world)
	{
		ComponentBase[] comps = obj.AutoGetComponentBase();
		var entity = world.CreateEntity(obj, comps);
		return entity;
	}

	/// <summary>
	/// 根据物体挂载的脚本类型自动生成对应实体
	/// </summary>
	/// <param name="obj"></param>
	/// <returns></returns>
	public static ComponentBase[] AutoGetComponentBase (this GameObject obj)
	{
		var monoBase = obj.GetComponent<MonoBase>();
		return monoBase.GetComponents();
	}
}
