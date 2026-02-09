using MoonSharp.Interpreter;
using Polytoria.Controllers;
using Polytoria.Types;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	public class ParticlesProxy : DynamicInstanceProxy
	{
		private readonly Particles particles;

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

		public ColorRange Color
		{
			get
			{
				return default(ColorRange);
			}
			set
			{
			}
		}

		public ParticleColorMode ColorMode
		{
			get
			{
				return default(ParticleColorMode);
			}
			set
			{
			}
		}

		public NumberRange Lifetime
		{
			get
			{
				return default(NumberRange);
			}
			set
			{
			}
		}

		public NumberRange SizeOverLifetime
		{
			get
			{
				return default(NumberRange);
			}
			set
			{
			}
		}

		public NumberRange Speed
		{
			get
			{
				return default(NumberRange);
			}
			set
			{
			}
		}

		public int EmissionRate
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int MaxParticles
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float Gravity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public ParticleSimulationSpace SimulationSpace
		{
			get
			{
				return default(ParticleSimulationSpace);
			}
			set
			{
			}
		}

		public NumberRange StartRotation
		{
			get
			{
				return default(NumberRange);
			}
			set
			{
			}
		}

		public NumberRange AngularVelocity
		{
			get
			{
				return default(NumberRange);
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

		public float Duration
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public ParticleShape Shape
		{
			get
			{
				return default(ParticleShape);
			}
			set
			{
			}
		}

		public float ShapeRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float ShapeAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector3 ShapeScale
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public bool IsPlaying => false;

		public bool IsPaused => false;

		public bool IsStopped => false;

		public int ParticleCount => 0;

		public float Time => 0f;

		public float TotalTime => 0f;

		[MoonSharpHidden]
		public ParticlesProxy(Particles target)
			: base(null)
		{
		}

		public void Play()
		{
		}

		public void Pause()
		{
		}

		public void Stop()
		{
		}

		public void Clear()
		{
		}

		public void Emit(int count)
		{
		}

		public void Simulate(float time)
		{
		}
	}
}
