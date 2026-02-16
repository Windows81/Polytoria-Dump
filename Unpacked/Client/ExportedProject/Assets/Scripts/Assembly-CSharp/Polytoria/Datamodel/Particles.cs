using System;
using System.Runtime.InteropServices;
using Mirror;
using Polytoria.Controllers;
using Polytoria.Types;
using UnityEngine;

namespace Polytoria.Datamodel
{
	[Instantiatable]
	[RequireComponent(typeof(ParticleSystem))]
	public class Particles : DynamicInstance
	{
		private ParticleSystem particles;

		[SyncVar(hook = "OnImageIDChanged")]
		private string imageID;

		[SyncVar(hook = "OnImageTypeChanged")]
		private ImageType imageType;

		[SyncVar(hook = "OnColorChanged")]
		private ColorRange color;

		[SyncVar(hook = "OnColorModeChanged")]
		private ParticleColorMode colorMode;

		[SyncVar(hook = "OnLifetimeChanged")]
		private NumberRange lifetime;

		[SyncVar(hook = "OnSizeOverLifetimeChanged")]
		private NumberRange sizeOverLifetime;

		[SyncVar(hook = "OnSpeedChanged")]
		private NumberRange speed;

		[SyncVar(hook = "OnEmissionRateChanged")]
		private int emissionRate;

		[SyncVar(hook = "OnMaxParticlesChanged")]
		private int maxParticles;

		[SyncVar(hook = "OnGravityChanged")]
		private float gravity;

		[SyncVar(hook = "OnSimulationSpaceChanged")]
		private ParticleSimulationSpace simulationSpace;

		[SyncVar(hook = "OnStartRotationChanged")]
		private NumberRange startRotation;

		[SyncVar(hook = "OnAngularVelocityChanged")]
		private NumberRange angularVelocity;

		[SyncVar(hook = "OnAutoplayChanged")]
		private bool autoplay;

		[SyncVar(hook = "OnLoopChanged")]
		private bool loop;

		[SyncVar(hook = "OnDurationChanged")]
		private float duration;

		[SyncVar(hook = "OnShapeChanged")]
		private ParticleShape shape;

		[SyncVar(hook = "OnShapeRadiusChanged")]
		private float shapeRadius;

		[SyncVar(hook = "OnShapeAngleChanged")]
		private float shapeAngle;

		[SyncVar(hook = "OnShapeScaleChanged")]
		private Vector3 shapeScale;

		private ImageCacheKey lastCacheKey;

		private ImageCacheEntry currentEntry;

		public Action<string, string> _Mirror_SyncVarHookDelegate_imageID;

		public Action<ImageType, ImageType> _Mirror_SyncVarHookDelegate_imageType;

		public Action<ColorRange, ColorRange> _Mirror_SyncVarHookDelegate_color;

		public Action<ParticleColorMode, ParticleColorMode> _Mirror_SyncVarHookDelegate_colorMode;

		public Action<NumberRange, NumberRange> _Mirror_SyncVarHookDelegate_lifetime;

		public Action<NumberRange, NumberRange> _Mirror_SyncVarHookDelegate_sizeOverLifetime;

		public Action<NumberRange, NumberRange> _Mirror_SyncVarHookDelegate_speed;

		public Action<int, int> _Mirror_SyncVarHookDelegate_emissionRate;

		public Action<int, int> _Mirror_SyncVarHookDelegate_maxParticles;

		public Action<float, float> _Mirror_SyncVarHookDelegate_gravity;

		public Action<ParticleSimulationSpace, ParticleSimulationSpace> _Mirror_SyncVarHookDelegate_simulationSpace;

		public Action<NumberRange, NumberRange> _Mirror_SyncVarHookDelegate_startRotation;

		public Action<NumberRange, NumberRange> _Mirror_SyncVarHookDelegate_angularVelocity;

		public Action<bool, bool> _Mirror_SyncVarHookDelegate_autoplay;

		public Action<bool, bool> _Mirror_SyncVarHookDelegate_loop;

		public Action<float, float> _Mirror_SyncVarHookDelegate_duration;

		public Action<ParticleShape, ParticleShape> _Mirror_SyncVarHookDelegate_shape;

		public Action<float, float> _Mirror_SyncVarHookDelegate_shapeRadius;

		public Action<float, float> _Mirror_SyncVarHookDelegate_shapeAngle;

		public Action<Vector3, Vector3> _Mirror_SyncVarHookDelegate_shapeScale;

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

		[CreatorProperty]
		[Archivable]
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

		[CreatorProperty]
		[Archivable]
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

		[CreatorProperty]
		[Archivable]
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

		[CreatorProperty]
		[Archivable]
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

		[CreatorProperty]
		[Archivable]
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

		[CreatorProperty]
		[Archivable]
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

		[CreatorProperty]
		[Archivable]
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

		[CreatorProperty]
		[Archivable]
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

		[CreatorProperty]
		[Archivable]
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

		[CreatorProperty]
		[Archivable]
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

		[CreatorProperty]
		[Archivable]
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

		[CreatorProperty]
		[Archivable]
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

		[CreatorProperty]
		[Archivable]
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

		[CreatorProperty]
		[Archivable]
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

		[CreatorProperty]
		[Archivable]
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

		[CreatorProperty]
		[Archivable]
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

		[CreatorProperty]
		[Archivable]
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

		public ColorRange Networkcolor
		{
			get
			{
				return default(ColorRange);
			}
			[param: In]
			set
			{
			}
		}

		public ParticleColorMode NetworkcolorMode
		{
			get
			{
				return default(ParticleColorMode);
			}
			[param: In]
			set
			{
			}
		}

		public NumberRange Networklifetime
		{
			get
			{
				return default(NumberRange);
			}
			[param: In]
			set
			{
			}
		}

		public NumberRange NetworksizeOverLifetime
		{
			get
			{
				return default(NumberRange);
			}
			[param: In]
			set
			{
			}
		}

		public NumberRange Networkspeed
		{
			get
			{
				return default(NumberRange);
			}
			[param: In]
			set
			{
			}
		}

		public int NetworkemissionRate
		{
			get
			{
				return 0;
			}
			[param: In]
			set
			{
			}
		}

		public int NetworkmaxParticles
		{
			get
			{
				return 0;
			}
			[param: In]
			set
			{
			}
		}

		public float Networkgravity
		{
			get
			{
				return 0f;
			}
			[param: In]
			set
			{
			}
		}

		public ParticleSimulationSpace NetworksimulationSpace
		{
			get
			{
				return default(ParticleSimulationSpace);
			}
			[param: In]
			set
			{
			}
		}

		public NumberRange NetworkstartRotation
		{
			get
			{
				return default(NumberRange);
			}
			[param: In]
			set
			{
			}
		}

		public NumberRange NetworkangularVelocity
		{
			get
			{
				return default(NumberRange);
			}
			[param: In]
			set
			{
			}
		}

		public bool Networkautoplay
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

		public bool Networkloop
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

		public float Networkduration
		{
			get
			{
				return 0f;
			}
			[param: In]
			set
			{
			}
		}

		public ParticleShape Networkshape
		{
			get
			{
				return default(ParticleShape);
			}
			[param: In]
			set
			{
			}
		}

		public float NetworkshapeRadius
		{
			get
			{
				return 0f;
			}
			[param: In]
			set
			{
			}
		}

		public float NetworkshapeAngle
		{
			get
			{
				return 0f;
			}
			[param: In]
			set
			{
			}
		}

		public Vector3 NetworkshapeScale
		{
			get
			{
				return default(Vector3);
			}
			[param: In]
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		protected override void OnHide()
		{
		}

		protected override void OnShow()
		{
		}

		private void GetImage()
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

		[ClientRpc]
		private void RpcPlay()
		{
		}

		[ClientRpc]
		private void RpcPause()
		{
		}

		[ClientRpc]
		private void RpcStop()
		{
		}

		[ClientRpc]
		private void RpcClear()
		{
		}

		[ClientRpc]
		private void RpcEmit(int count)
		{
		}

		[ClientRpc]
		private void RpcSimulate(float time)
		{
		}

		protected override void CopyProperties(Instance clone)
		{
		}

		private void OnImageIDChanged(string oldID, string newID)
		{
		}

		private void OnImageTypeChanged(ImageType oldType, ImageType newType)
		{
		}

		private void OnColorChanged(ColorRange oldColor, ColorRange newColor)
		{
		}

		private void OnColorModeChanged(ParticleColorMode oldColorMode, ParticleColorMode newColorMode)
		{
		}

		private void OnLifetimeChanged(NumberRange oldLifetime, NumberRange newLifetime)
		{
		}

		private void OnSizeOverLifetimeChanged(NumberRange oldSizeOverLifetime, NumberRange newSizeOverLifetime)
		{
		}

		private void OnSpeedChanged(NumberRange oldSpeed, NumberRange newSpeed)
		{
		}

		private void OnEmissionRateChanged(int oldEmissionRate, int newEmissionRate)
		{
		}

		private void OnMaxParticlesChanged(int oldMaxParticles, int newMaxParticles)
		{
		}

		private void OnGravityChanged(float oldGravity, float newGravity)
		{
		}

		private void OnSimulationSpaceChanged(ParticleSimulationSpace oldSimulationSpace, ParticleSimulationSpace newSimulationSpace)
		{
		}

		private void OnStartRotationChanged(NumberRange oldStartRotation, NumberRange newStartRotation)
		{
		}

		private void OnAngularVelocityChanged(NumberRange oldAngularVelocity, NumberRange newAngularVelocity)
		{
		}

		private void OnAutoplayChanged(bool oldVal, bool newVal)
		{
		}

		private void OnLoopChanged(bool oldLoop, bool newLoop)
		{
		}

		private void OnDurationChanged(float oldDuration, float newDuration)
		{
		}

		private void OnShapeChanged(ParticleShape oldShape, ParticleShape newShape)
		{
		}

		private void OnShapeRadiusChanged(float oldRadius, float newRadius)
		{
		}

		private void OnShapeAngleChanged(float oldAngle, float newAngle)
		{
		}

		private void OnShapeScaleChanged(Vector3 oldScale, Vector3 newScale)
		{
		}

		public override bool Weaved()
		{
			return false;
		}

		protected void UserCode_RpcPlay()
		{
		}

		protected static void InvokeUserCode_RpcPlay(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcPause()
		{
		}

		protected static void InvokeUserCode_RpcPause(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcStop()
		{
		}

		protected static void InvokeUserCode_RpcStop(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcClear()
		{
		}

		protected static void InvokeUserCode_RpcClear(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcEmit__Int32(int count)
		{
		}

		protected static void InvokeUserCode_RpcEmit__Int32(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSimulate__Single(float time)
		{
		}

		protected static void InvokeUserCode_RpcSimulate__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		static Particles()
		{
		}

		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}
	}
}
