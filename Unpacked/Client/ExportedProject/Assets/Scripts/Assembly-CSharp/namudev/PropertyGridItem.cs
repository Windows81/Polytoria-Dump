using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace namudev
{
	public static class PropertyGridItem
	{
		public static Dictionary<Type, Type> TypeMap;

		static PropertyGridItem()
		{
		}
	}
	public abstract class PropertyGridItem<T> : MonoBehaviour
	{
		private PropertyGridBinding binding;

		public string Caption => null;

		public T Value
		{
			get
			{
				return default(T);
			}
			protected set
			{
			}
		}

		public Type ValueType => null;

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

		protected virtual void Awake()
		{
		}
	}
}
