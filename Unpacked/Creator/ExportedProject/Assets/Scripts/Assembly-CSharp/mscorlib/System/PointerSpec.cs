namespace System;

[Token(Token = "0x20001D3")]
internal class PointerSpec : ModifierSpec
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000923")]
	private int pointer_level; //Field offset: 0x10

	[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
	[CallerCount(Count = 68)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001039")]
	internal PointerSpec(int pointer_level) { }

	[Address(RVA = "0x1516120", Offset = "0x1515320", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600103B")]
	public override StringBuilder Append(StringBuilder sb) { }

	[Address(RVA = "0x1516150", Offset = "0x1515350", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600103A")]
	public override Type Resolve(Type type) { }

	[Address(RVA = "0x15161A0", Offset = "0x15153A0", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600103C")]
	public virtual string ToString() { }

}

