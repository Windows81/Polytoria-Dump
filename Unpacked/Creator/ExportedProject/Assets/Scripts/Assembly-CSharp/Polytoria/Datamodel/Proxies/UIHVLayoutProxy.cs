using MoonSharp.Interpreter;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	public class UIHVLayoutProxy : UIFieldProxy
	{
		private readonly UIHVLayout uiHVLayout;

		public float Spacing
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool ChildControlWidth
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ChildControlHeight
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ChildScaleWidth
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ChildScaleHeight
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ChildForceExpandWidth
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ChildForceExpandHeight
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int PaddingLeft
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int PaddingRight
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int PaddingTop
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int PaddingBottom
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public TextAnchor ChildAlignment
		{
			get
			{
				return default(TextAnchor);
			}
			set
			{
			}
		}

		public bool ReverseAlignment
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
		public UIHVLayoutProxy(UIHVLayout target)
			: base(null)
		{
		}
	}
}
