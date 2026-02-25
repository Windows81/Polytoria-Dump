namespace System.Net.Configuration;

[Token(Token = "0x20002D4")]
internal sealed class DefaultProxySectionInternal
{
	[Token(Token = "0x4000C70")]
	private static object classSyncObject; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C6F")]
	private IWebProxy webProxy; //Field offset: 0x10

	[Token(Token = "0x170003D6")]
	internal static object ClassSyncObject
	{
		[Address(RVA = "0x16FE110", Offset = "0x16FD310", Length = "0x95")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object), typeof(object)}, ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001210")]
		internal get { } //Length: 149
	}

	[Token(Token = "0x170003D7")]
	internal IWebProxy WebProxy
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001212")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001213")]
	public DefaultProxySectionInternal() { }

	[Address(RVA = "0x16FE110", Offset = "0x16FD310", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object), typeof(object)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001210")]
	internal static object get_ClassSyncObject() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001212")]
	internal IWebProxy get_WebProxy() { }

	[Address(RVA = "0x16FDF90", Offset = "0x16FD190", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WebProxy), Member = "CreateDefaultProxy", ReturnType = typeof(IWebProxy))]
	[DeduplicatedMethod]
	[Token(Token = "0x600120E")]
	private static IWebProxy GetDefaultProxy_UsingOldMonoCode() { }

	[Address(RVA = "0x16FDFA0", Offset = "0x16FD1A0", Length = "0x16B")]
	[CalledBy(Type = typeof(WebRequest), Member = "get_InternalDefaultWebProxy", ReturnType = typeof(IWebProxy))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object), typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WebProxy), Member = "CreateDefaultProxy", ReturnType = typeof(IWebProxy))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001211")]
	internal static DefaultProxySectionInternal GetSection() { }

	[Address(RVA = "0x16FDF90", Offset = "0x16FD190", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WebProxy), Member = "CreateDefaultProxy", ReturnType = typeof(IWebProxy))]
	[DeduplicatedMethod]
	[Token(Token = "0x600120F")]
	private static IWebProxy GetSystemWebProxy() { }

}

