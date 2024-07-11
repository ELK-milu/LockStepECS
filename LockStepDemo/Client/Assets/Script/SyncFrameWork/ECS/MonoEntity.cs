using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UnityEngine;

public abstract class MonoBase : MonoBehaviour
{
	protected ComponentBase[] _comps;
	public abstract ComponentBase[] GetComponents();
}

/// <summary>
/// 实体基类
/// </summary>
[RequireComponent(typeof(HardPointComponent))]
public class MonoEntity : MonoBase
{
	protected WorldBase _world;
	public EntityBase _selfEntity;
	[SerializeField]
	public ComponentEnum[] _components;
	private void Start()
	{
		_world = WorldManager.WorldList[0];
		_selfEntity = gameObject.AutoCreateEntity(_world);
	}

	public override ComponentBase[] GetComponents()
	{
		_comps = new ComponentBase[_components.Length];
		for (int i = 0; i < _components.Length; i++)
		{
			_comps[i] = ComponentHelper.GetInstance(_components[i]);
		}
		return _comps;
	}
	
}

