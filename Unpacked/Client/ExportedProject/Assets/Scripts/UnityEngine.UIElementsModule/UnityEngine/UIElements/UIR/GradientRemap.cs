namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005B0")]
internal class GradientRemap : LinkedPoolItem<GradientRemap>
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001484")]
	public int origIndex; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4001485")]
	public int destIndex; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001486")]
	public RectInt location; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001487")]
	public GradientRemap next; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001488")]
	public TextureId atlas; //Field offset: 0x38

	[Address(RVA = "0x1BA47C0", Offset = "0x1BA39C0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002885")]
	public GradientRemap() { }

	[Address(RVA = "0x1BA4750", Offset = "0x1BA3950", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6002884")]
	public void Reset() { }

}

