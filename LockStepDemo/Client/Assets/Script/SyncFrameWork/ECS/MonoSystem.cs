using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public abstract class MonoBase : MonoBehaviour
{
	public abstract Type[] GetFilter();
}

[CustomEditor(typeof(MonoBase))]
public class MonoSystemScriptEditor : Editor
{
	private List<string> options = new List<string>{"Option 1", "Option 2", "Option 3"};
	private List<bool> selections = new List<bool>();

	public override void OnInspectorGUI()
	{
		serializedObject.Update();

		EditorGUILayout.LabelField("MultiSelect:");

		for (int i = 0; i < options.Count; i++)
		{
			selections[i] = EditorGUILayout.ToggleLeft(options[i], selections[i]);
		}

		serializedObject.ApplyModifiedProperties();
	}

	private void OnEnable()
	{
		selections.Clear();
		for (int i = 0; i < options.Count; i++)
		{
			selections.Add(false);
		}
	}
}

/// <summary>
/// 使用前，在WorldBase中定义World中也使用该SystemBase，用于提前在WorldBase中写好ComponentGroup
/// </summary>
/// <typeparam name="T">SystemBase类型，用于定位该脚本使用的组件</typeparam>
[RequireComponent(typeof(HardPointComponent))]
public class MonoSystem<T> : MonoBase where T : SystemBase
{
	private T _system;
	protected WorldBase _world;
	public EntityBase _selfEntity;
	[SerializeField]
	public ComponentBase[] _components;
	private void Start()
	{
		_world = WorldManager.WorldList[0];
		_system = _world.m_systemList.Find((x => x.GetType() == typeof(T))) as T;
		_selfEntity = gameObject.SetEntity(_world);
	}

	public override Type[] GetFilter()
	{
		return _system.GetFilter();
	}
	
}

