using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Polytoria.UI
{
	public class UICommandList : MonoBehaviour
	{
		public static bool IsActive;

		public static SlashCommand ActiveCommand;

		public static bool ActiveCommandFilled;

		private Transform container;

		private Transform listContainer;

		private Transform emptyContainer;

		private ScrollRect scrollRect;

		public SlashCommand[] commands;

		private List<Transform> commandObjects;

		[SerializeField]
		private int curActive;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public void SetActive(bool active)
		{
		}

		public void AddObject(SlashCommand cmd)
		{
		}

		public void Search(string Text)
		{
		}
	}
}
