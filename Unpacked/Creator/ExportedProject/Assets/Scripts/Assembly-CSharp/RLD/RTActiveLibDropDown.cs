using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace RLD
{
	public class RTActiveLibDropDown : MonoBehaviour
	{
		private Dropdown _dropDown;

		private List<UnityAction<int>> _valueChangedListeners;

		public int ActiveLibIndex => 0;

		public void AddValueChangedListener(UnityAction<int> listener)
		{
		}

		public void SetActiveLibIndex(int activeLibIndex)
		{
		}

		public void ClearLibs()
		{
		}

		public void SyncWithLibDb()
		{
		}

		private void Awake()
		{
		}
	}
}
