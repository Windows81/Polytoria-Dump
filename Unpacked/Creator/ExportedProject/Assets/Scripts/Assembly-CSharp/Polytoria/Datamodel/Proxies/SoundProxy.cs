using MoonSharp.Interpreter;
using Polytoria.Lua;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	public class SoundProxy : DynamicInstanceProxy
	{
		private readonly Sound sound;

		public bool Playing => false;

		public int SoundID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float Pitch
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Length => 0f;

		public new Vector3 Size
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public new Vector3 Rotation
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public float Time
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool Autoplay
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Loop
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool PlayInWorld
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float Volume
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float MaxDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool Loading => false;

		public LuaEvent Loaded => null;

		[MoonSharpHidden]
		public SoundProxy(Sound target)
			: base(null)
		{
		}

		public void Play()
		{
		}

		public void PlayOneShot(float volume = 1f)
		{
		}

		public void Stop()
		{
		}
	}
}
