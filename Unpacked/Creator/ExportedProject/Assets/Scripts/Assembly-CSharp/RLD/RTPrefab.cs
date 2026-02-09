using System;
using UnityEngine;

namespace RLD
{
	[Serializable]
	public class RTPrefab
	{
		[SerializeField]
		private GameObject _unityPrefab;

		[SerializeField]
		private Texture2D _previewTexture;

		[NonSerialized]
		private Sprite _previewSprite;

		public GameObject UnityPrefab
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Texture2D PreviewTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Sprite PreviewSprite => null;

		public GameObject Instantiate()
		{
			return null;
		}

		public GameObject Instantiate(Vector3 worldPos, Quaternion worldRotation)
		{
			return null;
		}

		public GameObject Instantiate(Vector3 worldPos, Quaternion worldRotation, Vector3 worldScale)
		{
			return null;
		}
	}
}
