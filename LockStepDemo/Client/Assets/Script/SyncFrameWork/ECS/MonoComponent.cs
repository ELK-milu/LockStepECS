using UnityEngine;

/// <summary>
/// Component类型基类
/// </summary>
/// <typeparam name="T"></typeparam>
public class MonoComponent<T> : MonoBehaviour where T : ComponentBase
{
	public T m_component;
}
