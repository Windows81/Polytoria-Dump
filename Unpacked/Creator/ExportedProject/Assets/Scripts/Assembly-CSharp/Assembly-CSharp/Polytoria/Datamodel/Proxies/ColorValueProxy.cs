namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x200039D")]
public class ColorValueProxy : ValueBaseProxy
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000FE7")]
	private readonly ColorValue colorValue; //Field offset: 0x20

	[Token(Token = "0x17000B70")]
	public Color Value
	{
		[Address(RVA = "0x4A18A0", Offset = "0x4A0AA0", Length = "0x24")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60026DD")]
		 get { } //Length: 36
		[Address(RVA = "0x4A18D0", Offset = "0x4A0AD0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ColorValue), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026DE")]
		 set { } //Length: 44
	}

	[Address(RVA = "0x4A11B0", Offset = "0x4A03B0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x60026DC")]
	public ColorValueProxy(ColorValue target) { }

	[Address(RVA = "0x4A18A0", Offset = "0x4A0AA0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60026DD")]
	public Color get_Value() { }

	[Address(RVA = "0x4A18D0", Offset = "0x4A0AD0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ColorValue), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026DE")]
	public void set_Value(Color value) { }

}

