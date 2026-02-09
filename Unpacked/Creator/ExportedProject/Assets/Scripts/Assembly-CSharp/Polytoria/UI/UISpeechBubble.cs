using TMPro;
using UnityEngine;

namespace Polytoria.UI
{
	public class UISpeechBubble : MonoBehaviour
	{
		private RectTransform chatContentRect;

		private RectTransform bubbleRect;

		private TMP_Text chatText;

		private string message;

		public Vector2 Padding;

		public float DisplayTime;

		private float targetOpacity;

		private float timer;

		private CanvasGroup canvasGroup;

		public string Message
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void Update()
		{
		}
	}
}
