using System.Collections.Generic;
using System.Reflection;
using Polytoria.Datamodel;
using UnityEngine;

namespace Polytoria.Creator.PropertyGrid
{
	public class CreatorPropertyGrid : MonoBehaviour
	{
		private Vector2 scrollPosition;

		private RectTransform content;

		private Dictionary<string, PropertyGridItem> items;

		private List<Instance> instances;

		private void Awake()
		{
		}

		public void SetPropertyGridItems(List<Instance> instances)
		{
		}

		public void Clear()
		{
		}

		private void AddPropertyItem(PropertyInfo property)
		{
		}

		private void OnValueChanged(PropertyInfo property, object value)
		{
		}
	}
}
