namespace Mirror;

[Token(Token = "0x2000034")]
public abstract class NetworkTransformBase : NetworkBehaviour
{
	[FieldOffset(Offset = "0x68")]
	[Header("Target")]
	[Token(Token = "0x4000108")]
	[Tooltip("The Transform component to sync. May be on on this GameObject, or on a child.")]
	public Transform target; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000109")]
	public readonly SortedList<Double, TransformSnapshot> clientSnapshots; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400010A")]
	public readonly SortedList<Double, TransformSnapshot> serverSnapshots; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Header("Selective Sync\nDon't change these at Runtime")]
	[Token(Token = "0x400010B")]
	public bool syncPosition; //Field offset: 0x80
	[FieldOffset(Offset = "0x81")]
	[Token(Token = "0x400010C")]
	public bool syncRotation; //Field offset: 0x81
	[FieldOffset(Offset = "0x82")]
	[Token(Token = "0x400010D")]
	public bool syncScale; //Field offset: 0x82
	[FieldOffset(Offset = "0x83")]
	[Header("Bandwidth Savings")]
	[Token(Token = "0x400010E")]
	[Tooltip("When true, changes are not sent unless greater than sensitivity values below.")]
	public bool onlySyncOnChange; //Field offset: 0x83
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x400010F")]
	[Tooltip("Apply smallest-three quaternion compression. This is lossy, you can disable it if the small rotation inaccuracies are noticeable in your project.")]
	public bool compressRotation; //Field offset: 0x84
	[FieldOffset(Offset = "0x85")]
	[Header("Interpolation")]
	[Token(Token = "0x4000110")]
	[Tooltip("Set to false to have a snap-like effect on position movement.")]
	public bool interpolatePosition; //Field offset: 0x85
	[FieldOffset(Offset = "0x86")]
	[Token(Token = "0x4000111")]
	[Tooltip("Set to false to have a snap-like effect on rotations.")]
	public bool interpolateRotation; //Field offset: 0x86
	[FieldOffset(Offset = "0x87")]
	[Token(Token = "0x4000112")]
	[Tooltip("Set to false to remove scale smoothing. Example use-case: Instant flipping of sprites that use -X and +X for direction.")]
	public bool interpolateScale; //Field offset: 0x87
	[FieldOffset(Offset = "0x88")]
	[Header("Coordinate Space")]
	[Token(Token = "0x4000113")]
	[Tooltip("Local by default. World may be better when changing hierarchy, or non-NetworkTransforms root position/rotation/scale values.")]
	public CoordinateSpace coordinateSpace; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Header("Timeline Offset")]
	[Token(Token = "0x4000114")]
	[Tooltip("Add a small timeline offset to account for decoupled arrival of NetworkTime and NetworkTransform snapshots.\nfixes: https://github.com/MirrorNetworking/Mirror/issues/3427")]
	public bool timelineOffset; //Field offset: 0x8C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000115")]
	private Vector3 <velocity>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x4000116")]
	private Vector3 <angularVelocity>k__BackingField; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA8")]
	[Header("Debug")]
	[Token(Token = "0x4000117")]
	public bool showGizmos; //Field offset: 0xA8
	[FieldOffset(Offset = "0xA9")]
	[Token(Token = "0x4000118")]
	public bool showOverlay; //Field offset: 0xA9
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x4000119")]
	public Color overlayColor; //Field offset: 0xAC

	[Token(Token = "0x17000018")]
	public private Vector3 angularVelocity
	{
		[Address(RVA = "0xE6C570", Offset = "0xE6B770", Length = "0x19")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001A9")]
		 get { } //Length: 25
		[Address(RVA = "0xE6C960", Offset = "0xE6BB60", Length = "0x16")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001AA")]
		private set { } //Length: 22
	}

	[Token(Token = "0x17000013")]
	protected bool IsClientWithAuthority
	{
		[Address(RVA = "0x123A210", Offset = "0x1239410", Length = "0x29")]
		[CalledBy(Type = typeof(NetworkRigidbodyReliable), Member = "FixedUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkRigidbodyReliable2D), Member = "FixedUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkRigidbodyUnreliable), Member = "FixedUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkRigidbodyUnreliable2D), Member = "FixedUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "UpdateServerBroadcast", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "OnServerToClientSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SyncData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(NetworkBehaviour), Member = "get_isClient", ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "get_authority", ReturnType = typeof(bool))]
		[Token(Token = "0x60001A3")]
		 get { } //Length: 41
	}

	[Token(Token = "0x17000016")]
	protected double offset
	{
		[Address(RVA = "0x123A240", Offset = "0x1239440", Length = "0x88")]
		[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "OnClientToServerSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SyncData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "OnServerToClientSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SyncData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkTransformReliable), Member = "OnClientToServerSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.Vector3>), typeof(System.Nullable`1<UnityEngine.Quaternion>), typeof(System.Nullable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkTransformReliable), Member = "OnServerToClientSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.Vector3>), typeof(System.Nullable`1<UnityEngine.Quaternion>), typeof(System.Nullable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(NetworkServer), Member = "get_sendInterval", ReturnType = typeof(float))]
		[Calls(Type = typeof(NetworkTransformBase), Member = "get_sendIntervalMultiplier", ReturnType = typeof(uint))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60001A6")]
		 get { } //Length: 136
	}

	[Token(Token = "0x17000014")]
	public uint sendIntervalMultiplier
	{
		[Address(RVA = "0x123A2D0", Offset = "0x12394D0", Length = "0x173")]
		[CalledBy(Type = typeof(NetworkTransformBase), Member = "get_offset", ReturnType = typeof(double))]
		[CalledBy(Type = typeof(NetworkTransformReliable), Member = "OnServerToClientSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.Vector3>), typeof(System.Nullable`1<UnityEngine.Quaternion>), typeof(System.Nullable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkTransformReliable), Member = "OnClientToServerSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.Vector3>), typeof(System.Nullable`1<UnityEngine.Quaternion>), typeof(System.Nullable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkTransformReliable), Member = "CheckLastSendTime", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkTransformReliable), Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkTransformBase), Member = "get_timeStampAdjustment", ReturnType = typeof(double))]
		[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "OnServerToClientSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SyncData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "UpdateClientBroadcast", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "UpdateServerBroadcast", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "CheckLastSendTime", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "OnClientToServerSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SyncData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(NetworkServer), Member = "get_sendInterval", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180288CC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60001A4")]
		 get { } //Length: 371
	}

	[Token(Token = "0x17000015")]
	protected double timeStampAdjustment
	{
		[Address(RVA = "0x123A450", Offset = "0x1239650", Length = "0x73")]
		[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "OnClientToServerSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SyncData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "OnServerToClientSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SyncData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkTransformReliable), Member = "OnClientToServerSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.Vector3>), typeof(System.Nullable`1<UnityEngine.Quaternion>), typeof(System.Nullable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkTransformReliable), Member = "OnServerToClientSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.Vector3>), typeof(System.Nullable`1<UnityEngine.Quaternion>), typeof(System.Nullable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(NetworkServer), Member = "get_sendInterval", ReturnType = typeof(float))]
		[Calls(Type = typeof(NetworkTransformBase), Member = "get_sendIntervalMultiplier", ReturnType = typeof(uint))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60001A5")]
		 get { } //Length: 115
	}

	[Token(Token = "0x17000017")]
	public private Vector3 velocity
	{
		[Address(RVA = "0x507500", Offset = "0x506700", Length = "0x19")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001A7")]
		 get { } //Length: 25
		[Address(RVA = "0x507850", Offset = "0x506A50", Length = "0x16")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001A8")]
		private set { } //Length: 22
	}

	[Address(RVA = "0x1239EC0", Offset = "0x12390C0", Length = "0x270")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RemoteProcedureCalls), Member = "RegisterCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(RemoteCallDelegate), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RemoteProcedureCalls), Member = "RegisterRpc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(RemoteCallDelegate)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x60001D0")]
	private static NetworkTransformBase() { }

	[Address(RVA = "0x123A130", Offset = "0x1239330", Length = "0xDF")]
	[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SortedList`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkBehaviour), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60001C4")]
	protected NetworkTransformBase() { }

	[Address(RVA = "0x12378E0", Offset = "0x1236AE0", Length = "0x174")]
	[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "OnClientToServerSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SyncData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "OnServerToClientSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SyncData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformReliable), Member = "OnClientToServerSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.Vector3>), typeof(System.Nullable`1<UnityEngine.Quaternion>), typeof(System.Nullable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformReliable), Member = "OnServerToClientSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.Vector3>), typeof(System.Nullable`1<UnityEngine.Quaternion>), typeof(System.Nullable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002D100")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60001B5")]
	protected void AddSnapshot(SortedList<Double, TransformSnapshot> snapshots, double timeStamp, Nullable<Vector3> position, Nullable<Quaternion> rotation, Nullable<Vector3> scale) { }

	[Address(RVA = "0x1237D10", Offset = "0x1236F10", Length = "0x386")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isOwned", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_localRotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_ToEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_MakePositive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60001B6")]
	protected override void Apply(TransformSnapshot interpolated, TransformSnapshot endGoal) { }

	[Address(RVA = "0x42FB70", Offset = "0x42ED70", Length = "0x14")]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001AD")]
	protected override void Awake() { }

	[Address(RVA = "0x12380A0", Offset = "0x12372A0", Length = "0x19D")]
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
	[Token(Token = "0x60001B8")]
	public void CmdTeleport(Vector3 destination, Quaternion rotation) { }

	[Address(RVA = "0x1238240", Offset = "0x1237440", Length = "0x178")]
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
	[Token(Token = "0x60001B7")]
	public void CmdTeleport(Vector3 destination) { }

	[Address(RVA = "0x12383C0", Offset = "0x12375C0", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60001AC")]
	protected override void Configure() { }

	[Address(RVA = "0x1238450", Offset = "0x1237650", Length = "0x107")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60001B4")]
	protected override TransformSnapshot Construct() { }

	[Address(RVA = "0xE6C570", Offset = "0xE6B770", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001A9")]
	public Vector3 get_angularVelocity() { }

	[Address(RVA = "0x123A210", Offset = "0x1239410", Length = "0x29")]
	[CalledBy(Type = typeof(NetworkRigidbodyReliable), Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkRigidbodyReliable2D), Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkRigidbodyUnreliable), Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkRigidbodyUnreliable2D), Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "UpdateServerBroadcast", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "OnServerToClientSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SyncData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isClient", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_authority", ReturnType = typeof(bool))]
	[Token(Token = "0x60001A3")]
	protected bool get_IsClientWithAuthority() { }

	[Address(RVA = "0x123A240", Offset = "0x1239440", Length = "0x88")]
	[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "OnClientToServerSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SyncData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "OnServerToClientSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SyncData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformReliable), Member = "OnClientToServerSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.Vector3>), typeof(System.Nullable`1<UnityEngine.Quaternion>), typeof(System.Nullable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformReliable), Member = "OnServerToClientSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.Vector3>), typeof(System.Nullable`1<UnityEngine.Quaternion>), typeof(System.Nullable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkServer), Member = "get_sendInterval", ReturnType = typeof(float))]
	[Calls(Type = typeof(NetworkTransformBase), Member = "get_sendIntervalMultiplier", ReturnType = typeof(uint))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001A6")]
	protected double get_offset() { }

	[Address(RVA = "0x123A2D0", Offset = "0x12394D0", Length = "0x173")]
	[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "OnClientToServerSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SyncData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "UpdateServerBroadcast", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "UpdateClientBroadcast", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "OnServerToClientSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SyncData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "CheckLastSendTime", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformReliable), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformReliable), Member = "CheckLastSendTime", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformReliable), Member = "OnClientToServerSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.Vector3>), typeof(System.Nullable`1<UnityEngine.Quaternion>), typeof(System.Nullable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformReliable), Member = "OnServerToClientSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.Vector3>), typeof(System.Nullable`1<UnityEngine.Quaternion>), typeof(System.Nullable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformBase), Member = "get_offset", ReturnType = typeof(double))]
	[CalledBy(Type = typeof(NetworkTransformBase), Member = "get_timeStampAdjustment", ReturnType = typeof(double))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(NetworkServer), Member = "get_sendInterval", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180288CC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001A4")]
	public uint get_sendIntervalMultiplier() { }

	[Address(RVA = "0x123A450", Offset = "0x1239650", Length = "0x73")]
	[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "OnClientToServerSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SyncData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformUnreliable), Member = "OnServerToClientSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SyncData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformReliable), Member = "OnClientToServerSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.Vector3>), typeof(System.Nullable`1<UnityEngine.Quaternion>), typeof(System.Nullable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformReliable), Member = "OnServerToClientSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.Vector3>), typeof(System.Nullable`1<UnityEngine.Quaternion>), typeof(System.Nullable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkServer), Member = "get_sendInterval", ReturnType = typeof(float))]
	[Calls(Type = typeof(NetworkTransformBase), Member = "get_sendIntervalMultiplier", ReturnType = typeof(uint))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001A5")]
	protected double get_timeStampAdjustment() { }

	[Address(RVA = "0x507500", Offset = "0x506700", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001A7")]
	public Vector3 get_velocity() { }

	[Address(RVA = "0x1238560", Offset = "0x1237760", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001AE")]
	protected override Vector3 GetPosition() { }

	[Address(RVA = "0x12385B0", Offset = "0x12377B0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_localRotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001AF")]
	protected override Quaternion GetRotation() { }

	[Address(RVA = "0x1238610", Offset = "0x1237810", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_lossyScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001B0")]
	protected override Vector3 GetScale() { }

	[Address(RVA = "0x1238840", Offset = "0x1237A40", Length = "0x2E9")]
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
	[Token(Token = "0x60001C7")]
	protected static void InvokeUserCode_CmdTeleport__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	[Address(RVA = "0x1238660", Offset = "0x1237860", Length = "0x1D3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(NetworkTransformBase), Member = "RpcTeleport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001C9")]
	protected static void InvokeUserCode_CmdTeleport__Vector3__Quaternion(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	[Address(RVA = "0x1238B30", Offset = "0x1237D30", Length = "0xE8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001CF")]
	protected static void InvokeUserCode_RpcResetState(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	[Address(RVA = "0x1238D90", Offset = "0x1237F90", Length = "0x127")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001CB")]
	protected static void InvokeUserCode_RpcTeleport__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	[Address(RVA = "0x1238C20", Offset = "0x1237E20", Length = "0x162")]
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
	[Token(Token = "0x60001CD")]
	protected static void InvokeUserCode_RpcTeleport__Vector3__Quaternion(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	[Address(RVA = "0x1238EC0", Offset = "0x12380C0", Length = "0x22D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[ServerCallback]
	[Token(Token = "0x60001C3")]
	private void OnClientAuthorityChanged(NetworkConnectionToClient conn, NetworkIdentity identity, bool authorityState) { }

	[Address(RVA = "0x12390F0", Offset = "0x12382F0", Length = "0x10C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ClientAuthorityCallback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkIdentity), Member = "remove_clientAuthorityCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientAuthorityCallback)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001C2")]
	protected override void OnDisable() { }

	[Address(RVA = "0x1239200", Offset = "0x1238400", Length = "0x10C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ClientAuthorityCallback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkIdentity), Member = "add_clientAuthorityCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientAuthorityCallback)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001C1")]
	protected override void OnEnable() { }

	[Address(RVA = "0x1239310", Offset = "0x1238510", Length = "0x51")]
	[CalledBy(Type = typeof(NetworkRigidbodyReliable), Member = "OnTeleport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkRigidbodyReliable2D), Member = "OnTeleport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkRigidbodyUnreliable), Member = "OnTeleport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkRigidbodyUnreliable2D), Member = "OnTeleport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001BD")]
	protected override void OnTeleport(Vector3 destination) { }

	[Address(RVA = "0x1239370", Offset = "0x1238570", Length = "0x7B")]
	[CalledBy(Type = typeof(NetworkRigidbodyReliable), Member = "OnTeleport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkRigidbodyReliable2D), Member = "OnTeleport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkRigidbodyUnreliable), Member = "OnTeleport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkRigidbodyUnreliable2D), Member = "OnTeleport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001BE")]
	protected override void OnTeleport(Vector3 destination, Quaternion rotation) { }

	[Address(RVA = "0x12393F0", Offset = "0x12385F0", Length = "0x71")]
	[CalledBy(Type = typeof(NetworkRigidbodyReliable), Member = "OnValidate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkRigidbodyReliable2D), Member = "OnValidate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkRigidbodyUnreliable), Member = "OnValidate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkRigidbodyUnreliable2D), Member = "OnValidate", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "OnValidate", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001AB")]
	protected virtual void OnValidate() { }

	[Address(RVA = "0x1239500", Offset = "0x1238700", Length = "0x29")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001C0")]
	public override void Reset() { }

	[Address(RVA = "0x1239470", Offset = "0x1238670", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SortedList`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Physics), Member = "SyncTransforms", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001BF")]
	public override void ResetState() { }

	[Address(RVA = "0x1239530", Offset = "0x1238730", Length = "0x14A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ClientRpc]
	[Token(Token = "0x60001BC")]
	private void RpcResetState() { }

	[Address(RVA = "0x1239680", Offset = "0x1238880", Length = "0x19D")]
	[CalledBy(Type = typeof(NetworkTransformBase), Member = "ServerTeleport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformBase), Member = "UserCode_CmdTeleport__Vector3__Quaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformBase), Member = "InvokeUserCode_CmdTeleport__Vector3__Quaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkBehaviour), typeof(NetworkReader), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
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
	[Token(Token = "0x60001BA")]
	public void RpcTeleport(Vector3 destination, Quaternion rotation) { }

	[Address(RVA = "0x1239820", Offset = "0x1238A20", Length = "0x178")]
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
	[Token(Token = "0x60001B9")]
	public void RpcTeleport(Vector3 destination) { }

	[Address(RVA = "0x12399A0", Offset = "0x1238BA0", Length = "0x14F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkTransformBase), Member = "RpcTeleport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Server]
	[Token(Token = "0x60001BB")]
	public void ServerTeleport(Vector3 destination, Quaternion rotation) { }

	[Address(RVA = "0xE6C960", Offset = "0xE6BB60", Length = "0x16")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001AA")]
	private void set_angularVelocity(Vector3 value) { }

	[Address(RVA = "0x507850", Offset = "0x506A50", Length = "0x16")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001A8")]
	private void set_velocity(Vector3 value) { }

	[Address(RVA = "0x1239AF0", Offset = "0x1238CF0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001B1")]
	protected override void SetPosition(Vector3 position) { }

	[Address(RVA = "0x1239B40", Offset = "0x1238D40", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "set_rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001B2")]
	protected override void SetRotation(Quaternion rotation) { }

	[Address(RVA = "0x1239B90", Offset = "0x1238D90", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001B3")]
	protected override void SetScale(Vector3 scale) { }

	[Address(RVA = "0x1239C70", Offset = "0x1238E70", Length = "0x1AC")]
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
	[Token(Token = "0x60001C6")]
	protected void UserCode_CmdTeleport__Vector3(Vector3 destination) { }

	[Address(RVA = "0x1239BD0", Offset = "0x1238DD0", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkTransformBase), Member = "RpcTeleport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001C8")]
	protected void UserCode_CmdTeleport__Vector3__Quaternion(Vector3 destination, Quaternion rotation) { }

	[Address(RVA = "0x1239E20", Offset = "0x1239020", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001CE")]
	protected void UserCode_RpcResetState() { }

	[Address(RVA = "0x1239E80", Offset = "0x1239080", Length = "0x32")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001CA")]
	protected void UserCode_RpcTeleport__Vector3(Vector3 destination) { }

	[Address(RVA = "0x1239E40", Offset = "0x1239040", Length = "0x40")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001CC")]
	protected void UserCode_RpcTeleport__Vector3__Quaternion(Vector3 destination, Quaternion rotation) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001C5")]
	public virtual bool Weaved() { }

}

