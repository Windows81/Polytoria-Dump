namespace Mirror.SimpleWeb;

[Token(Token = "0x200001C")]
internal static class ReceiveLoop
{
	[Token(Token = "0x200001D")]
	internal struct Config
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400005B")]
		public readonly Connection conn; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400005C")]
		public readonly int maxMessageSize; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x400005D")]
		public readonly bool expectMask; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400005E")]
		public readonly ConcurrentQueue<Message> queue; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400005F")]
		public readonly BufferPool bufferPool; //Field offset: 0x18

		[Address(RVA = "0x1555530", Offset = "0x1554730", Length = "0x148")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000086")]
		public Config(Connection conn, int maxMessageSize, bool expectMask, ConcurrentQueue<Message> queue, BufferPool bufferPool) { }

		[Address(RVA = "0x15554C0", Offset = "0x15546C0", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000087")]
		public void Deconstruct(out Connection conn, out int maxMessageSize, out bool expectMask, out ConcurrentQueue<Message>& queue, out BufferPool bufferPool) { }

	}

	[Token(Token = "0x200001E")]
	private struct Header
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000060")]
		public int payloadLength; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000061")]
		public int offset; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000062")]
		public int opcode; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000063")]
		public bool finished; //Field offset: 0xC

	}


	[Address(RVA = "0x1557E70", Offset = "0x1557070", Length = "0x104")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BufferPool), Member = "Take", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ArrayBuffer))]
	[Calls(Type = typeof(ArrayBuffer), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000082")]
	private static ArrayBuffer CopyMessageToBuffer(BufferPool bufferPool, bool expectMask, Byte[] buffer, int msgOffset, int payloadLength) { }

	[Address(RVA = "0x1557F80", Offset = "0x1557180", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000085")]
	private static int GetCloseCode(Byte[] buffer, int msgOffset) { }

	[Address(RVA = "0x1557FC0", Offset = "0x15571C0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000084")]
	private static string GetCloseMessage(Byte[] buffer, int msgOffset, int payloadLength) { }

	[Address(RVA = "0x1558020", Offset = "0x1557220", Length = "0x1FE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BufferPool), Member = "Take", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ArrayBuffer))]
	[Calls(Type = typeof(ArrayBuffer), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<Mirror.SimpleWeb.Message>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Message)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000081")]
	private static void HandleArrayMessage(Config config, Byte[] buffer, int msgOffset, int payloadLength) { }

	[Address(RVA = "0x1558220", Offset = "0x1557420", Length = "0x1C7")]
	[CalledBy(Type = typeof(ReceiveLoop), Member = "ReadOneMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Config), typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Log), Member = "Verbose", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Connection), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000083")]
	private static void HandleCloseMessage(Config config, Byte[] buffer, int msgOffset, int payloadLength) { }

	[Address(RVA = "0x15583F0", Offset = "0x15575F0", Length = "0x825")]
	[CalledBy(Type = typeof(WebSocketClientStandAlone), Member = "ConnectAndReceiveLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebSocketServer), Member = "HandshakeAndReceiveLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Connection)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Connection), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Log), Member = "Exception", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Log), Member = "Error", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1", "T2", "T3"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<Mirror.SimpleWeb.Message>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Message)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Log), Member = "Warn", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Log), Member = "Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Log), Member = "InfoException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Log), Member = "Verbose", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Utils), Member = "CheckForInterupt", ReturnType = typeof(void))]
	[Calls(Type = typeof(ReceiveLoop), Member = "ReadOneMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Config), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TcpClient), Member = "get_Connected", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001E080")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600007E")]
	public static void Loop(Config config) { }

	[Address(RVA = "0x1558C20", Offset = "0x1557E20", Length = "0x1AE")]
	[CalledBy(Type = typeof(ReceiveLoop), Member = "ReadOneMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Config), typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ReadHelper), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(MessageProcessor), Member = "ValidateHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MessageProcessor), Member = "GetMessageLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(byte)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000080")]
	private static Header ReadHeader(Config config, Byte[] buffer, bool opCodeContinuation = false) { }

	[Address(RVA = "0x1558DD0", Offset = "0x1557FD0", Length = "0x7DB")]
	[CalledBy(Type = typeof(ReceiveLoop), Member = "Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Config)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ReceiveLoop), Member = "HandleCloseMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Config), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<Mirror.SimpleWeb.Message>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Message)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayBuffer), Member = "Release", ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Dequeue", ReturnType = typeof(object))]
	[Calls(Type = typeof(InvalidDataException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BufferPool), Member = "Take", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ArrayBuffer))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ReadHelper), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ReceiveLoop), Member = "ReadHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Config), typeof(Byte[]), typeof(bool)}, ReturnType = typeof(Header))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArrayBuffer), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600007F")]
	private static void ReadOneMessage(Config config, Byte[] buffer) { }

}

