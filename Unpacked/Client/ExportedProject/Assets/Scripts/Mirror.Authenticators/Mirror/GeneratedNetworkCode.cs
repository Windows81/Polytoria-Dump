namespace Mirror;

[Token(Token = "0x2000010")]
public static class GeneratedNetworkCode
{

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000032")]
	public static AddPlayerMessage _Read_Mirror.AddPlayerMessage(NetworkReader reader) { }

	[Address(RVA = "0x10A9C90", Offset = "0x10A8E90", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000050")]
	public static AuthRequestMessage _Read_Mirror.Authenticators.BasicAuthenticator/AuthRequestMessage(NetworkReader reader) { }

	[Address(RVA = "0x10A9CF0", Offset = "0x10A8EF0", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000052")]
	public static AuthResponseMessage _Read_Mirror.Authenticators.BasicAuthenticator/AuthResponseMessage(NetworkReader reader) { }

	[Address(RVA = "0x10A9D40", Offset = "0x10A8F40", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000054")]
	public static AuthRequestMessage _Read_Mirror.Authenticators.DeviceAuthenticator/AuthRequestMessage(NetworkReader reader) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000056")]
	public static AuthResponseMessage _Read_Mirror.Authenticators.DeviceAuthenticator/AuthResponseMessage(NetworkReader reader) { }

	[Address(RVA = "0x4F5AB0", Offset = "0x4F4CB0", Length = "0x36")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000040")]
	public static ChangeOwnerMessage _Read_Mirror.ChangeOwnerMessage(NetworkReader reader) { }

	[Address(RVA = "0x4F5AF0", Offset = "0x4F4CF0", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadArraySegmentAndSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(System.ArraySegment`1<System.Byte>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000038")]
	public static CommandMessage _Read_Mirror.CommandMessage(NetworkReader reader) { }

	[Address(RVA = "0x4F5BD0", Offset = "0x4F4DD0", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadArraySegmentAndSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(System.ArraySegment`1<System.Byte>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600004A")]
	public static EntityStateMessage _Read_Mirror.EntityStateMessage(NetworkReader reader) { }

	[Address(RVA = "0x4F5C30", Offset = "0x4F4E30", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(double))]
	[DeduplicatedMethod]
	[Token(Token = "0x600004C")]
	public static NetworkPingMessage _Read_Mirror.NetworkPingMessage(NetworkReader reader) { }

	[Address(RVA = "0x4F5C80", Offset = "0x4F4E80", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(double))]
	[DeduplicatedMethod]
	[Token(Token = "0x600004E")]
	public static NetworkPongMessage _Read_Mirror.NetworkPongMessage(NetworkReader reader) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000030")]
	public static NotReadyMessage _Read_Mirror.NotReadyMessage(NetworkReader reader) { }

	[Address(RVA = "0x4F5CE0", Offset = "0x4F4EE0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000046")]
	public static ObjectDestroyMessage _Read_Mirror.ObjectDestroyMessage(NetworkReader reader) { }

	[Address(RVA = "0x4F5CE0", Offset = "0x4F4EE0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000048")]
	public static ObjectHideMessage _Read_Mirror.ObjectHideMessage(NetworkReader reader) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000044")]
	public static ObjectSpawnFinishedMessage _Read_Mirror.ObjectSpawnFinishedMessage(NetworkReader reader) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000042")]
	public static ObjectSpawnStartedMessage _Read_Mirror.ObjectSpawnStartedMessage(NetworkReader reader) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002E")]
	public static ReadyMessage _Read_Mirror.ReadyMessage(NetworkReader reader) { }

	[Address(RVA = "0x4F5AF0", Offset = "0x4F4CF0", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadArraySegmentAndSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(System.ArraySegment`1<System.Byte>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003A")]
	public static RpcMessage _Read_Mirror.RpcMessage(NetworkReader reader) { }

	[Address(RVA = "0x4F5CF0", Offset = "0x4F4EF0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000034")]
	public static SceneMessage _Read_Mirror.SceneMessage(NetworkReader reader) { }

	[Address(RVA = "0x4F5D50", Offset = "0x4F4F50", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000035")]
	public static SceneOperation _Read_Mirror.SceneOperation(NetworkReader reader) { }

	[Address(RVA = "0x4F5D50", Offset = "0x4F4F50", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003D")]
	public static SpawnFlags _Read_Mirror.SpawnFlags(NetworkReader reader) { }

	[Address(RVA = "0x4F5D60", Offset = "0x4F4F60", Length = "0xDF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadArraySegmentAndSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(System.ArraySegment`1<System.Byte>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003C")]
	public static SpawnMessage _Read_Mirror.SpawnMessage(NetworkReader reader) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002C")]
	public static TimeSnapshotMessage _Read_Mirror.TimeSnapshotMessage(NetworkReader reader) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000033")]
	public static void _Write_Mirror.AddPlayerMessage(NetworkWriter writer, AddPlayerMessage value) { }

	[Address(RVA = "0x10A9D70", Offset = "0x10A8F70", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000051")]
	public static void _Write_Mirror.Authenticators.BasicAuthenticator/AuthRequestMessage(NetworkWriter writer, AuthRequestMessage value) { }

	[Address(RVA = "0x10A9DB0", Offset = "0x10A8FB0", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000053")]
	public static void _Write_Mirror.Authenticators.BasicAuthenticator/AuthResponseMessage(NetworkWriter writer, AuthResponseMessage value) { }

	[Address(RVA = "0x10A9DF0", Offset = "0x10A8FF0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000055")]
	public static void _Write_Mirror.Authenticators.DeviceAuthenticator/AuthRequestMessage(NetworkWriter writer, AuthRequestMessage value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000057")]
	public static void _Write_Mirror.Authenticators.DeviceAuthenticator/AuthResponseMessage(NetworkWriter writer, AuthResponseMessage value) { }

	[Address(RVA = "0x4F5FA0", Offset = "0x4F51A0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000041")]
	public static void _Write_Mirror.ChangeOwnerMessage(NetworkWriter writer, ChangeOwnerMessage value) { }

	[Address(RVA = "0x4F5FD0", Offset = "0x4F51D0", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteUShort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ushort)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteArraySegmentAndSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000039")]
	public static void _Write_Mirror.CommandMessage(NetworkWriter writer, CommandMessage value) { }

	[Address(RVA = "0x4F6070", Offset = "0x4F5270", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteArraySegmentAndSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600004B")]
	public static void _Write_Mirror.EntityStateMessage(NetworkWriter writer, EntityStateMessage value) { }

	[Address(RVA = "0x4F60B0", Offset = "0x4F52B0", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(double)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600004D")]
	public static void _Write_Mirror.NetworkPingMessage(NetworkWriter writer, NetworkPingMessage value) { }

	[Address(RVA = "0x4F60F0", Offset = "0x4F52F0", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(double)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600004F")]
	public static void _Write_Mirror.NetworkPongMessage(NetworkWriter writer, NetworkPongMessage value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000031")]
	public static void _Write_Mirror.NotReadyMessage(NetworkWriter writer, NotReadyMessage value) { }

	[Address(RVA = "0x4F6140", Offset = "0x4F5340", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000047")]
	public static void _Write_Mirror.ObjectDestroyMessage(NetworkWriter writer, ObjectDestroyMessage value) { }

	[Address(RVA = "0x4F6140", Offset = "0x4F5340", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000049")]
	public static void _Write_Mirror.ObjectHideMessage(NetworkWriter writer, ObjectHideMessage value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000045")]
	public static void _Write_Mirror.ObjectSpawnFinishedMessage(NetworkWriter writer, ObjectSpawnFinishedMessage value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000043")]
	public static void _Write_Mirror.ObjectSpawnStartedMessage(NetworkWriter writer, ObjectSpawnStartedMessage value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002F")]
	public static void _Write_Mirror.ReadyMessage(NetworkWriter writer, ReadyMessage value) { }

	[Address(RVA = "0x4F5FD0", Offset = "0x4F51D0", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteUShort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ushort)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteArraySegmentAndSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003B")]
	public static void _Write_Mirror.RpcMessage(NetworkWriter writer, RpcMessage value) { }

	[Address(RVA = "0x4F6150", Offset = "0x4F5350", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000036")]
	public static void _Write_Mirror.SceneMessage(NetworkWriter writer, SceneMessage value) { }

	[Address(RVA = "0x4F61A0", Offset = "0x4F53A0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000037")]
	public static void _Write_Mirror.SceneOperation(NetworkWriter writer, SceneOperation value) { }

	[Address(RVA = "0x4F61A0", Offset = "0x4F53A0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003F")]
	public static void _Write_Mirror.SpawnFlags(NetworkWriter writer, SpawnFlags value) { }

	[Address(RVA = "0x4F61B0", Offset = "0x4F53B0", Length = "0xC7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteArraySegmentAndSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003E")]
	public static void _Write_Mirror.SpawnMessage(NetworkWriter writer, SpawnMessage value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002D")]
	public static void _Write_Mirror.TimeSnapshotMessage(NetworkWriter writer, TimeSnapshotMessage value) { }

	[Address(RVA = "0x10A4F80", Offset = "0x10A4180", Length = "0x4D09")]
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
	[CallsDeduplicatedMethods(Count = 62)]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	[Token(Token = "0x6000058")]
	public static void InitReadWriters() { }

}

