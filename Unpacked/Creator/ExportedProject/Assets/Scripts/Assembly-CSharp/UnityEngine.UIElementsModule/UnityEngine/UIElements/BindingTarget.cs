namespace UnityEngine.UIElements;

[IsReadOnly]
[Token(Token = "0x2000021")]
internal struct BindingTarget
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000045")]
	public readonly VisualElement element; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000046")]
	public readonly BindingId bindingId; //Field offset: 0x8

	[Address(RVA = "0x1A934E0", Offset = "0x1A926E0", Length = "0xBA")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000092")]
	public BindingTarget(VisualElement element, in BindingId bindingId) { }

}

