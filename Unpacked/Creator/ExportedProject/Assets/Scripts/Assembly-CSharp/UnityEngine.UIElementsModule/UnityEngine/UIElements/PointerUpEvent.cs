namespace UnityEngine.UIElements;

[Token(Token = "0x2000222")]
public sealed class PointerUpEvent : PointerEventBase<PointerUpEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x2000223")]
	private sealed class <>c
	{
		[Token(Token = "0x40008B4")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x1C61860", Offset = "0x1C60A60", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000F12")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F13")]
		public <>c() { }

		[Address(RVA = "0x1C60E80", Offset = "0x1C60080", Length = "0x8F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(PointerEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000F14")]
		internal PointerUpEvent <.cctor>b__0_0() { }

	}


	[Address(RVA = "0x1C5CF90", Offset = "0x1C5C190", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EventBase`1), Member = "SetCreateFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000F0A")]
	private static PointerUpEvent() { }

	[Address(RVA = "0x1C5D070", Offset = "0x1C5C270", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000F0D")]
	public PointerUpEvent() { }

	[Address(RVA = "0x1C5CBC0", Offset = "0x1C5BDC0", Length = "0xAD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181C484B0")]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "DispatchToElementUnderPointerOrPanelRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(int), typeof(Vector2)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000F11")]
	internal virtual void Dispatch(BaseVisualElementPanel panel) { }

	[Address(RVA = "0x1C5CC70", Offset = "0x1C5BE70", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MouseEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = "T")]
	[Token(Token = "0x6000F0E")]
	internal virtual IMouseEvent GetPooledCompatibilityMouseEvent() { }

	[Address(RVA = "0x1C5CD10", Offset = "0x1C5BF10", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerEventBase`1), Member = "Init", ReturnType = typeof(void))]
	[Token(Token = "0x6000F0B")]
	protected virtual void Init() { }

	[Address(RVA = "0x1C5CD80", Offset = "0x1C5BF80", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000F0C")]
	private void LocalInit() { }

	[Address(RVA = "0x1C5CDD0", Offset = "0x1C5BFD0", Length = "0x16C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(ClickDetector), Member = "ProcessEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEvent"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerEventBase`1<TEvent>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PointerType), Member = "IsDirectManipulationDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "ReleasePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "ClearCachedElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerEventBase`1), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "ActivateCompatibilityMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F10")]
	protected private virtual void PostDispatch(IPanel panel) { }

	[Address(RVA = "0x1C5CF40", Offset = "0x1C5C140", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerEventBase`1), Member = "PreDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000F0F")]
	protected private virtual void PreDispatch(IPanel panel) { }

}

