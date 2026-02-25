namespace Mirror.Experimental;

[AddComponentMenu(null)]
[HelpURL("https://mirror-networking.gitbook.io/docs/components/network-lerp-rigidbody")]
[Obsolete("Use the new NetworkRigidbodyReliable/Unreliable component with Snapshot Interpolation instead.")]
[Token(Token = "0x200004F")]
public class NetworkLerpRigidbody : NetworkBehaviour
{
	[FieldOffset(Offset = "0x68")]
	[Header("Settings")]
	[SerializeField]
	[Token(Token = "0x40001BD")]
	internal Rigidbody target; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x40001BE")]
	[Tooltip("How quickly current velocity approaches target velocity")]
	private float lerpVelocityAmount; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	[Token(Token = "0x40001BF")]
	[Tooltip("How quickly current position approaches target position")]
	private float lerpPositionAmount; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x40001C0")]
	[Tooltip("Set to true if moves come from owner client, set to false if moves always come from server")]
	private bool clientAuthority; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40001C1")]
	private double nextSyncTime; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[SyncVar]
	[Token(Token = "0x40001C2")]
	private Vector3 targetVelocity; //Field offset: 0x88
	[FieldOffset(Offset = "0x94")]
	[SyncVar]
	[Token(Token = "0x40001C3")]
	private Vector3 targetPosition; //Field offset: 0x94

	[Token(Token = "0x17000026")]
	private bool ClientWithAuthority
	{
		[Address(RVA = "0x122D4C0", Offset = "0x122C6C0", Length = "0x10")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NetworkBehaviour), Member = "get_isOwned", ReturnType = typeof(bool))]
		[Token(Token = "0x6000284")]
		private get { } //Length: 16
	}

	[Token(Token = "0x17000025")]
	private bool IgnoreSync
	{
		[Address(RVA = "0x122D4D0", Offset = "0x122C6D0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "get_isOwned", ReturnType = typeof(bool))]
		[Token(Token = "0x6000283")]
		private get { } //Length: 57
	}

	[Token(Token = "0x17000028")]
	public Vector3 NetworktargetPosition
	{
		[Address(RVA = "0x122D510", Offset = "0x122C710", Length = "0x19")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000290")]
		 get { } //Length: 25
		[Address(RVA = "0x122D530", Offset = "0x122C730", Length = "0xDA")]
		[CalledBy(Type = typeof(NetworkLerpRigidbody), Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkLerpRigidbody), Member = "SyncToClients", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkLerpRigidbody), Member = "UserCode_CmdSendState__Vector3__Vector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkLerpRigidbody), Member = "InvokeUserCode_CmdSendState__Vector3__Vector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkBehaviour), typeof(NetworkReader), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3&), typeof(ulong)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000291")]
		 set { } //Length: 218
	}

	[Token(Token = "0x17000027")]
	public Vector3 NetworktargetVelocity
	{
		[Address(RVA = "0x3BB940", Offset = "0x3BAB40", Length = "0x19")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600028E")]
		 get { } //Length: 25
		[Address(RVA = "0x122D610", Offset = "0x122C810", Length = "0xDA")]
		[CalledBy(Type = typeof(NetworkLerpRigidbody), Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkLerpRigidbody), Member = "SyncToClients", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkLerpRigidbody), Member = "UserCode_CmdSendState__Vector3__Vector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkLerpRigidbody), Member = "InvokeUserCode_CmdSendState__Vector3__Vector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkBehaviour), typeof(NetworkReader), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3&), typeof(ulong)}, ReturnType = typeof(void))]
		[Token(Token = "0x600028F")]
		 set { } //Length: 218
	}

	[Address(RVA = "0x122D3C0", Offset = "0x122C5C0", Length = "0xE0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RemoteProcedureCalls), Member = "RegisterCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(RemoteCallDelegate), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000294")]
	private static NetworkLerpRigidbody() { }

	[Address(RVA = "0x122D4A0", Offset = "0x122C6A0", Length = "0x15")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x600028C")]
	public NetworkLerpRigidbody() { }

	[Address(RVA = "0x122C630", Offset = "0x122B830", Length = "0x1A6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendCommandInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Command]
	[Token(Token = "0x600028A")]
	private void CmdSendState(Vector3 velocity, Vector3 position) { }

	[Address(RVA = "0x122C7E0", Offset = "0x122B9E0", Length = "0x145")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3&), typeof(System.Action`2<UnityEngine.Vector3, UnityEngine.Vector3>), typeof(Vector3)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000296")]
	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	[Address(RVA = "0x122C930", Offset = "0x122BB30", Length = "0x261")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isOwned", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Rigidbody), Member = "get_velocity", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Rigidbody), Member = "set_velocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Rigidbody), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Rigidbody), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Time), Member = "get_fixedDeltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600028B")]
	private void FixedUpdate() { }

	[Address(RVA = "0x122D4C0", Offset = "0x122C6C0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isOwned", ReturnType = typeof(bool))]
	[Token(Token = "0x6000284")]
	private bool get_ClientWithAuthority() { }

	[Address(RVA = "0x122D4D0", Offset = "0x122C6D0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isOwned", ReturnType = typeof(bool))]
	[Token(Token = "0x6000283")]
	private bool get_IgnoreSync() { }

	[Address(RVA = "0x122D510", Offset = "0x122C710", Length = "0x19")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000290")]
	public Vector3 get_NetworktargetPosition() { }

	[Address(RVA = "0x3BB940", Offset = "0x3BAB40", Length = "0x19")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600028E")]
	public Vector3 get_NetworktargetVelocity() { }

	[Address(RVA = "0x122CBA0", Offset = "0x122BDA0", Length = "0x20C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Rigidbody), Member = "set_velocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Rigidbody), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkLerpRigidbody), Member = "set_NetworktargetVelocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkLerpRigidbody), Member = "set_NetworktargetPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000293")]
	protected static void InvokeUserCode_CmdSendState__Vector3__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	[Address(RVA = "0x122CDB0", Offset = "0x122BFB0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "OnValidate", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000285")]
	protected virtual void OnValidate() { }

	[Address(RVA = "0x122CDE0", Offset = "0x122BFE0", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000286")]
	public override void Reset() { }

	[Address(RVA = "0x122CE70", Offset = "0x122C070", Length = "0x256")]
	[CalledBy(Type = typeof(NetworkLerpRigidbody), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Rigidbody), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendCommandInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Rigidbody), Member = "get_velocity", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000289")]
	private void SendToServer() { }

	[Address(RVA = "0x122D0D0", Offset = "0x122C2D0", Length = "0xC4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Vector3)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000295")]
	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	[Address(RVA = "0x122D530", Offset = "0x122C730", Length = "0xDA")]
	[CalledBy(Type = typeof(NetworkLerpRigidbody), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkLerpRigidbody), Member = "SyncToClients", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkLerpRigidbody), Member = "UserCode_CmdSendState__Vector3__Vector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkLerpRigidbody), Member = "InvokeUserCode_CmdSendState__Vector3__Vector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkBehaviour), typeof(NetworkReader), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3&), typeof(ulong)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000291")]
	public void set_NetworktargetPosition(in Vector3 value) { }

	[Address(RVA = "0x122D610", Offset = "0x122C810", Length = "0xDA")]
	[CalledBy(Type = typeof(NetworkLerpRigidbody), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkLerpRigidbody), Member = "SyncToClients", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkLerpRigidbody), Member = "UserCode_CmdSendState__Vector3__Vector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkLerpRigidbody), Member = "InvokeUserCode_CmdSendState__Vector3__Vector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkBehaviour), typeof(NetworkReader), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3&), typeof(ulong)}, ReturnType = typeof(void))]
	[Token(Token = "0x600028F")]
	public void set_NetworktargetVelocity(in Vector3 value) { }

	[Address(RVA = "0x122D1A0", Offset = "0x122C3A0", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Rigidbody), Member = "get_velocity", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(NetworkLerpRigidbody), Member = "set_NetworktargetVelocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Rigidbody), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(NetworkLerpRigidbody), Member = "set_NetworktargetPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000288")]
	private void SyncToClients() { }

	[Address(RVA = "0x122D230", Offset = "0x122C430", Length = "0xB5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isOwned", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkLerpRigidbody), Member = "SendToServer", ReturnType = typeof(void))]
	[Calls(Type = typeof(Rigidbody), Member = "get_velocity", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(NetworkLerpRigidbody), Member = "set_NetworktargetVelocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Rigidbody), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(NetworkLerpRigidbody), Member = "set_NetworktargetPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000287")]
	private void Update() { }

	[Address(RVA = "0x122D2F0", Offset = "0x122C4F0", Length = "0xC1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Rigidbody), Member = "set_velocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Rigidbody), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkLerpRigidbody), Member = "set_NetworktargetVelocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkLerpRigidbody), Member = "set_NetworktargetPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000292")]
	protected void UserCode_CmdSendState__Vector3__Vector3(Vector3 velocity, Vector3 position) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x600028D")]
	public virtual bool Weaved() { }

}

