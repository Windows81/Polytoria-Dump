namespace Mirror.Experimental;

[AddComponentMenu(null)]
[HelpURL("https://mirror-networking.gitbook.io/docs/components/network-rigidbody")]
[Obsolete("Use the new NetworkRigidbodyReliable/Unreliable 2D component with Snapshot Interpolation instead.")]
[Token(Token = "0x2000052")]
public class NetworkRigidbody2D : NetworkBehaviour
{
	[Token(Token = "0x2000053")]
	internal class ClientSyncState
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001F5")]
		public float nextSyncTime; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40001F6")]
		public Vector2 velocity; //Field offset: 0x14
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40001F7")]
		public float angularVelocity; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001F8")]
		public bool isKinematic; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40001F9")]
		public float gravityScale; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001FA")]
		public float drag; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40001FB")]
		public float angularDrag; //Field offset: 0x2C

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002FE")]
		public ClientSyncState() { }

	}

	[FieldOffset(Offset = "0x68")]
	[Header("Settings")]
	[SerializeField]
	[Token(Token = "0x40001E0")]
	internal Rigidbody2D target; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40001E1")]
	[Tooltip("Set to true if moves come from owner client, set to false if moves always come from server")]
	public bool clientAuthority; //Field offset: 0x70
	[FieldOffset(Offset = "0x71")]
	[Header("Velocity")]
	[SerializeField]
	[Token(Token = "0x40001E2")]
	[Tooltip("Syncs Velocity every SyncInterval")]
	private bool syncVelocity; //Field offset: 0x71
	[FieldOffset(Offset = "0x72")]
	[SerializeField]
	[Token(Token = "0x40001E3")]
	[Tooltip("Set velocity to 0 each frame (only works if syncVelocity is false")]
	private bool clearVelocity; //Field offset: 0x72
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	[Token(Token = "0x40001E4")]
	[Tooltip("Only Syncs Value if distance between previous and current is great than sensitivity")]
	private float velocitySensitivity; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Header("Angular Velocity")]
	[SerializeField]
	[Token(Token = "0x40001E5")]
	[Tooltip("Syncs AngularVelocity every SyncInterval")]
	private bool syncAngularVelocity; //Field offset: 0x78
	[FieldOffset(Offset = "0x79")]
	[SerializeField]
	[Token(Token = "0x40001E6")]
	[Tooltip("Set angularVelocity to 0 each frame (only works if syncAngularVelocity is false")]
	private bool clearAngularVelocity; //Field offset: 0x79
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	[Token(Token = "0x40001E7")]
	[Tooltip("Only Syncs Value if distance between previous and current is great than sensitivity")]
	private float angularVelocitySensitivity; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40001E8")]
	private readonly ClientSyncState previousValue; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[SyncVar(hook = "OnVelocityChanged")]
	[Token(Token = "0x40001E9")]
	private Vector2 velocity; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[SyncVar(hook = "OnAngularVelocityChanged")]
	[Token(Token = "0x40001EA")]
	private float angularVelocity; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[SyncVar(hook = "OnIsKinematicChanged")]
	[Token(Token = "0x40001EB")]
	private bool isKinematic; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[SyncVar(hook = "OnGravityScaleChanged")]
	[Token(Token = "0x40001EC")]
	private float gravityScale; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[SyncVar(hook = "OnuDragChanged")]
	[Token(Token = "0x40001ED")]
	private float drag; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[SyncVar(hook = "OnAngularDragChanged")]
	[Token(Token = "0x40001EE")]
	private float angularDrag; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40001EF")]
	public Action<Vector2, Vector2> _Mirror_SyncVarHookDelegate_velocity; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40001F0")]
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_angularVelocity; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40001F1")]
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_isKinematic; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40001F2")]
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_gravityScale; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40001F3")]
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_drag; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40001F4")]
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_angularDrag; //Field offset: 0xD0

	[Token(Token = "0x17000032")]
	private bool ClientWithAuthority
	{
		[Address(RVA = "0x1230BB0", Offset = "0x122FDB0", Length = "0x10")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NetworkBehaviour), Member = "get_isOwned", ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[Token(Token = "0x60002CE")]
		private get { } //Length: 16
	}

	[Token(Token = "0x17000031")]
	private bool IgnoreSync
	{
		[Address(RVA = "0x1230BC0", Offset = "0x122FDC0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "get_isOwned", ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[Token(Token = "0x60002CD")]
		private get { } //Length: 57
	}

	[Token(Token = "0x17000038")]
	public float NetworkangularDrag
	{
		[Address(RVA = "0x1230C00", Offset = "0x122FE00", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60002ED")]
		 get { } //Length: 9
		[Address(RVA = "0x1230C60", Offset = "0x122FE60", Length = "0x68")]
		[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "SyncToClients", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "UserCode_CmdSendAngularDrag__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Token(Token = "0x60002EE")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000034")]
	public float NetworkangularVelocity
	{
		[Address(RVA = "0x5A7580", Offset = "0x5A6780", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002E5")]
		 get { } //Length: 9
		[Address(RVA = "0x1230CD0", Offset = "0x122FED0", Length = "0x68")]
		[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "SyncToClients", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "UserCode_CmdSendVelocityAndAngular__Vector2__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "InvokeUserCode_CmdSendVelocityAndAngular__Vector2__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkBehaviour), typeof(NetworkReader), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Token(Token = "0x60002E6")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000037")]
	public float Networkdrag
	{
		[Address(RVA = "0x1230C10", Offset = "0x122FE10", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60002EB")]
		 get { } //Length: 9
		[Address(RVA = "0x1230D40", Offset = "0x122FF40", Length = "0x68")]
		[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "SyncToClients", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "UserCode_CmdSendDrag__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "InvokeUserCode_CmdSendDrag__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkBehaviour), typeof(NetworkReader), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Token(Token = "0x60002EC")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000036")]
	public float NetworkgravityScale
	{
		[Address(RVA = "0x1230C20", Offset = "0x122FE20", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60002E9")]
		 get { } //Length: 9
		[Address(RVA = "0x1230DB0", Offset = "0x122FFB0", Length = "0x68")]
		[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "SyncToClients", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "UserCode_CmdChangeGravityScale__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "InvokeUserCode_CmdChangeGravityScale__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkBehaviour), typeof(NetworkReader), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Token(Token = "0x60002EA")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000035")]
	public bool NetworkisKinematic
	{
		[Address(RVA = "0x1230C30", Offset = "0x122FE30", Length = "0x8")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002E7")]
		 get { } //Length: 8
		[Address(RVA = "0x1230E20", Offset = "0x1230020", Length = "0x68")]
		[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "SyncToClients", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "UserCode_CmdSendIsKinematic__Boolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "InvokeUserCode_CmdSendIsKinematic__Boolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkBehaviour), typeof(NetworkReader), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Token(Token = "0x60002E8")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000033")]
	public Vector2 Networkvelocity
	{
		[Address(RVA = "0x1230C40", Offset = "0x122FE40", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60002E3")]
		 get { } //Length: 25
		[Address(RVA = "0x1230E90", Offset = "0x1230090", Length = "0x174")]
		[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "SyncToClients", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "UserCode_CmdSendVelocity__Vector2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "InvokeUserCode_CmdSendVelocity__Vector2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkBehaviour), typeof(NetworkReader), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "UserCode_CmdSendVelocityAndAngular__Vector2__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "InvokeUserCode_CmdSendVelocityAndAngular__Vector2__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkBehaviour), typeof(NetworkReader), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&", typeof(ulong)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(NetworkServer), Member = "get_activeHost", ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "GetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60002E4")]
		 set { } //Length: 372
	}

	[Address(RVA = "0x1230670", Offset = "0x122F870", Length = "0x2EA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RemoteProcedureCalls), Member = "RegisterCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(RemoteCallDelegate), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x60002FB")]
	private static NetworkRigidbody2D() { }

	[Address(RVA = "0x1230960", Offset = "0x122FB60", Length = "0x24A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkBehaviour), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x60002E1")]
	public NetworkRigidbody2D() { }

	[Address(RVA = "0x122D950", Offset = "0x122CB50", Length = "0x165")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendCommandInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Command]
	[Token(Token = "0x60002DE")]
	private void CmdChangeGravityScale(float gravityScale) { }

	[Address(RVA = "0x122DAC0", Offset = "0x122CCC0", Length = "0x165")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendCommandInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Command]
	[Token(Token = "0x60002E0")]
	private void CmdSendAngularDrag(float angularDrag) { }

	[Address(RVA = "0x122DC30", Offset = "0x122CE30", Length = "0x165")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendCommandInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Command]
	[Token(Token = "0x60002DF")]
	private void CmdSendDrag(float drag) { }

	[Address(RVA = "0x122DDA0", Offset = "0x122CFA0", Length = "0x166")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendCommandInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Command]
	[Token(Token = "0x60002DD")]
	private void CmdSendIsKinematic(bool isKinematic) { }

	[Address(RVA = "0x122E0A0", Offset = "0x122D2A0", Length = "0x169")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVector2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendCommandInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Command]
	[Token(Token = "0x60002DB")]
	private void CmdSendVelocity(Vector2 velocity) { }

	[Address(RVA = "0x122DF10", Offset = "0x122D110", Length = "0x184")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVector2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendCommandInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Command]
	[Token(Token = "0x60002DC")]
	private void CmdSendVelocityAndAngular(Vector2 velocity, float angularVelocity) { }

	[Address(RVA = "0x122E210", Offset = "0x122D410", Length = "0x2E3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVector2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2&), typeof(System.Action`2<UnityEngine.Vector2, UnityEngine.Vector2>), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(System.Action`2<System.Single, System.Single>), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Action`2<T, T>", "T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60002FD")]
	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	[Address(RVA = "0x122E500", Offset = "0x122D700", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Rigidbody2D), Member = "set_angularVelocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Rigidbody2D), Member = "set_velocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002D6")]
	internal void FixedUpdate() { }

	[Address(RVA = "0x1230BB0", Offset = "0x122FDB0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isOwned", ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x60002CE")]
	private bool get_ClientWithAuthority() { }

	[Address(RVA = "0x1230BC0", Offset = "0x122FDC0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isOwned", ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x60002CD")]
	private bool get_IgnoreSync() { }

	[Address(RVA = "0x1230C00", Offset = "0x122FE00", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60002ED")]
	public float get_NetworkangularDrag() { }

	[Address(RVA = "0x5A7580", Offset = "0x5A6780", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002E5")]
	public float get_NetworkangularVelocity() { }

	[Address(RVA = "0x1230C10", Offset = "0x122FE10", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60002EB")]
	public float get_Networkdrag() { }

	[Address(RVA = "0x1230C20", Offset = "0x122FE20", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60002E9")]
	public float get_NetworkgravityScale() { }

	[Address(RVA = "0x1230C30", Offset = "0x122FE30", Length = "0x8")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002E7")]
	public bool get_NetworkisKinematic() { }

	[Address(RVA = "0x1230C40", Offset = "0x122FE40", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60002E3")]
	public Vector2 get_Networkvelocity() { }

	[Address(RVA = "0x122E5A0", Offset = "0x122D7A0", Length = "0x163")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(NetworkRigidbody2D), Member = "set_NetworkgravityScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Rigidbody2D), Member = "set_gravityScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002F6")]
	protected static void InvokeUserCode_CmdChangeGravityScale__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	[Address(RVA = "0x122E710", Offset = "0x122D910", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60002FA")]
	protected static void InvokeUserCode_CmdSendAngularDrag__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	[Address(RVA = "0x122E880", Offset = "0x122DA80", Length = "0x163")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(NetworkRigidbody2D), Member = "set_Networkdrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002F8")]
	protected static void InvokeUserCode_CmdSendDrag__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	[Address(RVA = "0x122E9F0", Offset = "0x122DBF0", Length = "0x15E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkRigidbody2D), Member = "set_NetworkisKinematic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Rigidbody2D), Member = "set_isKinematic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002F4")]
	protected static void InvokeUserCode_CmdSendIsKinematic__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	[Address(RVA = "0x122ED10", Offset = "0x122DF10", Length = "0x16D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVector2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(NetworkRigidbody2D), Member = "set_Networkvelocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Rigidbody2D), Member = "set_velocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002F0")]
	protected static void InvokeUserCode_CmdSendVelocity__Vector2(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	[Address(RVA = "0x122EB50", Offset = "0x122DD50", Length = "0x1B4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVector2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(NetworkRigidbody2D), Member = "set_Networkvelocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Rigidbody2D), Member = "set_velocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkRigidbody2D), Member = "set_NetworkangularVelocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Rigidbody2D), Member = "set_angularVelocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002F2")]
	protected static void InvokeUserCode_CmdSendVelocityAndAngular__Vector2__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	[Address(RVA = "0x122EE80", Offset = "0x122E080", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isOwned", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002D4")]
	private void OnAngularDragChanged(float _, float newValue) { }

	[Address(RVA = "0x122EEE0", Offset = "0x122E0E0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isOwned", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Rigidbody2D), Member = "set_angularVelocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002D0")]
	private void OnAngularVelocityChanged(float _, float newValue) { }

	[Address(RVA = "0x122EF40", Offset = "0x122E140", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isOwned", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Rigidbody2D), Member = "set_gravityScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002D2")]
	private void OnGravityScaleChanged(float _, float newValue) { }

	[Address(RVA = "0x122EFA0", Offset = "0x122E1A0", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isOwned", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Rigidbody2D), Member = "set_isKinematic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002D1")]
	private void OnIsKinematicChanged(bool _, bool newValue) { }

	[Address(RVA = "0x122F060", Offset = "0x122E260", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isOwned", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002D3")]
	private void OnuDragChanged(float _, float newValue) { }

	[Address(RVA = "0x122CDB0", Offset = "0x122BFB0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "OnValidate", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002CB")]
	protected virtual void OnValidate() { }

	[Address(RVA = "0x122F000", Offset = "0x122E200", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isOwned", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Rigidbody2D), Member = "set_velocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002CF")]
	private void OnVelocityChanged(Vector2 _, Vector2 newValue) { }

	[Address(RVA = "0x122F0C0", Offset = "0x122E2C0", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60002CC")]
	public override void Reset() { }

	[Address(RVA = "0x122F150", Offset = "0x122E350", Length = "0x79A")]
	[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "SendToServer", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Rigidbody2D), Member = "get_gravityScale", ReturnType = typeof(float))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendCommandInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Rigidbody2D), Member = "get_isKinematic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Client]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002DA")]
	private void SendRigidBodySettings() { }

	[Address(RVA = "0x122F8F0", Offset = "0x122EAF0", Length = "0xE0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isOwned", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkRigidbody2D), Member = "SendVelocity", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkRigidbody2D), Member = "SendRigidBodySettings", ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Client]
	[Token(Token = "0x60002D8")]
	private void SendToServer() { }

	[Address(RVA = "0x122F9D0", Offset = "0x122EBD0", Length = "0x538")]
	[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "SendToServer", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Rigidbody2D), Member = "get_angularVelocity", ReturnType = typeof(float))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendCommandInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVector2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Time), Member = "get_time", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Client]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002D9")]
	private void SendVelocity() { }

	[Address(RVA = "0x122FF10", Offset = "0x122F110", Length = "0x157")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVector2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002FC")]
	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	[Address(RVA = "0x1230C60", Offset = "0x122FE60", Length = "0x68")]
	[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "SyncToClients", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "UserCode_CmdSendAngularDrag__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Token(Token = "0x60002EE")]
	public void set_NetworkangularDrag(in float value) { }

	[Address(RVA = "0x1230CD0", Offset = "0x122FED0", Length = "0x68")]
	[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "SyncToClients", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "UserCode_CmdSendVelocityAndAngular__Vector2__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "InvokeUserCode_CmdSendVelocityAndAngular__Vector2__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkBehaviour), typeof(NetworkReader), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Token(Token = "0x60002E6")]
	public void set_NetworkangularVelocity(in float value) { }

	[Address(RVA = "0x1230D40", Offset = "0x122FF40", Length = "0x68")]
	[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "SyncToClients", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "UserCode_CmdSendDrag__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "InvokeUserCode_CmdSendDrag__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkBehaviour), typeof(NetworkReader), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Token(Token = "0x60002EC")]
	public void set_Networkdrag(in float value) { }

	[Address(RVA = "0x1230DB0", Offset = "0x122FFB0", Length = "0x68")]
	[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "SyncToClients", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "UserCode_CmdChangeGravityScale__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "InvokeUserCode_CmdChangeGravityScale__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkBehaviour), typeof(NetworkReader), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Token(Token = "0x60002EA")]
	public void set_NetworkgravityScale(in float value) { }

	[Address(RVA = "0x1230E20", Offset = "0x1230020", Length = "0x68")]
	[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "SyncToClients", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "UserCode_CmdSendIsKinematic__Boolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "InvokeUserCode_CmdSendIsKinematic__Boolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkBehaviour), typeof(NetworkReader), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Token(Token = "0x60002E8")]
	public void set_NetworkisKinematic(in bool value) { }

	[Address(RVA = "0x1230E90", Offset = "0x1230090", Length = "0x174")]
	[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "SyncToClients", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "UserCode_CmdSendVelocity__Vector2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "InvokeUserCode_CmdSendVelocity__Vector2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkBehaviour), typeof(NetworkReader), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "UserCode_CmdSendVelocityAndAngular__Vector2__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "InvokeUserCode_CmdSendVelocityAndAngular__Vector2__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkBehaviour), typeof(NetworkReader), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkServer), Member = "get_activeHost", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&", typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002E4")]
	public void set_Networkvelocity(in Vector2 value) { }

	[Address(RVA = "0x1230070", Offset = "0x122F270", Length = "0x2BC")]
	[CalledBy(Type = typeof(NetworkRigidbody2D), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NetworkRigidbody2D), Member = "set_Networkvelocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkRigidbody2D), Member = "set_NetworkangularDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Rigidbody2D), Member = "get_angularVelocity", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(NetworkRigidbody2D), Member = "set_NetworkangularVelocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Rigidbody2D), Member = "get_isKinematic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkRigidbody2D), Member = "set_NetworkisKinematic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Rigidbody2D), Member = "get_gravityScale", ReturnType = typeof(float))]
	[Calls(Type = typeof(NetworkRigidbody2D), Member = "set_NetworkgravityScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkRigidbody2D), Member = "set_Networkdrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Server]
	[Token(Token = "0x60002D7")]
	private void SyncToClients() { }

	[Address(RVA = "0x1230330", Offset = "0x122F530", Length = "0x11F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isOwned", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkRigidbody2D), Member = "SendVelocity", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkRigidbody2D), Member = "SendRigidBodySettings", ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkRigidbody2D), Member = "SyncToClients", ReturnType = typeof(void))]
	[Token(Token = "0x60002D5")]
	internal void Update() { }

	[Address(RVA = "0x1230450", Offset = "0x122F650", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkRigidbody2D), Member = "set_NetworkgravityScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Rigidbody2D), Member = "set_gravityScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002F5")]
	protected void UserCode_CmdChangeGravityScale__Single(float gravityScale) { }

	[Address(RVA = "0x12304A0", Offset = "0x122F6A0", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkRigidbody2D), Member = "set_NetworkangularDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002F9")]
	protected void UserCode_CmdSendAngularDrag__Single(float angularDrag) { }

	[Address(RVA = "0x12304F0", Offset = "0x122F6F0", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkRigidbody2D), Member = "set_Networkdrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002F7")]
	protected void UserCode_CmdSendDrag__Single(float drag) { }

	[Address(RVA = "0x1230540", Offset = "0x122F740", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkRigidbody2D), Member = "set_NetworkisKinematic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Rigidbody2D), Member = "set_isKinematic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002F3")]
	protected void UserCode_CmdSendIsKinematic__Boolean(bool isKinematic) { }

	[Address(RVA = "0x1230620", Offset = "0x122F820", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkRigidbody2D), Member = "set_Networkvelocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Rigidbody2D), Member = "set_velocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002EF")]
	protected void UserCode_CmdSendVelocity__Vector2(Vector2 velocity) { }

	[Address(RVA = "0x1230590", Offset = "0x122F790", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkRigidbody2D), Member = "set_Networkvelocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Rigidbody2D), Member = "set_velocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkRigidbody2D), Member = "set_NetworkangularVelocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Rigidbody2D), Member = "set_angularVelocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002F1")]
	protected void UserCode_CmdSendVelocityAndAngular__Vector2__Single(Vector2 velocity, float angularVelocity) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002E2")]
	public virtual bool Weaved() { }

}

