using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace RLD
{
	public class RTScene : MonoSingleton<RTScene>
	{
		public SceneCanRenderCameraIconHandler CanRenderCameraIcon;

		private YesNoAnswer _yesNoAnswer;

		[SerializeField]
		private SceneSettings _settings;

		[SerializeField]
		private SceneLookAndFeel _lookAndFeel;

		private List<Camera> _iconRenderIgnoreCamera;

		private HashSet<GameObject> _ignoredRootObjects;

		private List<IHoverableSceneEntityContainer> _hoverableSceneEntityContainers;

		private SceneTree _sceneTree;

		private List<GameObject> _rootGameObjects;

		private List<Light> _lights;

		private List<ParticleSystem> _particleSystems;

		private List<Camera> _cameras;

		private List<GameObject> _childrenAndSelfBuffer;

		private List<GameObjectRayHit> _objectHitBuffer;

		public SceneSettings Settings => null;

		public SceneLookAndFeel LookAndFeel => null;

		public void SetRootObjectIgnored(GameObject root, bool ignored)
		{
		}

		public void OnGameObjectWillBeDestroyed(GameObject gameObject)
		{
		}

		public void AddIconRenderIgnoreCamera(Camera camera)
		{
		}

		public bool IsIconRenderIgnoreCamera(Camera camera)
		{
			return false;
		}

		public AABB CalculateBounds()
		{
			return default(AABB);
		}

		public bool IsAnySceneEntityHovered()
		{
			return false;
		}

		public void RegisterHoverableSceneEntityContainer(IHoverableSceneEntityContainer container)
		{
		}

		public bool IsAnyUIElementHovered()
		{
			return false;
		}

		public List<RaycastResult> GetHoveredUIElements()
		{
			return null;
		}

		public GameObject[] GetSceneObjects()
		{
			return null;
		}

		public bool OverlapBox(OBB obb, List<GameObject> gameObjects)
		{
			return false;
		}

		public bool OverlapBox(OBB obb, SceneOverlapFilter overlapFilter, List<GameObject> gameObjects)
		{
			return false;
		}

		public SceneRaycastHit Raycast(Ray ray, SceneRaycastPrecision rtRaycastPrecision, SceneRaycastFilter raycastFilter)
		{
			return null;
		}

		public bool RaycastAllObjects(Ray ray, SceneRaycastPrecision rtRaycastPrecision, List<GameObjectRayHit> hits)
		{
			return false;
		}

		public bool RaycastAllObjectsSorted(Ray ray, SceneRaycastPrecision raycastPresicion, List<GameObjectRayHit> hits)
		{
			return false;
		}

		public bool RaycastAllObjectsSorted(Ray ray, SceneRaycastPrecision rtRaycastPrecision, SceneRaycastFilter raycastFilter, List<GameObjectRayHit> hits)
		{
			return false;
		}

		public GameObjectRayHit RaycastMeshObject(Ray ray, GameObject meshObject)
		{
			return null;
		}

		public GameObjectRayHit RaycastMeshObjectReverseIfFail(Ray ray, GameObject meshObject)
		{
			return null;
		}

		public GameObjectRayHit RaycastSpriteObject(Ray ray, GameObject spriteObject)
		{
			return null;
		}

		public XZGridRayHit RaycastSceneGridIfVisible(Ray ray)
		{
			return null;
		}

		public void Update_SystemCall()
		{
		}

		public void Render_SystemCall(Camera renderCamera)
		{
		}
	}
}
