namespace UnityEngine.UIElements;

[IsReadOnly]
[Token(Token = "0x200001D")]
public struct BindingActivationContext
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000039")]
	private readonly VisualElement m_TargetElement; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400003A")]
	private readonly BindingId m_BindingId; //Field offset: 0x8

	[Address(RVA = "0x1A934E0", Offset = "0x1A926E0", Length = "0xBA")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000089")]
	internal BindingActivationContext(VisualElement element, in BindingId property) { }

}

