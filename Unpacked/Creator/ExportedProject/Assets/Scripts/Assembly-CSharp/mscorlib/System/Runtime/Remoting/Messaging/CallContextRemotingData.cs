namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x2000394")]
internal class CallContextRemotingData : ICloneable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E8B")]
	private string _logicalCallID; //Field offset: 0x10

	[Token(Token = "0x1700032C")]
	internal bool HasInfo
	{
		[Address(RVA = "0x5A28B0", Offset = "0x5A1AB0", Length = "0x9")]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BAC")]
		internal get { } //Length: 9
	}

	[Token(Token = "0x1700032B")]
	internal string LogicalCallID
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BAA")]
		internal get { } //Length: 5
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BAB")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BAE")]
	public CallContextRemotingData() { }

	[Address(RVA = "0x137BE10", Offset = "0x137B010", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001BAD")]
	public override object Clone() { }

	[Address(RVA = "0x5A28B0", Offset = "0x5A1AB0", Length = "0x9")]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BAC")]
	internal bool get_HasInfo() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BAA")]
	internal string get_LogicalCallID() { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BAB")]
	internal void set_LogicalCallID(string value) { }

}

