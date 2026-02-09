using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	public class MeshVertexChunkCollectionDb : Singleton<MeshVertexChunkCollectionDb>, IEnumerable<MeshVertexChunkCollection>, IEnumerable
	{
		private List<MeshVertexChunkCollection> _vertexChunkCollections;

		private Dictionary<Mesh, MeshVertexChunkCollection> _meshToVChunkCollection;

		public int Count => 0;

		public MeshVertexChunkCollection this[int collectionIndex] => null;

		public MeshVertexChunkCollection this[Mesh mesh] => null;

		public IEnumerator<MeshVertexChunkCollection> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public bool HasChunkCollectionForMesh(Mesh mesh)
		{
			return false;
		}

		private bool CreateMeshVertChunkCollection(Mesh mesh)
		{
			return false;
		}
	}
}
