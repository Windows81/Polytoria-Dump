namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x2000393")]
internal class CallContextSecurityData : ICloneable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E8A")]
	private IPrincipal _principal; //Field offset: 0x10

	[Token(Token = "0x1700032A")]
	internal bool HasInfo
	{
		[Address(RVA = "0x5A28B0", Offset = "0x5A1AB0", Length = "0x9")]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BA7")]
		internal get { } //Length: 9
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BA9")]
	public CallContextSecurityData() { }

	[Address(RVA = "0x137BE80", Offset = "0x137B080", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001BA8")]
	public override object Clone() { }

	[Address(RVA = "0x5A28B0", Offset = "0x5A1AB0", Length = "0x9")]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BA7")]
	internal bool get_HasInfo() { }

}

