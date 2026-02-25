namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x2000390")]
internal class IllogicalCallContext
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E81")]
	private Hashtable m_Datastore; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E82")]
	private object m_HostContext; //Field offset: 0x18

	[Token(Token = "0x17000322")]
	private Hashtable Datastore
	{
		[Address(RVA = "0x13818A0", Offset = "0x1380AA0", Length = "0x69")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001B94")]
		private get { } //Length: 105
	}

	[Token(Token = "0x17000324")]
	internal bool HasUserData
	{
		[Address(RVA = "0x1381910", Offset = "0x1380B10", Length = "0x33")]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B97")]
		internal get { } //Length: 51
	}

	[Token(Token = "0x17000323")]
	internal object HostContext
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B95")]
		internal get { } //Length: 5
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B96")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B99")]
	public IllogicalCallContext() { }

	[Address(RVA = "0x1381570", Offset = "0x1380770", Length = "0x325")]
	[CalledBy(Type = typeof(ExecutionContext), Member = "CreateMutableCopy", ReturnType = typeof(ExecutionContext))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6001B98")]
	public IllogicalCallContext CreateCopy() { }

	[Address(RVA = "0x13818A0", Offset = "0x1380AA0", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001B94")]
	private Hashtable get_Datastore() { }

	[Address(RVA = "0x1381910", Offset = "0x1380B10", Length = "0x33")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B97")]
	internal bool get_HasUserData() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B95")]
	internal object get_HostContext() { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B96")]
	internal void set_HostContext(object value) { }

}

