namespace Mirror.SimpleWeb;

[Token(Token = "0x2000022")]
internal static class SendLoop
{
	[Token(Token = "0x2000023")]
	internal struct Config
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006E")]
		public readonly Connection conn; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400006F")]
		public readonly int bufferSize; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000070")]
		public readonly bool setMask; //Field offset: 0xC

		[Address(RVA = "0x1555680", Offset = "0x1554880", Length = "0x85")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000092")]
		public Config(Connection conn, int bufferSize, bool setMask) { }

		[Address(RVA = "0x1555470", Offset = "0x1554670", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000093")]
		public void Deconstruct(out Connection conn, out int bufferSize, out bool setMask) { }

	}


	[Address(RVA = "0x1559A60", Offset = "0x1558C60", Length = "0x8D4")]
	[CalledBy(Type = typeof(WebSocketClientStandAlone), Member = "<ConnectAndReceiveLoop>b__6_0", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketServer+<>c__DisplayClass15_0", Member = "<HandshakeAndReceiveLoop>b__0", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SendLoop), Member = "WriteHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180003A10")]
	[Calls(Type = typeof(ArrayBuffer), Member = "Release", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Log), Member = "Verbose", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181553B50")]
	[Calls(Type = typeof(RandomNumberGenerator), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayBuffer), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Log), Member = "InfoException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Log), Member = "Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Connection), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(MaskHelper), Member = "WriteMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ManualResetEventSlim), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<System.Object>), Member = "TryDequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Log), Member = "Exception", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(ManualResetEventSlim), Member = "Wait", ReturnType = typeof(void))]
	[Calls(Type = typeof(TcpClient), Member = "get_Connected", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RNGCryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600008F")]
	public static void Loop(Config config) { }

	[Address(RVA = "0x155A340", Offset = "0x1559540", Length = "0x1BE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SendLoop), Member = "WriteHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000090")]
	private static int SendMessage(Byte[] buffer, int startOffset, ArrayBuffer msg, bool setMask, MaskHelper maskHelper) { }

	[Address(RVA = "0x155A500", Offset = "0x1559700", Length = "0x186")]
	[CalledBy(Type = typeof(SendLoop), Member = "Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Config)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SendLoop), Member = "SendMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(ArrayBuffer), typeof(bool), typeof(MaskHelper)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000091")]
	public static int WriteHeader(Byte[] buffer, int startOffset, int msgLength, bool setMask) { }

}

