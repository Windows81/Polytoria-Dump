using UnityEngine;

namespace RLD
{
	public class PrefabSpawnSnap : MonoBehaviour
	{
		private bool _isSnapSessionActive;

		private GameObject _targetHierarchy;

		private ObjectSurfaceSnap.SnapConfig _snapConfig;

		private int _objectSurfaceLayers;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private bool EvaluateSessionEndCondition()
		{
			return false;
		}

		private void OnInputDeviceMoved(IInputDevice inputDevice)
		{
		}

		private void BeginSnapSession(GameObject targetHierarchy)
		{
		}

		private void EndSnapSession()
		{
		}

		private void OnAppInitialized()
		{
		}

		private void OnPrefabSpawned(RTPrefab prefab, GameObject spawnedObject)
		{
		}

		private void OnCanChangeObjectSelection(YesNoAnswer answer)
		{
		}
	}
}
