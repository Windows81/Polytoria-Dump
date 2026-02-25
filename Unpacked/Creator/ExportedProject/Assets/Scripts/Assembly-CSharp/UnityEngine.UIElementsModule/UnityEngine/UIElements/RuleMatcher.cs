namespace UnityEngine.UIElements;

[Token(Token = "0x20004A1")]
internal struct RuleMatcher
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000FB6")]
	public StyleSheet sheet; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000FB7")]
	public StyleComplexSelector complexSelector; //Field offset: 0x8

	[Address(RVA = "0x1B3E0F0", Offset = "0x1B3D2F0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600234C")]
	public virtual string ToString() { }

}

