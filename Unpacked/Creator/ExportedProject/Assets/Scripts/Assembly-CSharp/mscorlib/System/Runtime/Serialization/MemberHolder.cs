namespace System.Runtime.Serialization;

[Token(Token = "0x20003CE")]
internal sealed class MemberHolder
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F1B")]
	internal readonly Type _memberType; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F1C")]
	internal readonly StreamingContext _context; //Field offset: 0x18

	[Address(RVA = "0x1383AA0", Offset = "0x1382CA0", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CE9")]
	internal MemberHolder(Type type, StreamingContext ctx) { }

	[Address(RVA = "0x1383A20", Offset = "0x1382C20", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001CEB")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x300BF0", Offset = "0x2FFDF0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CEA")]
	public virtual int GetHashCode() { }

}

