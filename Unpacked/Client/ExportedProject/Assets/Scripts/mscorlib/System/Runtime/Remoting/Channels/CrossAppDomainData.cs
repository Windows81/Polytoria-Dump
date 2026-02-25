namespace System.Runtime.Remoting.Channels;

[Token(Token = "0x2000373")]
internal class CrossAppDomainData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E5C")]
	private object _ContextID; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E5D")]
	private int _DomainID; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000E5E")]
	private string _processGuid; //Field offset: 0x20

	[Token(Token = "0x170002FD")]
	internal int DomainID
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B39")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x170002FE")]
	internal string ProcessID
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B3A")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x1365800", Offset = "0x1364A00", Length = "0x98")]
	[CalledBy(Type = typeof(ObjRef), Member = "DeserializeInTheCurrentDomain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte[])}, ReturnType = typeof(ObjRef))]
	[CalledBy(Type = typeof(CrossAppDomainChannel), Member = "get_ChannelData", ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RemotingConfiguration), Member = "get_ProcessId", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001B38")]
	internal CrossAppDomainData(int domainId) { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B39")]
	internal int get_DomainID() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B3A")]
	internal string get_ProcessID() { }

}

