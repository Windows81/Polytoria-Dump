namespace UnityEngine.TextCore.Text;

[ExcludeFromObjectFactory]
[ExcludeFromPreset]
[Token(Token = "0x2000038")]
public class TextColorGradient : ScriptableObject
{
	[Token(Token = "0x4000164")]
	private const ColorGradientMode k_DefaultColorMode = 3; //Field offset: 0x0
	[Token(Token = "0x4000165")]
	private static readonly Color k_DefaultColor; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400015F")]
	public ColorGradientMode colorMode; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000160")]
	public Color topLeft; //Field offset: 0x1C
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000161")]
	public Color topRight; //Field offset: 0x2C
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000162")]
	public Color bottomLeft; //Field offset: 0x3C
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000163")]
	public Color bottomRight; //Field offset: 0x4C

	[Address(RVA = "0x1A5C5C0", Offset = "0x1A5B7C0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600015A")]
	private static TextColorGradient() { }

	[Address(RVA = "0x1A5C600", Offset = "0x1A5B800", Length = "0xAF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000157")]
	public TextColorGradient() { }

	[Address(RVA = "0x1889F40", Offset = "0x1889140", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000158")]
	public TextColorGradient(Color color) { }

	[Address(RVA = "0x1889F90", Offset = "0x1889190", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000159")]
	public TextColorGradient(Color color0, Color color1, Color color2, Color color3) { }

}

