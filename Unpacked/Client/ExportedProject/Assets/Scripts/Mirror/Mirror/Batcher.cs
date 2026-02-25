namespace Mirror;

[Token(Token = "0x2000013")]
public class Batcher
{
	[Token(Token = "0x4000031")]
	public const int TimestampSize = 8; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000030")]
	private readonly int threshold; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000032")]
	private readonly Queue<NetworkWriterPooled> batches; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000033")]
	private NetworkWriterPooled batch; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000034")]
	private double batchTimestamp; //Field offset: 0x28

	[Address(RVA = "0x124D1E0", Offset = "0x124C3E0", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000081")]
	public Batcher(int threshold) { }

	[Address(RVA = "0x124C900", Offset = "0x124BB00", Length = "0x1CC")]
	[CalledBy(Type = typeof(LocalConnectionToClient), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalConnectionToServer), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkConnection), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Compression), Member = "CompressVarUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(Compression), Member = "VarUIntSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkWriter), Member = "WriteBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000082")]
	public void AddMessage(ArraySegment<Byte> message, double timeStamp) { }

	[Address(RVA = "0x124CAD0", Offset = "0x124BCD0", Length = "0x2FE")]
	[CalledBy(Type = typeof(NetworkConnection), Member = "Cleanup", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Queue`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1+Enumerator<System.Object>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.Queue`1+Enumerator<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1+Enumerator<System.Object>), Member = "get_Current", ReturnType = typeof(object))]
	[Token(Token = "0x6000085")]
	public void Clear() { }

	[Address(RVA = "0x124CDD0", Offset = "0x124BFD0", Length = "0x1D9")]
	[CalledBy(Type = typeof(Batcher), Member = "GetBatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriter), Member = "WriteBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000083")]
	private static void CopyAndReturn(NetworkWriterPooled batch, NetworkWriter writer) { }

	[Address(RVA = "0x124CFB0", Offset = "0x124C1B0", Length = "0x1F9")]
	[CalledBy(Type = typeof(LocalConnectionToClient), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalConnectionToServer), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkConnection), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF6F0")]
	[Calls(Type = typeof(NetworkWriter), Member = "WriteBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Batcher), Member = "CopyAndReturn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriterPooled), typeof(NetworkWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "TryDequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000084")]
	public bool GetBatch(NetworkWriter writer) { }

	[Address(RVA = "0x124D1B0", Offset = "0x124C3B0", Length = "0x16")]
	[CalledBy(Type = typeof(NetworkMessages), Member = "MaxContentSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(NetworkMessages), Member = "MaxMessageSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Compression), Member = "VarUIntSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000080")]
	public static int MaxMessageOverhead(int messageSize) { }

	[Address(RVA = "0x124D1D0", Offset = "0x124C3D0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Compression), Member = "VarUIntSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(int))]
	[Token(Token = "0x600007F")]
	public static int MessageHeaderSize(int messageSize) { }

}

