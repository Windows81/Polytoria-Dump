namespace UnityEngine.UIElements;

[Token(Token = "0x20000E8")]
internal class TextEditorEventHandler
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400046B")]
	protected TextElement textElement; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400046C")]
	protected TextEditingUtilities editingUtilities; //Field offset: 0x18

	[Address(RVA = "0x331270", Offset = "0x330470", Length = "0x4E")]
	[CallerCount(Count = 37)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000717")]
	protected TextEditorEventHandler(TextElement textElement, TextEditingUtilities editingUtilities) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600071A")]
	public override void HandleEventBubbleUp(EventBase evt) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000718")]
	public override void RegisterCallbacksOnTarget(VisualElement target) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000719")]
	public override void UnregisterCallbacksFromTarget(VisualElement target) { }

}

