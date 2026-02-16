using System.Runtime.InteropServices;
using Mirror;
using Polytoria.Lua;
using UnityEngine;
using UnityEngine.Animations;

namespace Polytoria.Datamodel
{
	[Instantiatable]
	[RequireComponent(typeof(ParentConstraint))]
	public class Tool : DynamicInstance
	{
		private Renderer _renderer;

		private BoxCollider col;

		private Rigidbody rb;

		private ParentConstraint parentConstraint;

		public LuaEvent Activated;

		public LuaEvent Deactivated;

		public LuaEvent Equipped;

		public LuaEvent Unequipped;

		private float pickupCooldown;

		[SyncVar]
		private bool droppable;

		[CreatorProperty]
		[Archivable]
		public bool Droppable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override bool DoTransformSync => false;

		public bool Networkdroppable
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

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public void Play(string anim)
		{
		}

		private void OnParentChange()
		{
		}

		private void FixChildTransforms(DynamicInstance i)
		{
		}

		[ClientRpc]
		private void RpcUpdateChildTransform(DynamicInstance i, Vector3 pos, Quaternion rot, Vector3 size)
		{
		}

		protected override void Update()
		{
		}

		private void OnTouched(Instance obj)
		{
		}

		private void CollectTool(IToolHolder holder)
		{
		}

		[ClientRpc]
		private void RpcLinkTool(Instance par)
		{
		}

		private void DoLinkTool(Instance par)
		{
		}

		private void OnDescendantAdded(Instance obj)
		{
		}

		private void RecalculateBounds()
		{
		}

		public void InvokeActivate()
		{
		}

		[Command(requiresAuthority = false)]
		private void CmdActivate()
		{
		}

		private void DoActivate()
		{
		}

		[ClientRpc]
		private void RpcActivate()
		{
		}

		public void InvokeDeactivate()
		{
		}

		[Command(requiresAuthority = false)]
		private void CmdDeactivate()
		{
		}

		private void DoDeactivate()
		{
		}

		[ClientRpc]
		private void RpcDeactivate()
		{
		}

		public void InvokeEquip()
		{
		}

		[Command(requiresAuthority = false)]
		private void CmdEquip()
		{
		}

		private void DoEquip()
		{
		}

		[ClientRpc]
		private void RpcEquip()
		{
		}

		public void InvokeUnequip()
		{
		}

		[Command(requiresAuthority = false)]
		private void CmdUnequip()
		{
		}

		private void DoUnequip()
		{
		}

		[ClientRpc]
		private void RpcUnequip()
		{
		}

		protected override void CopyProperties(Instance clone)
		{
		}

		protected override void OnHide()
		{
		}

		protected override void OnShow()
		{
		}

		public override bool Weaved()
		{
			return false;
		}

		protected void UserCode_RpcUpdateChildTransform__DynamicInstance__Vector3__Quaternion__Vector3(DynamicInstance i, Vector3 pos, Quaternion rot, Vector3 size)
		{
		}

		protected static void InvokeUserCode_RpcUpdateChildTransform__DynamicInstance__Vector3__Quaternion__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcLinkTool__Instance(Instance par)
		{
		}

		protected static void InvokeUserCode_RpcLinkTool__Instance(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_CmdActivate()
		{
		}

		protected static void InvokeUserCode_CmdActivate(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcActivate()
		{
		}

		protected static void InvokeUserCode_RpcActivate(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_CmdDeactivate()
		{
		}

		protected static void InvokeUserCode_CmdDeactivate(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcDeactivate()
		{
		}

		protected static void InvokeUserCode_RpcDeactivate(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_CmdEquip()
		{
		}

		protected static void InvokeUserCode_CmdEquip(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcEquip()
		{
		}

		protected static void InvokeUserCode_RpcEquip(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_CmdUnequip()
		{
		}

		protected static void InvokeUserCode_CmdUnequip(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcUnequip()
		{
		}

		protected static void InvokeUserCode_RpcUnequip(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		static Tool()
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
