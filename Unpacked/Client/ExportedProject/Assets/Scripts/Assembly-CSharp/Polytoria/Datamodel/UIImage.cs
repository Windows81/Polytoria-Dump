using System;
using System.Runtime.InteropServices;
using Mirror;
using Polytoria.Controllers;
using UnityEngine;
using UnityEngine.UI;

namespace Polytoria.Datamodel
{
	[Instantiatable]
	public class UIImage : UIField
	{
		private Image image;

		[SyncVar(hook = "SyncSetColor")]
		private Color color;

		[SyncVar(hook = "SetImage")]
		private string imageID;

		[SyncVar(hook = "SetImageType")]
		private ImageType imageType;

		[SyncVar(hook = "SyncSetClickable")]
		private bool clickable;

		private bool loading;

		private Texture2D texture;

		private ImageCacheKey lastCacheKey;

		public Action<Color, Color> _Mirror_SyncVarHookDelegate_color;

		public Action<string, string> _Mirror_SyncVarHookDelegate_imageID;

		public Action<ImageType, ImageType> _Mirror_SyncVarHookDelegate_imageType;

		public Action<bool, bool> _Mirror_SyncVarHookDelegate_clickable;

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

		public bool Loading => false;

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
		public bool Clickable
		{
			get
			{
				return false;
			}
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

		public bool Networkclickable
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

		private void SyncSetColor(Color oldValue, Color newValue)
		{
		}

		private void SetImage(string oldValue, string newValue)
		{
		}

		private void SetImageType(ImageType oldValue, ImageType newValue)
		{
		}

		private void SyncSetClickable(bool oldValue, bool newValue)
		{
		}

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void LoadFallback()
		{
		}

		private void GetImage()
		{
		}

		protected override void OnHide()
		{
		}

		protected override void OnShow()
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
