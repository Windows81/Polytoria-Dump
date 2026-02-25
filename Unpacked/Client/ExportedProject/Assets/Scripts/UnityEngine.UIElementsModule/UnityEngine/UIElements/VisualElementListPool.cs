namespace UnityEngine.UIElements;

[Token(Token = "0x2000509")]
internal static class VisualElementListPool
{
	[CompilerGenerated]
	[Token(Token = "0x200050A")]
	private sealed class <>c
	{
		[Token(Token = "0x40010BC")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x1B67C40", Offset = "0x1B66E40", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60024E6")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024E7")]
		public <>c() { }

		[Address(RVA = "0x1B67920", Offset = "0x1B66B20", Length = "0x55")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60024E8")]
		internal List<VisualElement> <.cctor>b__4_0() { }

	}

	[Token(Token = "0x40010BB")]
	private static ObjectPool<List`1<VisualElement>> pool; //Field offset: 0x0

	[Address(RVA = "0x1B75760", Offset = "0x1B74960", Length = "0x107")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60024E5")]
	private static VisualElementListPool() { }

	[Address(RVA = "0x1B75530", Offset = "0x1B74730", Length = "0xA9")]
	[CalledBy(Type = typeof(Hierarchy), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60024E2")]
	public static List<VisualElement> Copy(List<VisualElement> elements) { }

	[Address(RVA = "0x1B755E0", Offset = "0x1B747E0", Length = "0xCA")]
	[CalledBy(Type = typeof(MouseEventsHelper), Member = "SendEnterLeave", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TLeaveEvent", "TEnterEvent"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(IMouseEvent), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerEventsHelper), Member = "SendEnterLeave", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TLeaveEvent", "TEnterEvent"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(IPointerEvent), typeof(Vector2), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hierarchy), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "SetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UQueryState`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60024E3")]
	public static List<VisualElement> Get(int initialCapacity = 0) { }

	[Address(RVA = "0x1B756B0", Offset = "0x1B748B0", Length = "0xAA")]
	[CalledBy(Type = typeof(MouseEventsHelper), Member = "SendEnterLeave", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TLeaveEvent", "TEnterEvent"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(IMouseEvent), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerEventsHelper), Member = "SendEnterLeave", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TLeaveEvent", "TEnterEvent"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(IPointerEvent), typeof(Vector2), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hierarchy), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hierarchy), Member = "ReleaseChildList", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "SetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ObjectPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60024E4")]
	public static void Release(List<VisualElement> elements) { }

}

