namespace Mirror.SimpleWeb;

[Token(Token = "0x2000011")]
public class BufferPool
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400002A")]
	internal readonly BufferBucket[] buckets; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400002B")]
	private readonly int bucketCount; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400002C")]
	private readonly int smallest; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400002D")]
	private readonly int largest; //Field offset: 0x20

	[Address(RVA = "0x1554630", Offset = "0x1553830", Length = "0x36D")]
	[CalledBy(Type = typeof(SimpleWebClient), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleWebServer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TcpConfig), typeof(int), typeof(int), typeof(SslConfig)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Math), Member = "Pow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028F4B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000046")]
	public BufferPool(int bucketCount, int smallest, int largest) { }

	[Address(RVA = "0x1554320", Offset = "0x1553520", Length = "0x1C9")]
	[CalledBy(Type = typeof(SimpleWebServer), Member = "SendAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebSocketClientStandAlone), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebSocketClientWebGl), Member = "onMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReceiveLoop), Member = "ReadOneMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Config), typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReceiveLoop), Member = "HandleArrayMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Config), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReceiveLoop), Member = "CopyMessageToBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferPool), typeof(bool), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(ArrayBuffer))]
	[CalledBy(Type = typeof(ServerHandshake), Member = "TryHandshake", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Connection)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ServerHandshake), Member = "ReadToEndForHandshake", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ServerHandshake), Member = "AcceptHandshake", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleWebServer), Member = "SendOne", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(BufferBucket), Member = "Take", ReturnType = typeof(ArrayBuffer))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Token(Token = "0x6000048")]
	public ArrayBuffer Take(int size) { }

	[Address(RVA = "0x15544F0", Offset = "0x15536F0", Length = "0x135")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Log), Member = "Error", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1", "T2"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Conditional("UNITY_ASSERTIONS")]
	[Token(Token = "0x6000047")]
	private void Validate() { }

}

