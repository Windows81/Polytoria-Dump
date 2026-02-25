namespace Mirror;

[Token(Token = "0x200006B")]
public class NetworkWriter
{
	[Token(Token = "0x4000183")]
	public const ushort MaxStringLength = 65534; //Field offset: 0x0
	[Token(Token = "0x4000184")]
	public const int DefaultCapacity = 1500; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000185")]
	internal Byte[] buffer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000186")]
	public int Position; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000187")]
	internal readonly UTF8Encoding encoding; //Field offset: 0x20

	[Token(Token = "0x1700005E")]
	public int Capacity
	{
		[Address(RVA = "0x513D30", Offset = "0x512F30", Length = "0x1A")]
		[CallerCount(Count = 83)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000370")]
		 get { } //Length: 26
	}

	[Address(RVA = "0x12A23C0", Offset = "0x12A15C0", Length = "0x99")]
	[CalledBy(Type = typeof(NetworkConnectionToClient), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkConnectionToClient), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkIdentity), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkWriterPool+<>c", Member = "<.cctor>b__5_0", ReturnType = typeof(NetworkWriterPooled))]
	[CalledBy(Type = typeof(NetworkWriterPooled), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.ConcurrentNetworkWriterPool+<>c", Member = "<.cctor>b__6_0", ReturnType = typeof(ConcurrentNetworkWriterPooled))]
	[CalledBy(Type = typeof(ConcurrentNetworkWriterPooled), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UTF8Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600037D")]
	public NetworkWriter() { }

	[Address(RVA = "0x12A1FA0", Offset = "0x12A11A0", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000372")]
	internal void EnsureCapacity(int value) { }

	[Address(RVA = "0x513D30", Offset = "0x512F30", Length = "0x1A")]
	[CallerCount(Count = 83)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000370")]
	public int get_Capacity() { }

	[Address(RVA = "0x12A2460", Offset = "0x12A1660", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000375")]
	public static ArraySegment<Byte> op_Implicit(NetworkWriter w) { }

	[Address(RVA = "0x12A2040", Offset = "0x12A1240", Length = "0x8")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000371")]
	public void Reset() { }

	[Address(RVA = "0x12A20B0", Offset = "0x12A12B0", Length = "0x6A")]
	[CalledBy(Type = "Mirror.NetworkAnimator", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkAnimator", Member = "CheckSendRate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "ConstrainedCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000373")]
	public Byte[] ToArray() { }

	[Address(RVA = "0x12A2050", Offset = "0x12A1250", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000374")]
	public ArraySegment<Byte> ToArraySegment() { }

	[Address(RVA = "0x12A2120", Offset = "0x12A1320", Length = "0x150")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BitConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600037C")]
	public virtual string ToString() { }

	[Address(RVA = "0x71B180", Offset = "0x71A380", Length = "0xFD")]
	[CalledBy(Type = typeof(NetworkBehaviour), Member = "SendRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkConnection), Member = "Send", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkMessages), Member = "Pack", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(NetworkWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Discovery.NetworkDiscoveryBase`2", Member = "ProcessClientRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Request", typeof(IPEndPoint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Discovery.NetworkDiscoveryBase`2", Member = "BroadcastDiscoveryRequest", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600037B")]
	public void Write(T value) { }

	[Address(RVA = "0x71ABE0", Offset = "0x719DE0", Length = "0x4D")]
	[CallerCount(Count = 43)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1807144E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000376")]
	internal void WriteBlittable(T value) { }

	[Address(RVA = "0x71A220", Offset = "0x719420", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkWriter), Member = "WriteByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1807144E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000377")]
	internal void WriteBlittableNullable(Nullable<T> value) { }

	[Address(RVA = "0x12A2280", Offset = "0x12A1480", Length = "0x48")]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkWriter), Member = "WriteBlittable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Token(Token = "0x6000378")]
	public void WriteByte(byte value) { }

	[Address(RVA = "0x12A22D0", Offset = "0x12A14D0", Length = "0x69")]
	[CalledBy(Type = "Mirror.ThreadedTransport", Member = "OnThreadedClientReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Transports.Encryption.EncryptedConnection", Member = "SendHandshakeAndPubKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.Transports.Encryption.EncryptedConnection+OpCodes"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Transports.Encryption.EncryptedConnection", Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.ThreadedTransport", Member = "ServerSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.ArraySegment`1<Byte>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.ThreadedTransport", Member = "ClientSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.ThreadedTransport", Member = "OnThreadedServerReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.ArraySegment`1<Byte>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.ThreadedTransport", Member = "OnThreadedServerSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.ArraySegment`1<Byte>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.ThreadedTransport", Member = "OnThreadedClientSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkIdentity), Member = "SerializeServer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(NetworkWriter), typeof(NetworkWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "OnTransportData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalConnectionToServer), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalConnectionToClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Unbatcher), Member = "AddBatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Batcher), Member = "GetBatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Batcher), Member = "CopyAndReturn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriterPooled), typeof(NetworkWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Batcher), Member = "AddMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(double)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Edgegap.EdgegapKcpClient", Member = "RawSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Edgegap.EdgegapKcpServer", Member = "RawSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.ArraySegment`1<Byte>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(Array), Member = "ConstrainedCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1807144E0")]
	[Token(Token = "0x6000379")]
	public void WriteBytes(Byte[] array, int offset, int count) { }

	[Address(RVA = "0x12A2340", Offset = "0x12A1540", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1807144E0")]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600037A")]
	public bool WriteBytes(Byte* ptr, int offset, int size) { }

}

