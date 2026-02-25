namespace Mirror;

[Token(Token = "0x2000061")]
public static class GeneratedNetworkCode
{

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000332")]
	public static AddPlayerMessage _Read_Mirror.AddPlayerMessage(NetworkReader reader) { }

	[Address(RVA = "0x4F5AB0", Offset = "0x4F4CB0", Length = "0x36")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000340")]
	public static ChangeOwnerMessage _Read_Mirror.ChangeOwnerMessage(NetworkReader reader) { }

	[Address(RVA = "0x4F5AF0", Offset = "0x4F4CF0", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadArraySegmentAndSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(System.ArraySegment`1<System.Byte>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000338")]
	public static CommandMessage _Read_Mirror.CommandMessage(NetworkReader reader) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000350")]
	public static ServerRequest _Read_Mirror.Discovery.ServerRequest(NetworkReader reader) { }

	[Address(RVA = "0x4F5B70", Offset = "0x4F4D70", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Uri))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000352")]
	public static ServerResponse _Read_Mirror.Discovery.ServerResponse(NetworkReader reader) { }

	[Address(RVA = "0x4F5BD0", Offset = "0x4F4DD0", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadArraySegmentAndSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(System.ArraySegment`1<System.Byte>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600034A")]
	public static EntityStateMessage _Read_Mirror.EntityStateMessage(NetworkReader reader) { }

	[Address(RVA = "0x4F5C30", Offset = "0x4F4E30", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(double))]
	[DeduplicatedMethod]
	[Token(Token = "0x600034C")]
	public static NetworkPingMessage _Read_Mirror.NetworkPingMessage(NetworkReader reader) { }

	[Address(RVA = "0x4F5C80", Offset = "0x4F4E80", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(double))]
	[DeduplicatedMethod]
	[Token(Token = "0x600034E")]
	public static NetworkPongMessage _Read_Mirror.NetworkPongMessage(NetworkReader reader) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000330")]
	public static NotReadyMessage _Read_Mirror.NotReadyMessage(NetworkReader reader) { }

	[Address(RVA = "0x4F5CE0", Offset = "0x4F4EE0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000346")]
	public static ObjectDestroyMessage _Read_Mirror.ObjectDestroyMessage(NetworkReader reader) { }

	[Address(RVA = "0x4F5CE0", Offset = "0x4F4EE0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000348")]
	public static ObjectHideMessage _Read_Mirror.ObjectHideMessage(NetworkReader reader) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000344")]
	public static ObjectSpawnFinishedMessage _Read_Mirror.ObjectSpawnFinishedMessage(NetworkReader reader) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000342")]
	public static ObjectSpawnStartedMessage _Read_Mirror.ObjectSpawnStartedMessage(NetworkReader reader) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x600032E")]
	public static ReadyMessage _Read_Mirror.ReadyMessage(NetworkReader reader) { }

	[Address(RVA = "0x4F5AF0", Offset = "0x4F4CF0", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadArraySegmentAndSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(System.ArraySegment`1<System.Byte>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600033A")]
	public static RpcMessage _Read_Mirror.RpcMessage(NetworkReader reader) { }

	[Address(RVA = "0x4F5CF0", Offset = "0x4F4EF0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000334")]
	public static SceneMessage _Read_Mirror.SceneMessage(NetworkReader reader) { }

	[Address(RVA = "0x4F5D50", Offset = "0x4F4F50", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000335")]
	public static SceneOperation _Read_Mirror.SceneOperation(NetworkReader reader) { }

	[Address(RVA = "0x4F5D50", Offset = "0x4F4F50", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600033D")]
	public static SpawnFlags _Read_Mirror.SpawnFlags(NetworkReader reader) { }

	[Address(RVA = "0x4F5D60", Offset = "0x4F4F60", Length = "0xDF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadArraySegmentAndSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(System.ArraySegment`1<System.Byte>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x600033C")]
	public static SpawnMessage _Read_Mirror.SpawnMessage(NetworkReader reader) { }

	[Address(RVA = "0x124B550", Offset = "0x124A750", Length = "0xE5")]
	[CalledBy(Type = typeof(RemoteStatistics), Member = "InvokeUserCode_TargetRpcSync__Stats", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkBehaviour), typeof(NetworkReader), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000355")]
	public static Stats _Read_Mirror.Stats(NetworkReader reader) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x600032C")]
	public static TimeSnapshotMessage _Read_Mirror.TimeSnapshotMessage(NetworkReader reader) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000333")]
	public static void _Write_Mirror.AddPlayerMessage(NetworkWriter writer, AddPlayerMessage value) { }

	[Address(RVA = "0x4F5FA0", Offset = "0x4F51A0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000341")]
	public static void _Write_Mirror.ChangeOwnerMessage(NetworkWriter writer, ChangeOwnerMessage value) { }

	[Address(RVA = "0x4F5FD0", Offset = "0x4F51D0", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteUShort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ushort)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteArraySegmentAndSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000339")]
	public static void _Write_Mirror.CommandMessage(NetworkWriter writer, CommandMessage value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000351")]
	public static void _Write_Mirror.Discovery.ServerRequest(NetworkWriter writer, ServerRequest value) { }

	[Address(RVA = "0x4F6030", Offset = "0x4F5230", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Uri)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000353")]
	public static void _Write_Mirror.Discovery.ServerResponse(NetworkWriter writer, ServerResponse value) { }

	[Address(RVA = "0x4F6070", Offset = "0x4F5270", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteArraySegmentAndSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600034B")]
	public static void _Write_Mirror.EntityStateMessage(NetworkWriter writer, EntityStateMessage value) { }

	[Address(RVA = "0x4F60B0", Offset = "0x4F52B0", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(double)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600034D")]
	public static void _Write_Mirror.NetworkPingMessage(NetworkWriter writer, NetworkPingMessage value) { }

	[Address(RVA = "0x4F60F0", Offset = "0x4F52F0", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(double)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600034F")]
	public static void _Write_Mirror.NetworkPongMessage(NetworkWriter writer, NetworkPongMessage value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000331")]
	public static void _Write_Mirror.NotReadyMessage(NetworkWriter writer, NotReadyMessage value) { }

	[Address(RVA = "0x4F6140", Offset = "0x4F5340", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000347")]
	public static void _Write_Mirror.ObjectDestroyMessage(NetworkWriter writer, ObjectDestroyMessage value) { }

	[Address(RVA = "0x4F6140", Offset = "0x4F5340", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000349")]
	public static void _Write_Mirror.ObjectHideMessage(NetworkWriter writer, ObjectHideMessage value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000345")]
	public static void _Write_Mirror.ObjectSpawnFinishedMessage(NetworkWriter writer, ObjectSpawnFinishedMessage value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000343")]
	public static void _Write_Mirror.ObjectSpawnStartedMessage(NetworkWriter writer, ObjectSpawnStartedMessage value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600032F")]
	public static void _Write_Mirror.ReadyMessage(NetworkWriter writer, ReadyMessage value) { }

	[Address(RVA = "0x4F5FD0", Offset = "0x4F51D0", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteUShort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ushort)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteArraySegmentAndSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600033B")]
	public static void _Write_Mirror.RpcMessage(NetworkWriter writer, RpcMessage value) { }

	[Address(RVA = "0x4F6150", Offset = "0x4F5350", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000336")]
	public static void _Write_Mirror.SceneMessage(NetworkWriter writer, SceneMessage value) { }

	[Address(RVA = "0x4F61A0", Offset = "0x4F53A0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000337")]
	public static void _Write_Mirror.SceneOperation(NetworkWriter writer, SceneOperation value) { }

	[Address(RVA = "0x4F61A0", Offset = "0x4F53A0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600033F")]
	public static void _Write_Mirror.SpawnFlags(NetworkWriter writer, SpawnFlags value) { }

	[Address(RVA = "0x4F61B0", Offset = "0x4F53B0", Length = "0xC7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteArraySegmentAndSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600033E")]
	public static void _Write_Mirror.SpawnMessage(NetworkWriter writer, SpawnMessage value) { }

	[Address(RVA = "0x124B640", Offset = "0x124A840", Length = "0xCE")]
	[CalledBy(Type = typeof(RemoteStatistics), Member = "TargetRpcSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stats)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RemoteStatistics), Member = "UpdateServer", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000354")]
	public static void _Write_Mirror.Stats(NetworkWriter writer, Stats value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600032D")]
	public static void _Write_Mirror.TimeSnapshotMessage(NetworkWriter writer, TimeSnapshotMessage value) { }

	[Address(RVA = "0x1246760", Offset = "0x1245960", Length = "0x1A48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	[Token(Token = "0x6000356")]
	public static void InitReadWriters() { }

}

