namespace UnityEngine;

[AttributeUsage(AttributeTargets::Class (4), AllowMultiple = True)]
[RequiredByNativeCode]
[Token(Token = "0x2000123")]
public sealed class RequireComponent : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000512")]
	public Type m_Type0; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000513")]
	public Type m_Type1; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000514")]
	public Type m_Type2; //Field offset: 0x20

	[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008D5")]
	public RequireComponent(Type requiredComponent) { }

	[Address(RVA = "0x2FEC80", Offset = "0x2FDE80", Length = "0x4E")]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008D6")]
	public RequireComponent(Type requiredComponent, Type requiredComponent2) { }

}

