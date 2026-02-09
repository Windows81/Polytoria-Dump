using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	public class EditorPrefabPreviewGen
	{
		private enum PreviewObjectType
		{
			Mesh = 1,
			Sprite = 2,
			Light = 3,
			ParticleSystem = 4,
			Other = 5
		}

		private PrefabPreviewLookAndFeel _previewLookAndFeel;

		private ObjectBounds.QueryConfig _boundsQConfig;

		private Light _previewLight;

		private Camera _renderCamera;

		private bool _isGenSessionActive;

		private Dictionary<Light, bool> _lightToState;

		private GameObject _nonMeshPreviewObject;

		public bool BeginGenSession(PrefabPreviewLookAndFeel previewLookAndFeel)
		{
			return false;
		}

		public void EndGenSession()
		{
		}

		public Texture2D Generate(GameObject unityPrefab)
		{
			return null;
		}

		private bool CreateRenderCamera()
		{
			return false;
		}

		private bool CreatePreviewLight()
		{
			return false;
		}

		private void CreateNonMeshPreviewObject()
		{
		}

		private void DisableSceneLights()
		{
		}

		private void RestoreSceneLights()
		{
		}
	}
}
