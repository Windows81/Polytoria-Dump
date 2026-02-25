namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x20005BB")]
internal sealed class LayoutMeasureFunction : MulticastDelegate
{

	[Address(RVA = "0x1BABFB0", Offset = "0x1BAB1B0", Length = "0x125")]
	[CalledBy(Type = typeof(BaseVisualElementPanel), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Panel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(ContextType), typeof(EventDispatcher)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60028C8")]
	public LayoutMeasureFunction(object object, IntPtr method) { }

	[Address(RVA = "0x1BABF90", Offset = "0x1BAB190", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60028C9")]
	public override void Invoke(VisualElement ve, ref LayoutNode node, float width, LayoutMeasureMode widthMode, float height, LayoutMeasureMode heightMode, out LayoutSize result) { }

}

