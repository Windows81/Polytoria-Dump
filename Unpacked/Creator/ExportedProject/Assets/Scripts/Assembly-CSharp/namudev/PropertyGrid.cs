using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace namudev
{
	public class PropertyGrid : MonoBehaviour
	{
		[SerializeField]
		private GameObject targetObject;

		[SerializeField]
		private bool logging;

		private GameObject label;

		private GameObject scrollbar;

		private Dictionary<Type, GameObject> itemTemplateMap;

		private List<GameObject> items;

		public event Action<object, PropertyInfo> ValueChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void AppendLabel(string text)
		{
		}

		public T AppendProperty<T>(string caption, object value) where T : Component
		{
			return null;
		}

		public void Populate(object obj)
		{
		}

		public void Clear()
		{
		}

		private void Awake()
		{
		}

		private void AppendProperties(object obj, List<string> exclude = null)
		{
		}

		private void AppendProperty(object obj, PropertyInfo propertyInfo)
		{
		}

		private void Log(string message)
		{
		}
	}
}
