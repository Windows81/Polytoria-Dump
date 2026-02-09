using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	public class SceneTree
	{
		private SphereTree<GameObject> _objectTree;

		private Dictionary<GameObject, SphereTreeNode<GameObject>> _objectToNode;

		private List<SphereTreeNodeRayHit<GameObject>> _nodeHitBuffer;

		private List<SphereTreeNode<GameObject>> _nodeBuffer;

		public GameObjectRayHit RaycastMeshObject(Ray ray, GameObject gameObject)
		{
			return null;
		}

		public GameObjectRayHit RaycastSpriteObject(Ray ray, GameObject gameObject)
		{
			return null;
		}

		public bool RaycastAll(Ray ray, SceneRaycastPrecision raycastPresicion, List<GameObjectRayHit> hits)
		{
			return false;
		}

		public bool OverlapBox(OBB obb, List<GameObject> gameObjects)
		{
			return false;
		}

		public bool IsObjectRegistered(GameObject gameObject)
		{
			return false;
		}

		public bool RegisterObject(GameObject gameObject)
		{
			return false;
		}

		public bool UnregisterObject(GameObject gameObject)
		{
			return false;
		}

		public void OnObjectTransformChanged(Transform objectTransform)
		{
		}

		public void RemoveNodesWithNullObjects()
		{
		}

		public void DebugDraw()
		{
		}

		private bool CanRegisterObject(GameObject gameObject)
		{
			return false;
		}
	}
}
