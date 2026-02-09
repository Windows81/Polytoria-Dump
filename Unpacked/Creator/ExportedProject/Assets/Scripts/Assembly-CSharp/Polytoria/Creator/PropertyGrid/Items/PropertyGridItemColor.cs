using System.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.ProceduralImage;

namespace Polytoria.Creator.PropertyGrid.Items
{
	public class PropertyGridItemColor : PropertyGridItem
	{
		private ProceduralImage colorDisplayer;

		private Button colorDisplayerBtn;

		private TMP_InputField hexInput;

		private void Awake()
		{
		}

		public override void SetProperty(PropertyInfo property)
		{
		}

		private void OnColorDisplayerBtnClick()
		{
		}

		private void OnValueChange(Color color)
		{
		}

		private void OnHexInputValueChanged(string value)
		{
		}

		private void OnDestroy()
		{
		}

		public override void SetValue(object value)
		{
		}

		private void OnValueChanged(bool value)
		{
		}
	}
}
