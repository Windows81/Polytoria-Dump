namespace Mirror;

[AddComponentMenu("Network/Network Transform Hybrid")]
[Token(Token = "0x200002E")]
public class NetworkTransformHybrid : NetworkBehaviourHybrid
{
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40000D0")]
	public bool useFixedUpdate; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40000D1")]
	private Nullable<TransformSnapshot> pendingSnapshot; //Field offset: 0x90
	[FieldOffset(Offset = "0xD0")]
	[Header("Target")]
	[Token(Token = "0x40000D2")]
	[Tooltip("The Transform component to sync. May be on this GameObject, or on a child.")]
	public Transform target; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40000D3")]
	[Tooltip("Buffer size limit to avoid ever growing list memory consumption attacks.")]
	public int bufferSizeLimit; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40000D4")]
	internal SortedList<Double, TransformSnapshot> clientSnapshots; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x40000D5")]
	internal SortedList<Double, TransformSnapshot> serverSnapshots; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Header("Synchronization")]
	[Token(Token = "0x40000D6")]
	[Tooltip("Send N snapshots per second. Multiples of frame rate make sense.")]
	public int sendRate; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF4")]
	[Token(Token = "0x40000D7")]
	private Vector3 lastSerializedBaselinePosition; //Field offset: 0xF4
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40000D8")]
	private Quaternion lastSerializedBaselineRotation; //Field offset: 0x100
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x40000D9")]
	private Vector3 lastSerializedBaselineScale; //Field offset: 0x110
	[FieldOffset(Offset = "0x11C")]
	[Token(Token = "0x40000DA")]
	private Vector3 lastDeserializedBaselinePosition; //Field offset: 0x11C
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x40000DB")]
	private Quaternion lastDeserializedBaselineRotation; //Field offset: 0x128
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x40000DC")]
	private Vector3 lastDeserializedBaselineScale; //Field offset: 0x138
	[FieldOffset(Offset = "0x144")]
	[Header("Sensitivity")]
	[Token(Token = "0x40000DD")]
	[Tooltip("Sensitivity of changes needed before an updated state is sent over the network")]
	public float positionSensitivity; //Field offset: 0x144
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x40000DE")]
	public float rotationSensitivity; //Field offset: 0x148
	[FieldOffset(Offset = "0x14C")]
	[Token(Token = "0x40000DF")]
	public float scaleSensitivity; //Field offset: 0x14C
	[FieldOffset(Offset = "0x150")]
	[Header("Selective Sync & interpolation")]
	[Token(Token = "0x40000E0")]
	public bool syncPosition; //Field offset: 0x150
	[FieldOffset(Offset = "0x151")]
	[Token(Token = "0x40000E1")]
	public bool syncRotation; //Field offset: 0x151
	[FieldOffset(Offset = "0x152")]
	[Token(Token = "0x40000E2")]
	public bool syncScale; //Field offset: 0x152
	[CompilerGenerated]
	[FieldOffset(Offset = "0x154")]
	[Token(Token = "0x40000E3")]
	private Vector3 <velocity>k__BackingField; //Field offset: 0x154
	[CompilerGenerated]
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x40000E4")]
	private Vector3 <angularVelocity>k__BackingField; //Field offset: 0x160
	[FieldOffset(Offset = "0x16C")]
	[Header("Debug")]
	[Token(Token = "0x40000E5")]
	public bool debugDraw; //Field offset: 0x16C
	[FieldOffset(Offset = "0x16D")]
	[Token(Token = "0x40000E6")]
	public bool showGizmos; //Field offset: 0x16D
	[FieldOffset(Offset = "0x16E")]
	[Token(Token = "0x40000E7")]
	public bool showOverlay; //Field offset: 0x16E
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x40000E8")]
	public Color overlayColor; //Field offset: 0x170

	[Token(Token = "0x17000012")]
	public private Vector3 angularVelocity
	{
		[Address(RVA = "0x1222D10", Offset = "0x1221F10", Length = "0x19")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600015D")]
		 get { } //Length: 25
		[Address(RVA = "0x1222D70", Offset = "0x1221F70", Length = "0x16")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600015E")]
		private set { } //Length: 22
	}

	[Token(Token = "0x17000010")]
	public float sendInterval
	{
		[Address(RVA = "0x1222D30", Offset = "0x1221F30", Length = "0x18")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600015A")]
		 get { } //Length: 24
	}

	[Token(Token = "0x17000011")]
	public private Vector3 velocity
	{
		[Address(RVA = "0x1222D50", Offset = "0x1221F50", Length = "0x19")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600015B")]
		 get { } //Length: 25
		[Address(RVA = "0x1222D90", Offset = "0x1221F90", Length = "0x16")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600015C")]
		private set { } //Length: 22
	}

	[Address(RVA = "0x1222870", Offset = "0x1221A70", Length = "0x20F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RemoteProcedureCalls), Member = "RegisterCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(RemoteCallDelegate), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RemoteProcedureCalls), Member = "RegisterRpc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(RemoteCallDelegate)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000185")]
	private static NetworkTransformHybrid() { }

	[Address(RVA = "0x1222A80", Offset = "0x1221C80", Length = "0x282")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SortedList`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkBehaviourHybrid), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x600017B")]
	public NetworkTransformHybrid() { }

	[Address(RVA = "0x121F010", Offset = "0x121E210", Length = "0x32B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isOwned", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_localRotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_ToEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_MakePositive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000162")]
	protected override void ApplySnapshot(TransformSnapshot interpolated) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600015F")]
	protected override void Awake() { }

	[Address(RVA = "0x121F340", Offset = "0x121E540", Length = "0x19D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendCommandInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Command]
	[Token(Token = "0x6000174")]
	public void CmdTeleport(Vector3 destination, Quaternion rotation) { }

	[Address(RVA = "0x121F4E0", Offset = "0x121E6E0", Length = "0x178")]
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
	[Token(Token = "0x6000173")]
	public void CmdTeleport(Vector3 destination) { }

	[Address(RVA = "0x121F660", Offset = "0x121E860", Length = "0xD9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Nullable`1<Mirror.TransformSnapshot>), Member = "get_Value", ReturnType = typeof(TransformSnapshot))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600016E")]
	private void FixedUpdate() { }

	[Address(RVA = "0x1222D10", Offset = "0x1221F10", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600015D")]
	public Vector3 get_angularVelocity() { }

	[Address(RVA = "0x1222D30", Offset = "0x1221F30", Length = "0x18")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600015A")]
	public float get_sendInterval() { }

	[Address(RVA = "0x1222D50", Offset = "0x1221F50", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600015B")]
	public Vector3 get_velocity() { }

	[Address(RVA = "0x121F920", Offset = "0x121EB20", Length = "0x2E9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000182")]
	protected static void InvokeUserCode_CmdTeleport__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	[Address(RVA = "0x121F740", Offset = "0x121E940", Length = "0x1D3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(NetworkTransformHybrid), Member = "RpcTeleport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000184")]
	protected static void InvokeUserCode_CmdTeleport__Vector3__Quaternion(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	[Address(RVA = "0x121FD80", Offset = "0x121EF80", Length = "0x127")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600017E")]
	protected static void InvokeUserCode_RpcTeleport__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	[Address(RVA = "0x121FC10", Offset = "0x121EE10", Length = "0x162")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000180")]
	protected static void InvokeUserCode_RpcTeleport__Vector3__Quaternion(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	[Address(RVA = "0x121FEB0", Offset = "0x121F0B0", Length = "0x324")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_connectionToClient", ReturnType = typeof(NetworkConnectionToClient))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(TransformSnapshot), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double), typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SnapshotInterpolation), Member = "InsertIfNotExists", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformSnapshot)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.SortedList`2<System.Double, Mirror.TransformSnapshot>), typeof(int), typeof(TransformSnapshot)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000169")]
	protected override void OnClientToServerDeltaSync(Nullable<Vector3> position, Nullable<Quaternion> rotation, Nullable<Vector3> scale) { }

	[Address(RVA = "0x1220880", Offset = "0x121FA80", Length = "0x298")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkBehaviourHybrid), Member = "OnDeserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600017A")]
	public virtual void OnDeserialize(NetworkReader reader, bool initialState) { }

	[Address(RVA = "0x12201E0", Offset = "0x121F3E0", Length = "0x389")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "DrawLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Color), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isClient", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000166")]
	protected virtual void OnDeserializeBaseline(NetworkReader reader, byte baselineTick) { }

	[Address(RVA = "0x1220570", Offset = "0x121F770", Length = "0x301")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "DrawLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Color), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isClient", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000168")]
	protected virtual void OnDeserializeDelta(NetworkReader reader, byte baselineTick) { }

	[Address(RVA = "0x42FB70", Offset = "0x42ED70", Length = "0x14")]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000177")]
	protected override void OnDisable() { }

	[Address(RVA = "0x42FB70", Offset = "0x42ED70", Length = "0x14")]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000178")]
	protected override void OnEnable() { }

	[Address(RVA = "0x1220C30", Offset = "0x121FE30", Length = "0x115")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviourHybrid), Member = "OnSerialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "GetLocalPositionAndRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3&), typeof(Quaternion&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000179")]
	public virtual void OnSerialize(NetworkWriter writer, bool initialState) { }

	[Address(RVA = "0x1220B20", Offset = "0x121FD20", Length = "0x101")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "GetLocalPositionAndRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3&), typeof(Quaternion&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000165")]
	protected virtual void OnSerializeBaseline(NetworkWriter writer) { }

	[Address(RVA = "0x1220B20", Offset = "0x121FD20", Length = "0x101")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "GetLocalPositionAndRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3&), typeof(Quaternion&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000167")]
	protected virtual void OnSerializeDelta(NetworkWriter writer) { }

	[Address(RVA = "0x1220D50", Offset = "0x121FF50", Length = "0x358")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviourHybrid), Member = "get_IsClientWithAuthority", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(TransformSnapshot), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double), typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SnapshotInterpolation), Member = "InsertIfNotExists", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformSnapshot)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.SortedList`2<System.Double, Mirror.TransformSnapshot>), typeof(int), typeof(TransformSnapshot)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600016A")]
	protected override void OnServerToClientDeltaSync(Nullable<Vector3> position, Nullable<Quaternion> rotation, Nullable<Vector3> scale) { }

	[Address(RVA = "0x12210B0", Offset = "0x12202B0", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600016F")]
	protected override void OnTeleport(Vector3 destination) { }

	[Address(RVA = "0x1221110", Offset = "0x1220310", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000170")]
	protected override void OnTeleport(Vector3 destination, Quaternion rotation) { }

	[Address(RVA = "0x12211A0", Offset = "0x12203A0", Length = "0xEF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "OnValidate", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000160")]
	protected virtual void OnValidate() { }

	[Address(RVA = "0x1221490", Offset = "0x1220690", Length = "0xA4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000161")]
	private void Reset() { }

	[Address(RVA = "0x1221290", Offset = "0x1220490", Length = "0x1FF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkBehaviourHybrid), Member = "ResetState", ReturnType = typeof(void))]
	[Calls(Type = typeof(SortedList`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Physics), Member = "SyncTransforms", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000176")]
	public virtual void ResetState() { }

	[Address(RVA = "0x12216E0", Offset = "0x12208E0", Length = "0x178")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ClientRpc]
	[Token(Token = "0x6000171")]
	public void RpcTeleport(Vector3 destination) { }

	[Address(RVA = "0x1221540", Offset = "0x1220740", Length = "0x19D")]
	[CalledBy(Type = typeof(NetworkTransformHybrid), Member = "ServerTeleport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformHybrid), Member = "UserCode_CmdTeleport__Vector3__Quaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformHybrid), Member = "InvokeUserCode_CmdTeleport__Vector3__Quaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkBehaviour), typeof(NetworkReader), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Quaternion)}, ReturnType = typeof(void))]
	[ClientRpc]
	[Token(Token = "0x6000172")]
	public void RpcTeleport(Vector3 destination, Quaternion rotation) { }

	[Address(RVA = "0x1221860", Offset = "0x1220A60", Length = "0x14F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkTransformHybrid), Member = "RpcTeleport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Server]
	[Token(Token = "0x6000175")]
	public void ServerTeleport(Vector3 destination, Quaternion rotation) { }

	[Address(RVA = "0x1222D70", Offset = "0x1221F70", Length = "0x16")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600015E")]
	private void set_angularVelocity(Vector3 value) { }

	[Address(RVA = "0x1222D90", Offset = "0x1221F90", Length = "0x16")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600015C")]
	private void set_velocity(Vector3 value) { }

	[Address(RVA = "0x12219B0", Offset = "0x1220BB0", Length = "0x2F3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "GetLocalPositionAndRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3&), typeof(Quaternion&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E3A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000164")]
	protected virtual bool StateChanged() { }

	[Address(RVA = "0x1221CB0", Offset = "0x1220EB0", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "GetLocalPositionAndRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3&), typeof(Quaternion&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000163")]
	protected virtual void StoreState() { }

	[Address(RVA = "0x12221C0", Offset = "0x12213C0", Length = "0x3D9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_connectionToClient", ReturnType = typeof(NetworkConnectionToClient))]
	[Calls(Type = typeof(NetworkBehaviourHybrid), Member = "Update", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isClient", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviourHybrid), Member = "get_IsClientWithAuthority", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18120AE80")]
	[Calls(Type = typeof(SnapshotInterpolation), Member = "StepInterpolation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformSnapshot)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.SortedList`2<System.Double, Mirror.TransformSnapshot>), typeof(double), typeof(TransformSnapshot&), typeof(TransformSnapshot&), typeof(Double&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TransformSnapshot), Member = "Interpolate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformSnapshot), typeof(TransformSnapshot), typeof(double)}, ReturnType = typeof(TransformSnapshot))]
	[Calls(Type = typeof(System.Nullable`1<Mirror.TransformSnapshot>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformSnapshot)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isOwned", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600016D")]
	protected virtual void Update() { }

	[Address(RVA = "0x1221D20", Offset = "0x1220F20", Length = "0x24E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18120AE80")]
	[Calls(Type = typeof(SnapshotInterpolation), Member = "StepInterpolation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformSnapshot)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.SortedList`2<System.Double, Mirror.TransformSnapshot>), typeof(double), typeof(TransformSnapshot&), typeof(TransformSnapshot&), typeof(Double&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TransformSnapshot), Member = "Interpolate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformSnapshot), typeof(TransformSnapshot), typeof(double)}, ReturnType = typeof(TransformSnapshot))]
	[Calls(Type = typeof(System.Nullable`1<Mirror.TransformSnapshot>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformSnapshot)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600016C")]
	private void UpdateClientInterpolation() { }

	[Address(RVA = "0x1221F70", Offset = "0x1221170", Length = "0x24B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isOwned", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_connectionToClient", ReturnType = typeof(NetworkConnectionToClient))]
	[Calls(Type = typeof(SnapshotInterpolation), Member = "StepInterpolation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformSnapshot)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.SortedList`2<System.Double, Mirror.TransformSnapshot>), typeof(double), typeof(TransformSnapshot&), typeof(TransformSnapshot&), typeof(Double&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TransformSnapshot), Member = "Interpolate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformSnapshot), typeof(TransformSnapshot), typeof(double)}, ReturnType = typeof(TransformSnapshot))]
	[Calls(Type = typeof(System.Nullable`1<Mirror.TransformSnapshot>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformSnapshot)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600016B")]
	private void UpdateServerInterpolation() { }

	[Address(RVA = "0x1222640", Offset = "0x1221840", Length = "0x1AC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000181")]
	protected void UserCode_CmdTeleport__Vector3(Vector3 destination) { }

	[Address(RVA = "0x12225A0", Offset = "0x12217A0", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkTransformHybrid), Member = "RpcTeleport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000183")]
	protected void UserCode_CmdTeleport__Vector3__Quaternion(Vector3 destination, Quaternion rotation) { }

	[Address(RVA = "0x1222830", Offset = "0x1221A30", Length = "0x32")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600017D")]
	protected void UserCode_RpcTeleport__Vector3(Vector3 destination) { }

	[Address(RVA = "0x12227F0", Offset = "0x12219F0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600017F")]
	protected void UserCode_RpcTeleport__Vector3__Quaternion(Vector3 destination, Quaternion rotation) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x600017C")]
	public virtual bool Weaved() { }

}

