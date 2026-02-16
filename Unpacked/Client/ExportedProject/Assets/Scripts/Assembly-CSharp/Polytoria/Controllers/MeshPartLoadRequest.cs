using System;
using Polytoria.Datamodel;

namespace Polytoria.Controllers
{
	public struct MeshPartLoadRequest
	{
		public int assetID;

		public MeshPart meshPart;

		public Action onComplete;

		public MeshPartLoadRequest(int assetID, MeshPart meshPart, Action onLoadComplete = null)
		{
			this.assetID = 0;
			this.meshPart = null;
			onComplete = null;
		}
	}
}
