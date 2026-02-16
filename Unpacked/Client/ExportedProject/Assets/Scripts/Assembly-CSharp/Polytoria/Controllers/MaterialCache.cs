using System.Collections.Generic;
using Polytoria.Datamodel;
using UnityEngine;

namespace Polytoria.Controllers
{
	public class MaterialCache : MonoBehaviour
	{
		private struct MaterialCacheEntry
		{
			public Material Opaque;

			public Material Transparent;
		}

		private Dictionary<PartMaterial, MaterialCacheEntry> materials;

		public static MaterialCache Instance { get; private set; }

		private void Awake()
		{
		}

		public Material GetMaterial(PartMaterial material, bool isTransparent = false)
		{
			return null;
		}
	}
}
