using MoonSharp.Interpreter;
using Polytoria.Controllers;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	public class DecalProxy : DynamicInstanceProxy
	{
		private readonly Decal decal;

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

		[MoonSharpHidden]
		public DecalProxy(Decal target)
			: base(null)
		{
		}
	}
}
