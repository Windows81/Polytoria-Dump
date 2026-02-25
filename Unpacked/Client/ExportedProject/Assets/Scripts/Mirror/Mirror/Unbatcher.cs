namespace Mirror;

[Token(Token = "0x2000014")]
public class Unbatcher
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000035")]
	private readonly Queue<NetworkWriterPooled> batches; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000036")]
	private readonly NetworkReader reader; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000037")]
	private double readerRemoteTimeStamp; //Field offset: 0x20

	[Token(Token = "0x17000013")]
	public int BatchesCount
	{
		[Address(RVA = "0x126FCB0", Offset = "0x126EEB0", Length = "0x3C")]
		[CalledBy(Type = typeof(NetworkClient), Member = "OnTransportData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkServer), Member = "OnTransportData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000086")]
		 get { } //Length: 60
	}

	[Address(RVA = "0x126FB90", Offset = "0x126ED90", Length = "0x11B")]
	[CalledBy(Type = typeof(NetworkClient), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "Shutdown", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkConnectionToClient), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkConnectionToClient), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArraySegment`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = "System.ArraySegment`1<T>")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600008A")]
	public Unbatcher() { }

	[Address(RVA = "0x126F7D0", Offset = "0x126E9D0", Length = "0x146")]
	[CalledBy(Type = typeof(NetworkServer), Member = "OnTransportData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkWriter), Member = "WriteBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unbatcher), Member = "StartReadingBatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriterPooled)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000088")]
	public bool AddBatch(ArraySegment<Byte> batch) { }

	[Address(RVA = "0x126FCB0", Offset = "0x126EEB0", Length = "0x3C")]
	[CalledBy(Type = typeof(NetworkClient), Member = "OnTransportData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkServer), Member = "OnTransportData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000086")]
	public int get_BatchesCount() { }

	[Address(RVA = "0x126F920", Offset = "0x126EB20", Length = "0x1BA")]
	[CalledBy(Type = typeof(NetworkClient), Member = "OnTransportData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkServer), Member = "OnTransportData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Dequeue", ReturnType = typeof(object))]
	[Calls(Type = typeof(NetworkReader), Member = "ReadBytesSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.ArraySegment`1<System.Byte>))]
	[Calls(Type = typeof(Compression), Member = "DecompressVarUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(Unbatcher), Member = "StartReadingBatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriterPooled)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Peek", ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF6F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkReader), Member = "get_Remaining", ReturnType = typeof(int))]
	[Calls(Type = typeof(NetworkReader), Member = "get_Capacity", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000089")]
	public bool GetNextMessage(out ArraySegment<Byte>& message, out double remoteTimeStamp) { }

	[Address(RVA = "0x126FAE0", Offset = "0x126ECE0", Length = "0xAC")]
	[CalledBy(Type = typeof(Unbatcher), Member = "AddBatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Unbatcher), Member = "GetNextMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArraySegment`1<Byte>&), typeof(Double&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NetworkClient), Member = "OnTransportData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000087")]
	private void StartReadingBatch(NetworkWriterPooled batch) { }

}

