using UnityEngine;
using UnityEngine.UI;

namespace namudev
{
	public class PropertyGridColor : PropertyGridItem<Color>
	{
		private GameObject caption;

		private GameObject inputFieldR;

		private GameObject inputFieldG;

		private GameObject inputFieldB;

		private GameObject inputFieldA;

		private GameObject inputFieldHex;

		private Image colorDisplayer;

		private Button colorDisplayerBtn;

		protected override void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Start()
		{
		}

		private void OnColorBtnClick()
		{
		}

		private void OnValueChange(Color color)
		{
		}

		private void OnValueChangeHex(string hexColor)
		{
		}

		private void OnEndEditHex(string str)
		{
		}

		private void OnValueChangeR(string str)
		{
		}

		private void OnEndEditR(string str)
		{
		}

		private void OnValueChangeG(string str)
		{
		}

		private void OnEndEditG(string str)
		{
		}

		private void OnValueChangeB(string str)
		{
		}

		private void OnEndEditB(string str)
		{
		}

		private void OnValueChangeA(string str)
		{
		}

		private void OnEndEditA(string str)
		{
		}
	}
}
