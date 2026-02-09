using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Polytoria.Creator.PropertyGrid
{
	public abstract class PropertyGridItem : MonoBehaviour
	{
		private PropertyInfo property;

		protected object currentValue;

		protected bool editingMultipleValues;

		public event Action<object> PropertyChanged
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

		public virtual void SetProperty(PropertyInfo property)
		{
		}

		public abstract void SetValue(object value);

		protected virtual void InvokeValueChanged(object value)
		{
		}
	}
}
