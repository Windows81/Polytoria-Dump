namespace Mirror;

[AddComponentMenu("Network/Network Transform (Reliable)")]
[Token(Token = "0x2000035")]
public class NetworkTransformReliable : NetworkTransformBase
{
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400011A")]
	private uint sendIntervalCounter; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x400011B")]
	private double lastSendIntervalTime; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x400011C")]
	private Nullable<TransformSnapshot> pendingSnapshot; //Field offset: 0xD0
	[FieldOffset(Offset = "0x110")]
	[Header("Additional Settings")]
	[Token(Token = "0x400011D")]
	[Tooltip("If we only sync on change, then we need to correct old snapshots if more time than sendInterval * multiplier has elapsed.\n\nOtherwise the first move will always start interpolating from the last move sequence's time, which will make it stutter when starting every time.")]
	public float onlySyncOnChangeCorrectionMultiplier; //Field offset: 0x110
	[FieldOffset(Offset = "0x114")]
	[Token(Token = "0x400011E")]
	public bool useFixedUpdate; //Field offset: 0x114
	[FieldOffset(Offset = "0x118")]
	[Header("Rotation")]
	[Token(Token = "0x400011F")]
	[Tooltip("Sensitivity of changes needed before an updated state is sent over the network")]
	public float rotationSensitivity; //Field offset: 0x118
	[FieldOffset(Offset = "0x11C")]
	[Header("Precision")]
	[Range(0.0001, 1)]
	[Token(Token = "0x4000120")]
	[Tooltip("Position is rounded in order to drastically minimize bandwidth.\n\nFor example, a precision of 0.01 rounds to a centimeter. In other words, sub-centimeter movements aren't synced until they eventually exceeded an actual centimeter.\n\nDepending on how important the object is, a precision of 0.01-0.10 (1-10 cm) is recommended.\n\nFor example, even a 1cm precision combined with delta compression cuts the Benchmark demo's bandwidth in half, compared to sending every tiny change.")]
	public float positionPrecision; //Field offset: 0x11C
	[FieldOffset(Offset = "0x120")]
	[Range(0.0001, 1)]
	[Token(Token = "0x4000121")]
	public float scalePrecision; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000122")]
	protected Vector3Long lastSerializedPosition; //Field offset: 0x128
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000123")]
	protected Vector3Long lastDeserializedPosition; //Field offset: 0x140
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x4000124")]
	protected Vector3Long lastSerializedScale; //Field offset: 0x158
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x4000125")]
	protected Vector3Long lastDeserializedScale; //Field offset: 0x170
	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x4000126")]
	protected TransformSnapshot last; //Field offset: 0x188

	[Address(RVA = "0x123C9F0", Offset = "0x123BBF0", Length = "0x201")]
	[CalledBy(Type = typeof(NetworkRigidbodyReliable), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkRigidbodyReliable2D), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SortedList`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkBehaviour), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60001E0")]
	public NetworkTransformReliable() { }

	[Address(RVA = "0x123A520", Offset = "0x1239720", Length = "0x18E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18122A770")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E3A0")]
	[Token(Token = "0x60001D7")]
	protected override bool Changed(TransformSnapshot current) { }

	[Address(RVA = "0x123A6B0", Offset = "0x12398B0", Length = "0xDF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[Calls(Type = typeof(NetworkServer), Member = "get_sendInterval", ReturnType = typeof(float))]
	[Calls(Type = typeof(NetworkTransformBase), Member = "get_sendIntervalMultiplier", ReturnType = typeof(uint))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001D6")]
	protected override void CheckLastSendTime() { }

	[Address(RVA = "0x123A790", Offset = "0x1239990", Length = "0x14F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isClient", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_authority", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Nullable`1<Mirror.TransformSnapshot>), Member = "get_Value", ReturnType = typeof(TransformSnapshot))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001D2")]
	private void FixedUpdate() { }

	[Address(RVA = "0x123A8E0", Offset = "0x1239AE0", Length = "0x13D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isClient", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_authority", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkTransformBase), Member = "get_sendIntervalMultiplier", ReturnType = typeof(uint))]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60001D3")]
	private void LateUpdate() { }

	[Address(RVA = "0x123AA20", Offset = "0x1239C20", Length = "0x125")]
	[CalledBy(Type = typeof(NetworkTransformReliable), Member = "OnClientToServerSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.Vector3>), typeof(System.Nullable`1<UnityEngine.Quaternion>), typeof(System.Nullable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformReliable), Member = "OnServerToClientSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.Vector3>), typeof(System.Nullable`1<UnityEngine.Quaternion>), typeof(System.Nullable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001DD")]
	private static bool NeedsCorrection(SortedList<Double, TransformSnapshot> snapshots, double remoteTimestamp, double bufferTime, double toleranceMultiplier) { }

	[Address(RVA = "0x123AB50", Offset = "0x1239D50", Length = "0x37C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkTransformBase), Member = "get_sendIntervalMultiplier", ReturnType = typeof(uint))]
	[Calls(Type = typeof(NetworkTransformBase), Member = "AddSnapshot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.SortedList`2<System.Double, Mirror.TransformSnapshot>), typeof(double), typeof(System.Nullable`1<UnityEngine.Vector3>), typeof(System.Nullable`1<UnityEngine.Quaternion>), typeof(System.Nullable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_connectionToClient", ReturnType = typeof(NetworkConnectionToClient))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkServer), Member = "get_sendInterval", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(NetworkTransformReliable), Member = "NeedsCorrection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.SortedList`2<System.Double, Mirror.TransformSnapshot>), typeof(double), typeof(double), typeof(double)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[Calls(Type = typeof(NetworkTransformReliable), Member = "RewriteHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.SortedList`2<System.Double, Mirror.TransformSnapshot>), typeof(double), typeof(double), typeof(double), typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkTransformBase), Member = "get_timeStampAdjustment", ReturnType = typeof(double))]
	[Calls(Type = typeof(NetworkTransformBase), Member = "get_offset", ReturnType = typeof(double))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001DB")]
	protected override void OnClientToServerSync(Nullable<Vector3> position, Nullable<Quaternion> rotation, Nullable<Vector3> scale) { }

	[Address(RVA = "0x123AED0", Offset = "0x123A0D0", Length = "0x514")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18122A690")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Compression), Member = "DecompressVarUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(Compression), Member = "ScaleToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Compression), Member = "DecompressQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isClient", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001DA")]
	public virtual void OnDeserialize(NetworkReader reader, bool initialState) { }

	[Address(RVA = "0x123B3F0", Offset = "0x123A5F0", Length = "0x5C5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Compression), Member = "ScaleToLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Int64&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Compression), Member = "CompressVarUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Compression), Member = "CompressQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18122A690")]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Vector3)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001D9")]
	public virtual void OnSerialize(NetworkWriter writer, bool initialState) { }

	[Address(RVA = "0x123B9C0", Offset = "0x123ABC0", Length = "0x3DB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkTransformBase), Member = "get_sendIntervalMultiplier", ReturnType = typeof(uint))]
	[Calls(Type = typeof(NetworkTransformBase), Member = "AddSnapshot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.SortedList`2<System.Double, Mirror.TransformSnapshot>), typeof(double), typeof(System.Nullable`1<UnityEngine.Vector3>), typeof(System.Nullable`1<UnityEngine.Quaternion>), typeof(System.Nullable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isClient", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_authority", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "get_sendInterval", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(NetworkTransformReliable), Member = "NeedsCorrection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.SortedList`2<System.Double, Mirror.TransformSnapshot>), typeof(double), typeof(double), typeof(double)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180701270")]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[Calls(Type = typeof(NetworkTransformReliable), Member = "RewriteHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.SortedList`2<System.Double, Mirror.TransformSnapshot>), typeof(double), typeof(double), typeof(double), typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkTransformBase), Member = "get_timeStampAdjustment", ReturnType = typeof(double))]
	[Calls(Type = typeof(NetworkTransformBase), Member = "get_offset", ReturnType = typeof(double))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001DC")]
	protected override void OnServerToClientSync(Nullable<Vector3> position, Nullable<Quaternion> rotation, Nullable<Vector3> scale) { }

	[Address(RVA = "0x123BDA0", Offset = "0x123AFA0", Length = "0x246")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Compression), Member = "ScaleToLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Int64&)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001D8")]
	protected bool QuantizedChanged(Vector3 u, Vector3 v, float precision) { }

	[Address(RVA = "0x123BFF0", Offset = "0x123B1F0", Length = "0x25D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SortedList`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Physics), Member = "SyncTransforms", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001DF")]
	public virtual void ResetState() { }

	[Address(RVA = "0x123C250", Offset = "0x123B450", Length = "0x173")]
	[CalledBy(Type = typeof(NetworkTransformReliable), Member = "OnClientToServerSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.Vector3>), typeof(System.Nullable`1<UnityEngine.Quaternion>), typeof(System.Nullable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTransformReliable), Member = "OnServerToClientSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.Vector3>), typeof(System.Nullable`1<UnityEngine.Quaternion>), typeof(System.Nullable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SortedList`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SnapshotInterpolation), Member = "InsertIfNotExists", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformSnapshot)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.SortedList`2<System.Double, Mirror.TransformSnapshot>), typeof(int), typeof(TransformSnapshot)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001DE")]
	private static void RewriteHistory(SortedList<Double, TransformSnapshot> snapshots, double remoteTimeStamp, double localTime, double sendInterval, Vector3 position, Quaternion rotation, Vector3 scale) { }

	[Address(RVA = "0x123C990", Offset = "0x123BB90", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isClient", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60001D1")]
	private void Update() { }

	[Address(RVA = "0x123C3D0", Offset = "0x123B5D0", Length = "0x3C1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isClient", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_authority", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18120AE80")]
	[Calls(Type = typeof(SnapshotInterpolation), Member = "StepInterpolation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformSnapshot)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.SortedList`2<System.Double, Mirror.TransformSnapshot>), typeof(double), typeof(TransformSnapshot&), typeof(TransformSnapshot&), typeof(Double&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TransformSnapshot), Member = "Interpolate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformSnapshot), typeof(TransformSnapshot), typeof(double)}, ReturnType = typeof(TransformSnapshot))]
	[Calls(Type = typeof(System.Nullable`1<Mirror.TransformSnapshot>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformSnapshot)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001D5")]
	protected override void UpdateClient() { }

	[Address(RVA = "0x123C7A0", Offset = "0x123B9A0", Length = "0x1EE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_connectionToClient", ReturnType = typeof(NetworkConnectionToClient))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isOwned", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SnapshotInterpolation), Member = "StepInterpolation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformSnapshot)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.SortedList`2<System.Double, Mirror.TransformSnapshot>), typeof(double), typeof(TransformSnapshot&), typeof(TransformSnapshot&), typeof(Double&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TransformSnapshot), Member = "Interpolate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformSnapshot), typeof(TransformSnapshot), typeof(double)}, ReturnType = typeof(TransformSnapshot))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001D4")]
	protected override void UpdateServer() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001E1")]
	public virtual bool Weaved() { }

}

