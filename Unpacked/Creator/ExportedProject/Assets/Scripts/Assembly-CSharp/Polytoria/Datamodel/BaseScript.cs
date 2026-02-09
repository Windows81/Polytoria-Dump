using System.Runtime.InteropServices;
using Mirror;
using MoonSharp.Interpreter;
using Polytoria.Datamodel.Services;

namespace Polytoria.Datamodel
{
	public class BaseScript : Instance
	{
		public bool running;

		private bool requestedRun;

		private ScriptService scriptService;

		[SyncVar]
		[MoonSharpHidden]
		public string source;

		[MoonSharpHidden]
		public Script script;

		private DynValue updateFunc;

		private DynValue fixedUpdateFunc;

		[MoonSharpHidden]
		[Archivable]
		public string Source
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public new object this[string name]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Networksource
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

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected override void OnNetworkStart()
		{
		}

		public override void OnStartClient()
		{
		}

		[MoonSharpHidden]
		public void Run()
		{
		}

		[ClientRpc]
		private void RpcRun()
		{
		}

		public void Call(string function, params object[] args)
		{
		}

		protected override void CopyProperties(Instance clone)
		{
		}

		protected override void PostClone()
		{
		}

		public void Update()
		{
		}

		public void FixedUpdate()
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

		protected void UserCode_RpcRun()
		{
		}

		protected static void InvokeUserCode_RpcRun(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		static BaseScript()
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
