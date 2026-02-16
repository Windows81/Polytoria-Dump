using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Polytoria.UI
{
	public class UICommandListItem : MonoBehaviour
	{
		private static List<Sprite> commandIcons;

		private static List<Sprite> commandIconsActive;

		private static Sprite contSprite;

		private static Sprite contSpriteActive;

		private static bool loaded;

		private Image cont;

		private Image icon;

		private TMP_Text nameT;

		private TMP_Text description;

		private SlashCommand cmd;

		private bool active;

		private void Awake()
		{
		}

		public void SetCommand(SlashCommand cmd)
		{
		}

		public void SetActive(bool active)
		{
		}
	}
}
