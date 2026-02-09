using System.Collections.Generic;
using MoonSharp.Interpreter;
using Polytoria.Lua;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	public class EnvironmentProxy : InstanceProxy
	{
		private readonly Environment environment;

		public SkyboxPreset Skybox
		{
			get
			{
				return default(SkyboxPreset);
			}
			set
			{
			}
		}

		public Vector3 Gravity
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public bool FogEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float FogStartDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float FogEndDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Color FogColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public float PartDestroyHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool AutoGenerateNavMesh
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[MoonSharpHidden]
		public EnvironmentProxy(Environment target)
			: base(null)
		{
		}

		[LuaCallbackParameter("callback", typeof(Instance), "hit", false)]
		public void CreateExplosion(Vector3 position, float radius = 10f, float force = 5000f, bool affectKinematic = true, DynValue callback = null, float damage = 10000f)
		{
		}

		public RayResult? Raycast(Vector3 origin, Vector3 direction, float maxDistance = 1f / 0f, List<Instance> ignoreList = null)
		{
			return null;
		}

		public RayResult[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance = 1f / 0f, List<Instance> ignoreList = null)
		{
			return null;
		}

		public Instance[] OverlapSphere(Vector3 position, float radius, List<Instance> ignoreList = null)
		{
			return null;
		}

		public Instance[] OverlapBox(Vector3 center, Vector3 halfExtents, Vector3 rotation, List<Instance> ignoreList = null)
		{
			return null;
		}

		public void RebuildNavMesh(Instance root)
		{
		}

		public Vector3 GetPointOnNavMesh(Vector3 position, float maxDistance = 100f)
		{
			return default(Vector3);
		}
	}
}
