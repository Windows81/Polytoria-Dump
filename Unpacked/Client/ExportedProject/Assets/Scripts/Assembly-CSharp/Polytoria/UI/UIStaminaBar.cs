using UnityEngine;
using UnityEngine.UI;

namespace Polytoria.UI
{
	public class UIStaminaBar : MonoBehaviour
	{
		private const float fadeTime = 0.3f;

		private float _fadeStartTimer;

		private int fadeTimerState;

		private const float fadeStartTime = 0.3f;

		private Image fill;

		private Image cont;

		private float fillAmount;

		public Color FillColor;

		public Color FillExhaustedColor;

		private float alpha;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public void SetEnabled(bool enabled)
		{
		}

		public void SetFill(float newFillAmount, bool exhausted)
		{
		}
	}
}
