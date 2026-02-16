using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using GLTFast;
using Mirror;
using UnityEngine;
using UnityEngine.Networking;

namespace Polytoria.Controllers
{
	public class AppearanceLoaderBase : NetworkBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CApplyBodyParts_003Ed__62 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AppearanceLoaderBase _003C_003E4__this;

			private GameObject _003Cgo_003E5__2;

			private GltfImport _003Cgltf_003E5__3;

			private Task<bool> _003Ct_003E5__4;

			private Task<bool> _003Ctask_003E5__5;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CApplyBodyParts_003Ed__62(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CApplyHats_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AppearanceLoaderBase _003C_003E4__this;

			private SyncList<string>.Enumerator _003C_003E7__wrap1;

			private string _003Curl_003E5__3;

			private GameObject _003Chat_003E5__4;

			private GltfImport _003Cgltf_003E5__5;

			private Task<bool> _003Ct_003E5__6;

			private Task<bool> _003Ctask_003E5__7;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CApplyHats_003Ed__60(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CProcessAppearance_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public int userID;

			public AppearanceLoaderBase _003C_003E4__this;

			private UnityWebRequest _003Cuwr_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CProcessAppearance_003Ed__57(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private static Dictionary<int, AppearanceData> playerAppearanceCache;

		protected Transform headObj;

		protected Transform torsoObj;

		protected Mesh defaultTorsoMesh;

		private int currentlyLoadingUserID;

		[SyncVar(hook = "ColorChanged")]
		protected Color headColor;

		[SyncVar(hook = "ColorChanged")]
		protected Color torsoColor;

		[SyncVar(hook = "ColorChanged")]
		protected Color leftArmColor;

		[SyncVar(hook = "ColorChanged")]
		protected Color rightArmColor;

		[SyncVar(hook = "ColorChanged")]
		protected Color leftLegColor;

		[SyncVar(hook = "ColorChanged")]
		protected Color rightLegColor;

		[SyncVar(hook = "ClothingChanged")]
		protected int faceID;

		[SyncVar(hook = "ClothingChanged")]
		protected int shirtID;

		[SyncVar(hook = "ClothingChanged")]
		protected int pantsID;

		[SyncVar]
		protected int torsoID;

		[SerializeField]
		protected readonly SyncList<string> hatUrls;

		[SyncVar(hook = "BodyChanged")]
		private string torsoUrl;

		public Action<Color, Color> _Mirror_SyncVarHookDelegate_headColor;

		public Action<Color, Color> _Mirror_SyncVarHookDelegate_torsoColor;

		public Action<Color, Color> _Mirror_SyncVarHookDelegate_leftArmColor;

		public Action<Color, Color> _Mirror_SyncVarHookDelegate_rightArmColor;

		public Action<Color, Color> _Mirror_SyncVarHookDelegate_leftLegColor;

		public Action<Color, Color> _Mirror_SyncVarHookDelegate_rightLegColor;

		public Action<int, int> _Mirror_SyncVarHookDelegate_faceID;

		public Action<int, int> _Mirror_SyncVarHookDelegate_shirtID;

		public Action<int, int> _Mirror_SyncVarHookDelegate_pantsID;

		public Action<string, string> _Mirror_SyncVarHookDelegate_torsoUrl;

		public Color HeadColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color TorsoColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color LeftArmColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color RightArmColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color LeftLegColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color RightLegColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public int FaceID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int ShirtID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int PantsID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int TorsoID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Color NetworkheadColor
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

		public Color NetworktorsoColor
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

		public Color NetworkleftArmColor
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

		public Color NetworkrightArmColor
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

		public Color NetworkleftLegColor
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

		public Color NetworkrightLegColor
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

		public int NetworkfaceID
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

		public int NetworkshirtID
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

		public int NetworkpantsID
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

		public int NetworktorsoID
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

		public string NetworktorsoUrl
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

		public override void OnStartClient()
		{
		}

		private void HatsChanged(SyncList<string>.Operation op, int itemIndex, string oldItem, string newItem)
		{
		}

		private void ColorChanged(Color oldColor, Color newColor)
		{
		}

		private void ClothingChanged(int oldClothing, int newClothing)
		{
		}

		private void BodyChanged(string oldBody, string newBody)
		{
		}

		protected virtual void UpdateColors()
		{
		}

		protected virtual void UpdateClothing()
		{
		}

		protected virtual void Awake()
		{
		}

		public void LoadAppearance(int userID)
		{
		}

		public virtual void ClearAppearance()
		{
		}

		[IteratorStateMachine(typeof(_003CProcessAppearance_003Ed__57))]
		private IEnumerator ProcessAppearance(int userID)
		{
			return null;
		}

		private void ApplyAppearance(AppearanceData data)
		{
		}

		private void UpdateHats()
		{
		}

		[IteratorStateMachine(typeof(_003CApplyHats_003Ed__60))]
		private IEnumerator ApplyHats()
		{
			return null;
		}

		private void UpdateBodyParts()
		{
		}

		[IteratorStateMachine(typeof(_003CApplyBodyParts_003Ed__62))]
		private IEnumerator ApplyBodyParts()
		{
			return null;
		}

		protected virtual void HatLoaded(GameObject hat)
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
