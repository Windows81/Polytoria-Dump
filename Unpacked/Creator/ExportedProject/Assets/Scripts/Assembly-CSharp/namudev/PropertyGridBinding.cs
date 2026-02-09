using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace namudev
{
	public class PropertyGridBinding : MonoBehaviour
	{
		private object targetObject;

		private PropertyInfo propertyInfo;

		public string Caption { get; private set; }

		public object Value { get; private set; }

		public Type ValueType { get; private set; }

		public event EventHandler ValueChanged
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

		public void Initialize(string caption, object value, Type valueType)
		{
		}

		public void Initialize(object targetObject, PropertyInfo propertyInfo)
		{
		}

		public void SetValue(object value)
		{
		}
	}
}
