namespace Mirror.SimpleWeb;

[Token(Token = "0x2000019")]
public static class ReadHelper
{
	[CompilerGenerated]
	[Token(Token = "0x200001A")]
	private sealed class <>c
	{
		[Token(Token = "0x4000059")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400005A")]
		public static Func<Exception, Boolean> <>9__0_0; //Field offset: 0x8

		[Address(RVA = "0x155DFD0", Offset = "0x155D1D0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000079")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600007A")]
		public <>c() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600007B")]
		internal bool <Read>b__0_0(Exception e) { }

	}


	[Address(RVA = "0x15579C0", Offset = "0x1556BC0", Length = "0x251")]
	[CalledBy(Type = typeof(ReadHelper), Member = "TryRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReceiveLoop), Member = "ReadOneMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Config), typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReceiveLoop), Member = "ReadHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Config), typeof(Byte[]), typeof(bool)}, ReturnType = "Mirror.SimpleWeb.ReceiveLoop+Header")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AggregateException), Member = "Handle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<System.Exception, System.Boolean>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ReadHelperException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000076")]
	public static int Read(Stream stream, Byte[] outBuffer, int outOffset, int length) { }

	[Address(RVA = "0x1557C20", Offset = "0x1556E20", Length = "0x1F9")]
	[CalledBy(Type = typeof(ClientHandshake), Member = "TryHandshake", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Connection), typeof(Uri)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ServerHandshake), Member = "ReadToEndForHandshake", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Log), Member = "Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Log), Member = "InfoException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Log), Member = "Exception", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000078")]
	public static Nullable<Int32> SafeReadTillMatch(Stream stream, Byte[] outBuffer, int outOffset, int maxLength, Byte[] endOfHeader) { }

	[Address(RVA = "0x1557E20", Offset = "0x1557020", Length = "0x4D")]
	[CalledBy(Type = typeof(ServerHandshake), Member = "TryHandshake", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Connection)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReadHelper), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Log), Member = "Exception", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000077")]
	public static bool TryRead(Stream stream, Byte[] outBuffer, int outOffset, int length) { }

}

