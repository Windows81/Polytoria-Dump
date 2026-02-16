using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Mirror;
using MoonSharp.Interpreter;
using Polytoria.Datamodel;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class PurchasesService : NetworkBehaviour
{
	public struct PurchaseRequest
	{
		public Player player;

		public int assetID;

		public int expectedPrice;

		public DynValue callback;

		public DateTime timestamp;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public int assetID;

		public string refId;

		internal void _003CShowPurchaseModal_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CDoProcessPurchase_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PurchaseRequest request;

		public PurchasesService _003C_003E4__this;

		private bool _003Csuccess_003E5__2;

		private string _003Cmessage_003E5__3;

		private UnityWebRequest _003Cuwr_003E5__4;

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
		public _003CDoProcessPurchase_003Ed__18(int _003C_003E1__state)
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
	private sealed class _003CShowPurchaseModal_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int assetID;

		public string refId;

		private _003C_003Ec__DisplayClass13_0 _003C_003E8__1;

		public PurchasesService _003C_003E4__this;

		private UnityWebRequest _003Cwww_003E5__2;

		private string _003CassetName_003E5__3;

		private int _003Cprice_003E5__4;

		private UnityWebRequest _003CthumbnailRequest_003E5__5;

		private Button _003CpurchaseButton_003E5__6;

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
		public _003CShowPurchaseModal_003Ed__13(int _003C_003E1__state)
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

		private void _003C_003Em__Finally2()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	private RectTransform purchaseModalPrefab;

	[SerializeField]
	private RectTransform purchaseResultPrefab;

	private string currentRefId;

	private Dictionary<string, PurchaseRequest> pendingPurchases;

	private bool readyToPurchase;

	private int currentExpectedPrice;

	public static PurchasesService Instance { get; private set; }

	private void Awake()
	{
	}

	public void Prompt(Player player, int assetID, DynValue callback)
	{
	}

	[TargetRpc]
	private void DispatchPurchase(NetworkConnection target, int assetID, string refId)
	{
	}

	[IteratorStateMachine(typeof(_003CShowPurchaseModal_003Ed__13))]
	private IEnumerator ShowPurchaseModal(int assetID, string refId)
	{
		return null;
	}

	public void CancelButton()
	{
	}

	public void PurchaseButton()
	{
	}

	[Command(requiresAuthority = false)]
	private void CmdProcessPurchase(string refId, int expectedPrice)
	{
	}

	[Command(requiresAuthority = false)]
	private void CmdCancelPurchase(string refId)
	{
	}

	[IteratorStateMachine(typeof(_003CDoProcessPurchase_003Ed__18))]
	private IEnumerator DoProcessPurchase(PurchaseRequest request)
	{
		return null;
	}

	[TargetRpc]
	private void TargetPurchaseResult(NetworkConnection target, bool success, string message)
	{
	}

	private void ShowPurchaseResultUI(bool success, string message)
	{
	}

	private void Update()
	{
	}

	private void CleanupExpiredPurchases()
	{
	}

	public override bool Weaved()
	{
		return false;
	}

	protected void UserCode_DispatchPurchase__NetworkConnection__Int32__String(NetworkConnection target, int assetID, string refId)
	{
	}

	protected static void InvokeUserCode_DispatchPurchase__NetworkConnection__Int32__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_CmdProcessPurchase__String__Int32(string refId, int expectedPrice)
	{
	}

	protected static void InvokeUserCode_CmdProcessPurchase__String__Int32(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_CmdCancelPurchase__String(string refId)
	{
	}

	protected static void InvokeUserCode_CmdCancelPurchase__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	protected void UserCode_TargetPurchaseResult__NetworkConnection__Boolean__String(NetworkConnection target, bool success, string message)
	{
	}

	protected static void InvokeUserCode_TargetPurchaseResult__NetworkConnection__Boolean__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
	}

	static PurchasesService()
	{
	}
}
