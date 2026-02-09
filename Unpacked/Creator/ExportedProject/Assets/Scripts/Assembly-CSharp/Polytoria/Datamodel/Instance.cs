using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Mirror;
using MoonSharp.Interpreter;
using Polytoria.Lua;
using UnityEngine;

namespace Polytoria.Datamodel
{
	public class Instance : NetworkBehaviour
	{
		protected Transform _transform;

		[SyncVar]
		protected string _name;

		protected string className;

		protected bool canReparent;

		protected bool hidesMembers;

		protected bool clientSpawned;

		private DynValue shared;

		public LuaEvent ChildRemoved;

		public LuaEvent ChildAdded;

		public LuaEvent Touched;

		public LuaEvent TouchEnded;

		public LuaEvent MouseHover;

		public LuaEvent MouseHoverEnded;

		public LuaEvent Clicked;

		public LuaEvent MouseEnter;

		public LuaEvent MouseExit;

		[MoonSharpHidden]
		public bool isHidden;

		private bool isMouseOver;

		public bool ClientSpawned => false;

		public bool CanReparent => false;

		[MoonSharpHidden]
		public int DescendantLevel => 0;

		public Instance this[string name] => null;

		public Instance this[int index] => null;

		[CreatorProperty]
		[Archivable]
		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string FullName => null;

		[CreatorProperty]
		public string ClassName => null;

		public DynValue Shared => null;

		public Instance Parent
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Network_name
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

		[MoonSharpHidden]
		public event Action<Instance> _DescendantAdded
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[MoonSharpHidden]
		public event Action _ParentChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[MoonSharpHidden]
		public event Action<Instance> _Touched
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public Instance GetParent()
		{
			return null;
		}

		public void SetParent(Instance par)
		{
		}

		protected virtual void OnHide()
		{
		}

		protected virtual void OnShow()
		{
		}

		[ClientRpc]
		private void RpcSetParent(Transform par)
		{
		}

		public Instance FindChild(string name)
		{
			return null;
		}

		public Instance[] GetChildren()
		{
			return null;
		}

		public Instance[] GetChildrenOfClass(string className)
		{
			return null;
		}

		public T[] GetChildrenOfType<T>() where T : Instance
		{
			return null;
		}

		public T FindChildOfType<T>() where T : Instance
		{
			return null;
		}

		public Instance FindChildByClass(string className)
		{
			return null;
		}

		public bool IsA(string className)
		{
			return false;
		}

		public bool IsDescendantOf(Instance other)
		{
			return false;
		}

		public bool IsDescendantOfType<T>() where T : Instance
		{
			return false;
		}

		public void Destroy(float time = 0f)
		{
		}

		public void Delete(float time = 0f)
		{
		}

		[ClientRpc]
		private void RpcSetName(string n)
		{
		}

		[Command(requiresAuthority = false)]
		private void RequestParent(NetworkConnectionToClient sender = null)
		{
		}

		[TargetRpc]
		private void SetParentTargetRpc(NetworkConnection target, Transform par, int index)
		{
		}

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void OnNetworkStart()
		{
		}

		public override void OnStartClient()
		{
		}

		public override void OnStartServer()
		{
		}

		private void OnGameLoaded()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		public static Instance New(string className, Instance parent = null)
		{
			return null;
		}

		protected virtual void OnCollisionEnter(Collision collision)
		{
		}

		protected virtual void OnTriggerEnter(Collider collider)
		{
		}

		protected virtual void OnCollisionExit(Collision collision)
		{
		}

		protected virtual void OnTriggerExit(Collider collider)
		{
		}

		private int GetDescendantLevel()
		{
			return 0;
		}

		private void OnMouseDown()
		{
		}

		private void OnMouseEnter()
		{
		}

		private void OnMouseExit()
		{
		}

		[Command(requiresAuthority = false)]
		private void CmdClicked(NetworkConnectionToClient sender = null)
		{
		}

		public Instance Clone()
		{
			return null;
		}

		protected virtual void CopyProperties(Instance clone)
		{
		}

		protected virtual void PostClone()
		{
		}

		public Bounds GetBounds(BoundsCalculationMethod calculationMethod = BoundsCalculationMethod.Renderer)
		{
			return default(Bounds);
		}

		public override bool Weaved()
		{
			return false;
		}

		protected void UserCode_RpcSetParent__Transform(Transform par)
		{
		}

		protected static void InvokeUserCode_RpcSetParent__Transform(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetName__String(string n)
		{
		}

		protected static void InvokeUserCode_RpcSetName__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RequestParent__NetworkConnectionToClient(NetworkConnectionToClient sender)
		{
		}

		protected static void InvokeUserCode_RequestParent__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_SetParentTargetRpc__NetworkConnection__Transform__Int32(NetworkConnection target, Transform par, int index)
		{
		}

		protected static void InvokeUserCode_SetParentTargetRpc__NetworkConnection__Transform__Int32(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_CmdClicked__NetworkConnectionToClient(NetworkConnectionToClient sender)
		{
		}

		protected static void InvokeUserCode_CmdClicked__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		static Instance()
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
