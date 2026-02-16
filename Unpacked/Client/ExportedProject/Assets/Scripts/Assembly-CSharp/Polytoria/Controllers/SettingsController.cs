using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace Polytoria.Controllers
{
	public class SettingsController : MonoBehaviour
	{
		public static SettingsController instance;

		[SerializeField]
		private RectTransform audioContainer;

		[SerializeField]
		private RectTransform graphicsContainer;

		[SerializeField]
		private RectTransform inputContainer;

		[SerializeField]
		private RectTransform miscContainer;

		[SerializeField]
		private PostProcessLayer postProcessLayer;

		public RectTransform[] containers;

		private const int DefaultQualityLevel = 5;

		private const int DefaultUISize = 2;

		private const float DefaultMouseSensitivity = 1f;

		private const float DefaultMasterVolume = 1f;

		private void Awake()
		{
		}

		public void Load()
		{
		}

		public void SetSettingsCategory(int index)
		{
		}

		public void LoadSettings()
		{
		}

		private void ReloadControls()
		{
		}

		private void ReloadInputControls()
		{
		}

		private void ReloadMiscControls()
		{
		}

		private void ReloadAudioControls()
		{
		}

		private void ReloadGraphicsControls()
		{
		}

		public void SetMouseSensitivity(float sensitivity)
		{
		}

		public void SetDebugLogLength(string slength)
		{
		}

		public void SetUISize(int sizeLevel)
		{
		}

		public void SetFullscreen(bool fullscreen)
		{
		}

		public void SetQualityLevel(int qualityLevel)
		{
		}

		public void SetPixelLightCount(float pixelLightCount)
		{
		}

		public void SetShadowDistance(float shadowDistance)
		{
		}

		public void SetShadowResolution(int shadowResolution)
		{
		}

		public void SetTextureQuality(int textureQuality)
		{
		}

		public void SetVSync(int vSync)
		{
		}

		public void SetAntiAliasing(int antiAliasing)
		{
		}

		public void SetAnisotropicFiltering(int anisotropicFiltering)
		{
		}

		public void SetPostProcessing(bool postProcessing)
		{
		}

		public void SetMasterVolume(float volume)
		{
		}
	}
}
