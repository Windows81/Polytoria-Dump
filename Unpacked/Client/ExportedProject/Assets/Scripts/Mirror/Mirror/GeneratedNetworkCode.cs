namespace Mirror;

[Token(Token = "0x20000AA")]
public static class GeneratedNetworkCode
{

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000530")]
	public static AddPlayerMessage _Read_Mirror.AddPlayerMessage(NetworkReader reader) { }

	[Address(RVA = "0x128DD70", Offset = "0x128CF70", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Compression), Member = "DecompressVarUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkReader), Member = "ReadBlittable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600053E")]
	public static ChangeOwnerMessage _Read_Mirror.ChangeOwnerMessage(NetworkReader reader) { }

	[Address(RVA = "0x128DDE0", Offset = "0x128CFE0", Length = "0x143")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Compression), Member = "DecompressVarUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkReader), Member = "ReadBlittable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(NetworkReader), Member = "ReadBytesSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.ArraySegment`1<System.Byte>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE5F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000536")]
	public static CommandMessage _Read_Mirror.CommandMessage(NetworkReader reader) { }

	[Address(RVA = "0x128DF30", Offset = "0x128D130", Length = "0xE2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Compression), Member = "DecompressVarUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkReader), Member = "ReadBytesSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.ArraySegment`1<System.Byte>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE5F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000548")]
	public static EntityStateMessage _Read_Mirror.EntityStateMessage(NetworkReader reader) { }

	[Address(RVA = "0x128E020", Offset = "0x128D220", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkReader), Member = "ReadBlittable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600054A")]
	public static NetworkPingMessage _Read_Mirror.NetworkPingMessage(NetworkReader reader) { }

	[Address(RVA = "0x128E0B0", Offset = "0x128D2B0", Length = "0xC6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkReader), Member = "ReadBlittable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600054C")]
	public static NetworkPongMessage _Read_Mirror.NetworkPongMessage(NetworkReader reader) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x600052E")]
	public static NotReadyMessage _Read_Mirror.NotReadyMessage(NetworkReader reader) { }

	[Address(RVA = "0x128E180", Offset = "0x128D380", Length = "0x7")]
	[CallerCount(Count = 75)]
	[Calls(Type = typeof(Compression), Member = "DecompressVarUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(ulong))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000544")]
	public static ObjectDestroyMessage _Read_Mirror.ObjectDestroyMessage(NetworkReader reader) { }

	[Address(RVA = "0x128E180", Offset = "0x128D380", Length = "0x7")]
	[CallerCount(Count = 75)]
	[Calls(Type = typeof(Compression), Member = "DecompressVarUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(ulong))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000546")]
	public static ObjectHideMessage _Read_Mirror.ObjectHideMessage(NetworkReader reader) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000542")]
	public static ObjectSpawnFinishedMessage _Read_Mirror.ObjectSpawnFinishedMessage(NetworkReader reader) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000540")]
	public static ObjectSpawnStartedMessage _Read_Mirror.ObjectSpawnStartedMessage(NetworkReader reader) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x600052C")]
	public static ReadyMessage _Read_Mirror.ReadyMessage(NetworkReader reader) { }

	[Address(RVA = "0x128DDE0", Offset = "0x128CFE0", Length = "0x143")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Compression), Member = "DecompressVarUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkReader), Member = "ReadBlittable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(NetworkReader), Member = "ReadBytesSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.ArraySegment`1<System.Byte>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE5F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000538")]
	public static RpcMessage _Read_Mirror.RpcMessage(NetworkReader reader) { }

	[Address(RVA = "0x128E190", Offset = "0x128D390", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkReader), Member = "ReadBlittable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000532")]
	public static SceneMessage _Read_Mirror.SceneMessage(NetworkReader reader) { }

	[Address(RVA = "0x128E240", Offset = "0x128D440", Length = "0x43")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkReader), Member = "ReadBlittable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000533")]
	public static SceneOperation _Read_Mirror.SceneOperation(NetworkReader reader) { }

	[Address(RVA = "0x128E240", Offset = "0x128D440", Length = "0x43")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkReader), Member = "ReadBlittable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600053B")]
	public static SpawnFlags _Read_Mirror.SpawnFlags(NetworkReader reader) { }

	[Address(RVA = "0x128E290", Offset = "0x128D490", Length = "0x1F6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Compression), Member = "DecompressVarUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkReader), Member = "ReadBlittable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(NetworkReader), Member = "ReadBytesSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.ArraySegment`1<System.Byte>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE5F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600053A")]
	public static SpawnMessage _Read_Mirror.SpawnMessage(NetworkReader reader) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x600052A")]
	public static TimeSnapshotMessage _Read_Mirror.TimeSnapshotMessage(NetworkReader reader) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000531")]
	public static void _Write_Mirror.AddPlayerMessage(NetworkWriter writer, AddPlayerMessage value) { }

	[Address(RVA = "0x128E490", Offset = "0x128D690", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Compression), Member = "CompressVarUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkWriter), Member = "WriteBlittable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600053F")]
	public static void _Write_Mirror.ChangeOwnerMessage(NetworkWriter writer, ChangeOwnerMessage value) { }

	[Address(RVA = "0x128E4F0", Offset = "0x128D6F0", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Compression), Member = "CompressVarUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkWriter), Member = "WriteBlittable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteArraySegmentAndSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000537")]
	public static void _Write_Mirror.CommandMessage(NetworkWriter writer, CommandMessage value) { }

	[Address(RVA = "0x128E5A0", Offset = "0x128D7A0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Compression), Member = "CompressVarUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteArraySegmentAndSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000549")]
	public static void _Write_Mirror.EntityStateMessage(NetworkWriter writer, EntityStateMessage value) { }

	[Address(RVA = "0x128E5E0", Offset = "0x128D7E0", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkWriter), Member = "WriteBlittable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600054B")]
	public static void _Write_Mirror.NetworkPingMessage(NetworkWriter writer, NetworkPingMessage value) { }

	[Address(RVA = "0x128E670", Offset = "0x128D870", Length = "0xB3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkWriter), Member = "WriteBlittable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600054D")]
	public static void _Write_Mirror.NetworkPongMessage(NetworkWriter writer, NetworkPongMessage value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600052F")]
	public static void _Write_Mirror.NotReadyMessage(NetworkWriter writer, NotReadyMessage value) { }

	[Address(RVA = "0x128E730", Offset = "0x128D930", Length = "0xA")]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(Compression), Member = "CompressVarUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000545")]
	public static void _Write_Mirror.ObjectDestroyMessage(NetworkWriter writer, ObjectDestroyMessage value) { }

	[Address(RVA = "0x128E730", Offset = "0x128D930", Length = "0xA")]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(Compression), Member = "CompressVarUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000547")]
	public static void _Write_Mirror.ObjectHideMessage(NetworkWriter writer, ObjectHideMessage value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000543")]
	public static void _Write_Mirror.ObjectSpawnFinishedMessage(NetworkWriter writer, ObjectSpawnFinishedMessage value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000541")]
	public static void _Write_Mirror.ObjectSpawnStartedMessage(NetworkWriter writer, ObjectSpawnStartedMessage value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600052D")]
	public static void _Write_Mirror.ReadyMessage(NetworkWriter writer, ReadyMessage value) { }

	[Address(RVA = "0x128E4F0", Offset = "0x128D6F0", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Compression), Member = "CompressVarUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkWriter), Member = "WriteBlittable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteArraySegmentAndSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000539")]
	public static void _Write_Mirror.RpcMessage(NetworkWriter writer, RpcMessage value) { }

	[Address(RVA = "0x128E740", Offset = "0x128D940", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkWriter), Member = "WriteBlittable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000534")]
	public static void _Write_Mirror.SceneMessage(NetworkWriter writer, SceneMessage value) { }

	[Address(RVA = "0x128E7E0", Offset = "0x128D9E0", Length = "0x53")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkWriter), Member = "WriteBlittable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000535")]
	public static void _Write_Mirror.SceneOperation(NetworkWriter writer, SceneOperation value) { }

	[Address(RVA = "0x128E7E0", Offset = "0x128D9E0", Length = "0x53")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkWriter), Member = "WriteBlittable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600053D")]
	public static void _Write_Mirror.SpawnFlags(NetworkWriter writer, SpawnFlags value) { }

	[Address(RVA = "0x128E840", Offset = "0x128DA40", Length = "0x155")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Compression), Member = "CompressVarUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkWriter), Member = "WriteBlittable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteArraySegmentAndSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600053C")]
	public static void _Write_Mirror.SpawnMessage(NetworkWriter writer, SpawnMessage value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600052B")]
	public static void _Write_Mirror.TimeSnapshotMessage(NetworkWriter writer, TimeSnapshotMessage value) { }

	[Address(RVA = "0x12893D0", Offset = "0x12885D0", Length = "0x4999")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Action`2<System.Object, UnityEngine.Matrix4x4>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Nullable`1<UnityEngine.Matrix4x4>>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Action`2<System.Object, System.Nullable`1<UnityEngine.Ray>>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Func`2<System.Object, Mirror.SpawnMessage>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Action`2<System.Object, System.Nullable`1<UnityEngine.Matrix4x4>>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Action`2<System.Object, Mirror.SpawnMessage>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Nullable`1<UnityEngine.Ray>>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Func`2<System.Object, UnityEngine.Matrix4x4>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 59)]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	[Token(Token = "0x600054E")]
	public static void InitReadWriters() { }

}

