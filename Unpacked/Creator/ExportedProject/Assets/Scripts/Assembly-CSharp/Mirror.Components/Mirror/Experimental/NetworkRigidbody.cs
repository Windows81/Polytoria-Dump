namespace Mirror.Experimental;

[AddComponentMenu(null)]
[HelpURL("https://mirror-networking.gitbook.io/docs/components/network-rigidbody")]
[Obsolete("Use the new NetworkRigidbodyReliable/Unreliable component with Snapshot Interpolation instead.")]
[Token(Token = "0x2000050")]
public class NetworkRigidbody : NetworkBehaviour
{
	[Token(Token = "0x2000051")]
	internal class ClientSyncState
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001D9")]
		public double nextSyncTime; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001DA")]
		public Vector3 velocity; //Field offset: 0x18
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40001DB")]
		public Vector3 angularVelocity; //Field offset: 0x24
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001DC")]
		public bool isKinematic; //Field offset: 0x30
		[FieldOffset(Offset = "0x31")]
		[Token(Token = "0x40001DD")]
		public bool useGravity; //Field offset: 0x31
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x40001DE")]
		public float drag; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40001DF")]
		public float angularDrag; //Field offset: 0x38

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002CA")]
		public ClientSyncState() { }

	}

	[FieldOffset(Offset = "0x68")]
	[Header("Settings")]
	[SerializeField]
	[Token(Token = "0x40001C4")]
	internal Rigidbody target; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40001C5")]
	[Tooltip("Set to true if moves come from owner client, set to false if moves always come from server")]
	public bool clientAuthority; //Field offset: 0x70
	[FieldOffset(Offset = "0x71")]
	[Header("Velocity")]
	[SerializeField]
	[Token(Token = "0x40001C6")]
	[Tooltip("Syncs Velocity every SyncInterval")]
	private bool syncVelocity; //Field offset: 0x71
	[FieldOffset(Offset = "0x72")]
	[SerializeField]
	[Token(Token = "0x40001C7")]
	[Tooltip("Set velocity to 0 each frame (only works if syncVelocity is false")]
	private bool clearVelocity; //Field offset: 0x72
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	[Token(Token = "0x40001C8")]
	[Tooltip("Only Syncs Value if distance between previous and current is great than sensitivity")]
	private float velocitySensitivity; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Header("Angular Velocity")]
	[SerializeField]
	[Token(Token = "0x40001C9")]
	[Tooltip("Syncs AngularVelocity every SyncInterval")]
	private bool syncAngularVelocity; //Field offset: 0x78
	[FieldOffset(Offset = "0x79")]
	[SerializeField]
	[Token(Token = "0x40001CA")]
	[Tooltip("Set angularVelocity to 0 each frame (only works if syncAngularVelocity is false")]
	private bool clearAngularVelocity; //Field offset: 0x79
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	[Token(Token = "0x40001CB")]
	[Tooltip("Only Syncs Value if distance between previous and current is great than sensitivity")]
	private float angularVelocitySensitivity; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40001CC")]
	private readonly ClientSyncState previousValue; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[SyncVar(hook = "OnVelocityChanged")]
	[Token(Token = "0x40001CD")]
	private Vector3 velocity; //Field offset: 0x88
	[FieldOffset(Offset = "0x94")]
	[SyncVar(hook = "OnAngularVelocityChanged")]
	[Token(Token = "0x40001CE")]
	private Vector3 angularVelocity; //Field offset: 0x94
	[FieldOffset(Offset = "0xA0")]
	[SyncVar(hook = "OnIsKinematicChanged")]
	[Token(Token = "0x40001CF")]
	private bool isKinematic; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA1")]
	[SyncVar(hook = "OnUseGravityChanged")]
	[Token(Token = "0x40001D0")]
	private bool useGravity; //Field offset: 0xA1
	[FieldOffset(Offset = "0xA4")]
	[SyncVar(hook = "OnuDragChanged")]
	[Token(Token = "0x40001D1")]
	private float drag; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[SyncVar(hook = "OnAngularDragChanged")]
	[Token(Token = "0x40001D2")]
	private float angularDrag; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40001D3")]
	public Action<Vector3, Vector3> _Mirror_SyncVarHookDelegate_velocity; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40001D4")]
	public Action<Vector3, Vector3> _Mirror_SyncVarHookDelegate_angularVelocity; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40001D5")]
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_isKinematic; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40001D6")]
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_useGravity; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40001D7")]
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_drag; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40001D8")]
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_angularDrag; //Field offset: 0xD8

	[Token(Token = "0x1700002A")]
	private bool ClientWithAuthority
	{
		[Address(RVA = "0x1230BB0", Offset = "0x122FDB0", Length = "0x10")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NetworkBehaviour), Member = "get_isOwned", ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[Token(Token = "0x600029A")]
		private get { } //Length: 16
	}

	[Token(Token = "0x17000029")]
	private bool IgnoreSync
	{
		[Address(RVA = "0x1230BC0", Offset = "0x122FDC0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "get_isOwned", ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000299")]
		private get { } //Length: 57
	}

	[Token(Token = "0x17000030")]
	public float NetworkangularDrag
	{
		[Address(RVA = "0x3BC780", Offset = "0x3BB980", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002B9")]
		 get { } //Length: 9
		[Address(RVA = "0x1234900", Offset = "0x1233B00", Length = "0x68")]
		[CalledBy(Type = typeof(NetworkRigidbody), Member = "SyncToClients", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkRigidbody), Member = "UserCode_CmdSendAngularDrag__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkRigidbody), Member = "InvokeUserCode_CmdSendAngularDrag__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkBehaviour), typeof(NetworkReader), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Token(Token = "0x60002BA")]
		 set { } //Length: 104
	}

	[Token(Token = "0x1700002C")]
	public Vector3 NetworkangularVelocity
	{
		[Address(RVA = "0x122D510", Offset = "0x122C710", Length = "0x19")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002B1")]
		 get { } //Length: 25
		[Address(RVA = "0x1234970", Offset = "0x1233B70", Length = "0x7A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C370")]
		[Token(Token = "0x60002B2")]
		 set { } //Length: 122
	}

	[Token(Token = "0x1700002F")]
	public float Networkdrag
	{
		[Address(RVA = "0x3BC770", Offset = "0x3BB970", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002B7")]
		 get { } //Length: 9
		[Address(RVA = "0x12349F0", Offset = "0x1233BF0", Length = "0x68")]
		[CalledBy(Type = typeof(NetworkRigidbody), Member = "SyncToClients", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkRigidbody), Member = "UserCode_CmdSendDrag__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkRigidbody), Member = "InvokeUserCode_CmdSendDrag__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkBehaviour), typeof(NetworkReader), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Token(Token = "0x60002B8")]
		 set { } //Length: 104
	}

	[Token(Token = "0x1700002D")]
	public bool NetworkisKinematic
	{
		[Address(RVA = "0x3D66E0", Offset = "0x3D58E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002B3")]
		 get { } //Length: 8
		[Address(RVA = "0x1234A60", Offset = "0x1233C60", Length = "0x68")]
		[CalledBy(Type = typeof(NetworkRigidbody), Member = "SyncToClients", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkRigidbody), Member = "UserCode_CmdSendIsKinematic__Boolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkRigidbody), Member = "InvokeUserCode_CmdSendIsKinematic__Boolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkBehaviour), typeof(NetworkReader), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Token(Token = "0x60002B4")]
		 set { } //Length: 104
	}

	[Token(Token = "0x1700002E")]
	public bool NetworkuseGravity
	{
		[Address(RVA = "0x5D49F0", Offset = "0x5D3BF0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002B5")]
		 get { } //Length: 8
		[Address(RVA = "0x1234AD0", Offset = "0x1233CD0", Length = "0x68")]
		[CalledBy(Type = typeof(NetworkRigidbody), Member = "SyncToClients", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkRigidbody), Member = "UserCode_CmdSendUseGravity__Boolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkRigidbody), Member = "InvokeUserCode_CmdSendUseGravity__Boolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkBehaviour), typeof(NetworkReader), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Token(Token = "0x60002B6")]
		 set { } //Length: 104
	}

	[Token(Token = "0x1700002B")]
	public Vector3 Networkvelocity
	{
		[Address(RVA = "0x3BB940", Offset = "0x3BAB40", Length = "0x19")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002AF")]
		 get { } //Length: 25
		[Address(RVA = "0x1234B40", Offset = "0x1233D40", Length = "0x7A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C370")]
		[Token(Token = "0x60002B0")]
		 set { } //Length: 122
	}

	[Address(RVA = "0x12343C0", Offset = "0x12335C0", Length = "0x2EA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RemoteProcedureCalls), Member = "RegisterCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(RemoteCallDelegate), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x60002C7")]
	private static NetworkRigidbody() { }

	[Address(RVA = "0x12346B0", Offset = "0x12338B0", Length = "0x24A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkBehaviour), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Action`2<UnityEngine.Vector3, UnityEngine.Vector3>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60002AD")]
	public NetworkRigidbody() { }

	[Address(RVA = "0x1231010", Offset = "0x1230210", Length = "0x165")]
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
	[Token(Token = "0x60002AC")]
	private void CmdSendAngularDrag(float angularDrag) { }

	[Address(RVA = "0x1231180", Offset = "0x1230380", Length = "0x165")]
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
	[Token(Token = "0x60002AB")]
	private void CmdSendDrag(float drag) { }

	[Address(RVA = "0x12312F0", Offset = "0x12304F0", Length = "0x166")]
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
	[Token(Token = "0x60002A9")]
	private void CmdSendIsKinematic(bool isKinematic) { }

	[Address(RVA = "0x1231460", Offset = "0x1230660", Length = "0x166")]
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
	[Token(Token = "0x60002AA")]
	private void CmdSendUseGravity(bool useGravity) { }

	[Address(RVA = "0x1231780", Offset = "0x1230980", Length = "0x178")]
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
	[Token(Token = "0x60002A7")]
	private void CmdSendVelocity(Vector3 velocity) { }

	[Address(RVA = "0x12315D0", Offset = "0x12307D0", Length = "0x1A6")]
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
	[Token(Token = "0x60002A8")]
	private void CmdSendVelocityAndAngular(Vector3 velocity, Vector3 angularVelocity) { }

	[Address(RVA = "0x1231900", Offset = "0x1230B00", Length = "0x347")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3&), typeof(System.Action`2<UnityEngine.Vector3, UnityEngine.Vector3>), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Action`2<T, T>", "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(System.Action`2<System.Single, System.Single>), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60002C9")]
	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	[Address(RVA = "0x1231C50", Offset = "0x1230E50", Length = "0xE1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Rigidbody), Member = "set_angularVelocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Rigidbody), Member = "set_velocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002A2")]
	internal void FixedUpdate() { }

	[Address(RVA = "0x1230BB0", Offset = "0x122FDB0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isOwned", ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x600029A")]
	private bool get_ClientWithAuthority() { }

	[Address(RVA = "0x1230BC0", Offset = "0x122FDC0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isOwned", ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000299")]
	private bool get_IgnoreSync() { }

	[Address(RVA = "0x3BC780", Offset = "0x3BB980", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002B9")]
	public float get_NetworkangularDrag() { }

	[Address(RVA = "0x122D510", Offset = "0x122C710", Length = "0x19")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002B1")]
	public Vector3 get_NetworkangularVelocity() { }

	[Address(RVA = "0x3BC770", Offset = "0x3BB970", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002B7")]
	public float get_Networkdrag() { }

	[Address(RVA = "0x3D66E0", Offset = "0x3D58E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002B3")]
	public bool get_NetworkisKinematic() { }

	[Address(RVA = "0x5D49F0", Offset = "0x5D3BF0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002B5")]
	public bool get_NetworkuseGravity() { }

	[Address(RVA = "0x3BB940", Offset = "0x3BAB40", Length = "0x19")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002AF")]
	public Vector3 get_Networkvelocity() { }

	[Address(RVA = "0x1231D40", Offset = "0x1230F40", Length = "0x163")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(NetworkRigidbody), Member = "set_NetworkangularDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002C6")]
	protected static void InvokeUserCode_CmdSendAngularDrag__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	[Address(RVA = "0x1231EB0", Offset = "0x12310B0", Length = "0x163")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(NetworkRigidbody), Member = "set_Networkdrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002C4")]
	protected static void InvokeUserCode_CmdSendDrag__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	[Address(RVA = "0x1232020", Offset = "0x1231220", Length = "0x15E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkRigidbody), Member = "set_NetworkisKinematic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Rigidbody), Member = "set_isKinematic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002C0")]
	protected static void InvokeUserCode_CmdSendIsKinematic__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	[Address(RVA = "0x1232180", Offset = "0x1231380", Length = "0x15E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkRigidbody), Member = "set_NetworkuseGravity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Rigidbody), Member = "set_useGravity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002C2")]
	protected static void InvokeUserCode_CmdSendUseGravity__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	[Address(RVA = "0x1232580", Offset = "0x1231780", Length = "0x1F0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C370")]
	[Calls(Type = typeof(Rigidbody), Member = "set_velocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002BC")]
	protected static void InvokeUserCode_CmdSendVelocity__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	[Address(RVA = "0x12322E0", Offset = "0x12314E0", Length = "0x298")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C370")]
	[Calls(Type = typeof(Rigidbody), Member = "set_velocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Rigidbody), Member = "set_angularVelocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002BE")]
	protected static void InvokeUserCode_CmdSendVelocityAndAngular__Vector3__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	[Address(RVA = "0x1232780", Offset = "0x1231980", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isOwned", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002A0")]
	private void OnAngularDragChanged(float _, float newValue) { }

	[Address(RVA = "0x12327E0", Offset = "0x12319E0", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isOwned", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Rigidbody), Member = "set_angularVelocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600029C")]
	private void OnAngularVelocityChanged(Vector3 _, Vector3 newValue) { }

	[Address(RVA = "0x1232850", Offset = "0x1231A50", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isOwned", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Rigidbody), Member = "set_isKinematic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600029D")]
	private void OnIsKinematicChanged(bool _, bool newValue) { }

	[Address(RVA = "0x1232980", Offset = "0x1231B80", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isOwned", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600029F")]
	private void OnuDragChanged(float _, float newValue) { }

	[Address(RVA = "0x12328B0", Offset = "0x1231AB0", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isOwned", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Rigidbody), Member = "set_useGravity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600029E")]
	private void OnUseGravityChanged(bool _, bool newValue) { }

	[Address(RVA = "0x122CDB0", Offset = "0x122BFB0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "OnValidate", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000297")]
	protected virtual void OnValidate() { }

	[Address(RVA = "0x1232910", Offset = "0x1231B10", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isOwned", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Rigidbody), Member = "set_velocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600029B")]
	private void OnVelocityChanged(Vector3 _, Vector3 newValue) { }

	[Address(RVA = "0x12329E0", Offset = "0x1231BE0", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000298")]
	public override void Reset() { }

	[Address(RVA = "0x1232A70", Offset = "0x1231C70", Length = "0x796")]
	[CalledBy(Type = typeof(NetworkRigidbody), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkRigidbody), Member = "SendToServer", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Rigidbody), Member = "get_useGravity", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendCommandInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Rigidbody), Member = "get_isKinematic", ReturnType = typeof(bool))]
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
	[Token(Token = "0x60002A6")]
	private void SendRigidBodySettings() { }

	[Address(RVA = "0x1233210", Offset = "0x1232410", Length = "0xE0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isOwned", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkRigidbody), Member = "SendVelocity", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkRigidbody), Member = "SendRigidBodySettings", ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Client]
	[Token(Token = "0x60002A4")]
	private void SendToServer() { }

	[Address(RVA = "0x12332F0", Offset = "0x12324F0", Length = "0x673")]
	[CalledBy(Type = typeof(NetworkRigidbody), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkRigidbody), Member = "SendToServer", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Rigidbody), Member = "get_velocity", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendCommandInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Rigidbody), Member = "get_angularVelocity", ReturnType = typeof(Vector3))]
	[Client]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002A5")]
	private void SendVelocity() { }

	[Address(RVA = "0x1233970", Offset = "0x1232B70", Length = "0x190")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002C8")]
	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	[Address(RVA = "0x1234900", Offset = "0x1233B00", Length = "0x68")]
	[CalledBy(Type = typeof(NetworkRigidbody), Member = "SyncToClients", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkRigidbody), Member = "UserCode_CmdSendAngularDrag__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkRigidbody), Member = "InvokeUserCode_CmdSendAngularDrag__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkBehaviour), typeof(NetworkReader), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Token(Token = "0x60002BA")]
	public void set_NetworkangularDrag(in float value) { }

	[Address(RVA = "0x1234970", Offset = "0x1233B70", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C370")]
	[Token(Token = "0x60002B2")]
	public void set_NetworkangularVelocity(in Vector3 value) { }

	[Address(RVA = "0x12349F0", Offset = "0x1233BF0", Length = "0x68")]
	[CalledBy(Type = typeof(NetworkRigidbody), Member = "SyncToClients", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkRigidbody), Member = "UserCode_CmdSendDrag__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkRigidbody), Member = "InvokeUserCode_CmdSendDrag__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkBehaviour), typeof(NetworkReader), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Token(Token = "0x60002B8")]
	public void set_Networkdrag(in float value) { }

	[Address(RVA = "0x1234A60", Offset = "0x1233C60", Length = "0x68")]
	[CalledBy(Type = typeof(NetworkRigidbody), Member = "SyncToClients", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkRigidbody), Member = "UserCode_CmdSendIsKinematic__Boolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkRigidbody), Member = "InvokeUserCode_CmdSendIsKinematic__Boolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkBehaviour), typeof(NetworkReader), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Token(Token = "0x60002B4")]
	public void set_NetworkisKinematic(in bool value) { }

	[Address(RVA = "0x1234AD0", Offset = "0x1233CD0", Length = "0x68")]
	[CalledBy(Type = typeof(NetworkRigidbody), Member = "SyncToClients", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkRigidbody), Member = "UserCode_CmdSendUseGravity__Boolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkRigidbody), Member = "InvokeUserCode_CmdSendUseGravity__Boolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkBehaviour), typeof(NetworkReader), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Token(Token = "0x60002B6")]
	public void set_NetworkuseGravity(in bool value) { }

	[Address(RVA = "0x1234B40", Offset = "0x1233D40", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C370")]
	[Token(Token = "0x60002B0")]
	public void set_Networkvelocity(in Vector3 value) { }

	[Address(RVA = "0x1233B00", Offset = "0x1232D00", Length = "0x438")]
	[CalledBy(Type = typeof(NetworkRigidbody), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Rigidbody), Member = "get_angularVelocity", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkRigidbody), Member = "set_NetworkangularDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Rigidbody), Member = "get_velocity", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C370")]
	[Calls(Type = typeof(Rigidbody), Member = "get_isKinematic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkRigidbody), Member = "set_NetworkisKinematic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Rigidbody), Member = "get_useGravity", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkRigidbody), Member = "set_NetworkuseGravity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkRigidbody), Member = "set_Networkdrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Server]
	[Token(Token = "0x60002A3")]
	private void SyncToClients() { }

	[Address(RVA = "0x1233F40", Offset = "0x1233140", Length = "0x11F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isOwned", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkRigidbody), Member = "SendVelocity", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkRigidbody), Member = "SendRigidBodySettings", ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkRigidbody), Member = "SyncToClients", ReturnType = typeof(void))]
	[Token(Token = "0x60002A1")]
	internal void Update() { }

	[Address(RVA = "0x1234060", Offset = "0x1233260", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkRigidbody), Member = "set_NetworkangularDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002C5")]
	protected void UserCode_CmdSendAngularDrag__Single(float angularDrag) { }

	[Address(RVA = "0x12340B0", Offset = "0x12332B0", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkRigidbody), Member = "set_Networkdrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002C3")]
	protected void UserCode_CmdSendDrag__Single(float drag) { }

	[Address(RVA = "0x1234100", Offset = "0x1233300", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkRigidbody), Member = "set_NetworkisKinematic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Rigidbody), Member = "set_isKinematic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002BF")]
	protected void UserCode_CmdSendIsKinematic__Boolean(bool isKinematic) { }

	[Address(RVA = "0x1234150", Offset = "0x1233350", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkRigidbody), Member = "set_NetworkuseGravity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Rigidbody), Member = "set_useGravity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002C1")]
	protected void UserCode_CmdSendUseGravity__Boolean(bool useGravity) { }

	[Address(RVA = "0x1234300", Offset = "0x1233500", Length = "0xB0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C370")]
	[Calls(Type = typeof(Rigidbody), Member = "set_velocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002BB")]
	protected void UserCode_CmdSendVelocity__Vector3(Vector3 velocity) { }

	[Address(RVA = "0x12341A0", Offset = "0x12333A0", Length = "0x151")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C370")]
	[Calls(Type = typeof(Rigidbody), Member = "set_velocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Rigidbody), Member = "set_angularVelocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002BD")]
	protected void UserCode_CmdSendVelocityAndAngular__Vector3__Vector3(Vector3 velocity, Vector3 angularVelocity) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002AE")]
	public virtual bool Weaved() { }

}

