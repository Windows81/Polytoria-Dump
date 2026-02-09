using System;
using System.Runtime.InteropServices;
using Mirror;
using Polytoria.Controllers;
using UnityEngine;

namespace Polytoria.Datamodel
{
	[Instantiatable]
	[RequireComponent(typeof(MeshRenderer))]
	public class Decal : DynamicInstance
	{
		[SyncVar(hook = "SetImage")]
		private string imageID;

		[SyncVar(hook = "SetImageType")]
		private ImageType imageType;

		[SyncVar(hook = "SetTextureScale")]
		private Vector2 textureScale;

		[SyncVar(hook = "SetTextureOffset")]
		private Vector2 textureOffset;

		[SyncVar(hook = "SetColor")]
		private Color color;

		[SyncVar(hook = "SetCastShadows")]
		private bool castShadows;

		private ImageCacheKey lastCacheKey;

		private BoxCollider col;

		private MeshRenderer meshRenderer;

		private ImageCacheEntry currentEntry;

		private Material transparentMaterial;

		private Material cutoutMaterial;

		public Action<string, string> _Mirror_SyncVarHookDelegate_imageID;

		public Action<ImageType, ImageType> _Mirror_SyncVarHookDelegate_imageType;

		public Action<Vector2, Vector2> _Mirror_SyncVarHookDelegate_textureScale;

		public Action<Vector2, Vector2> _Mirror_SyncVarHookDelegate_textureOffset;

		public Action<Color, Color> _Mirror_SyncVarHookDelegate_color;

		public Action<bool, bool> _Mirror_SyncVarHookDelegate_castShadows;

		[CreatorProperty]
		[Archivable]
		public string ImageID
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[CreatorProperty]
		[Archivable]
		public ImageType ImageType
		{
			get
			{
				return default(ImageType);
			}
			set
			{
			}
		}

		[CreatorProperty]
		[Archivable]
		public Vector2 TextureScale
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		[CreatorProperty]
		[Archivable]
		public Vector2 TextureOffset
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		[CreatorProperty]
		[Archivable]
		public Color Color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		[CreatorProperty]
		[Archivable]
		public bool CastShadows
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string NetworkimageID
		{
			get
			{
				return null;
			}
			[param: In]
			set
			{
			}
		}

		public ImageType NetworkimageType
		{
			get
			{
				return default(ImageType);
			}
			[param: In]
			set
			{
			}
		}

		public Vector2 NetworktextureScale
		{
			get
			{
				return default(Vector2);
			}
			[param: In]
			set
			{
			}
		}

		public Vector2 NetworktextureOffset
		{
			get
			{
				return default(Vector2);
			}
			[param: In]
			set
			{
			}
		}

		public Color Networkcolor
		{
			get
			{
				return default(Color);
			}
			[param: In]
			set
			{
			}
		}

		public bool NetworkcastShadows
		{
			get
			{
				return false;
			}
			[param: In]
			set
			{
			}
		}

		private void SetTextureScale(Vector2 oldScale, Vector2 newScale)
		{
		}

		private void SetTextureOffset(Vector2 oldOffset, Vector2 newOffset)
		{
		}

		private void SetCastShadows(bool oldShadows, bool newShadows)
		{
		}

		protected override void OnHide()
		{
		}

		protected override void OnShow()
		{
		}

		private void SetImage(string oldId, string newId)
		{
		}

		private void SetImageType(ImageType oldType, ImageType newType)
		{
		}

		private void SetColor(Color oldColor, Color newColor)
		{
		}

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected override void Update()
		{
		}

		private void GetImage()
		{
		}

		protected override void CopyProperties(Instance clone)
		{
		}

		public override bool Weaved()
		{
			return false;
		}

		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}
	}
}
