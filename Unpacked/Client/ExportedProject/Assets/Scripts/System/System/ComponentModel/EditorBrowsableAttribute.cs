namespace System.ComponentModel;

[AttributeUsage(6140)]
[Token(Token = "0x2000142")]
public sealed class EditorBrowsableAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005C8")]
	private EditorBrowsableState browsableState; //Field offset: 0x10

	[Address(RVA = "0x5E9C60", Offset = "0x5E8E60", Length = "0x24")]
	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007FB")]
	public EditorBrowsableAttribute(EditorBrowsableState state) { }

	[Address(RVA = "0x177F140", Offset = "0x177E340", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007FC")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x177CCF0", Offset = "0x177BEF0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x60007FD")]
	public virtual int GetHashCode() { }

}

