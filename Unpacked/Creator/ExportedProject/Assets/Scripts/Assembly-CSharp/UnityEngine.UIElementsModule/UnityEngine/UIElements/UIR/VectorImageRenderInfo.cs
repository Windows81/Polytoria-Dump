namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005AD")]
internal class VectorImageRenderInfo : LinkedPoolItem<VectorImageRenderInfo>
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400147E")]
	public int useCount; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400147F")]
	public GradientRemap firstGradientRemap; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001480")]
	public Alloc gradientSettingsAlloc; //Field offset: 0x28

	[Address(RVA = "0x1BBC7A0", Offset = "0x1BBB9A0", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600287E")]
	public VectorImageRenderInfo() { }

	[Address(RVA = "0x1BBC770", Offset = "0x1BBB970", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600287D")]
	public void Reset() { }

}

