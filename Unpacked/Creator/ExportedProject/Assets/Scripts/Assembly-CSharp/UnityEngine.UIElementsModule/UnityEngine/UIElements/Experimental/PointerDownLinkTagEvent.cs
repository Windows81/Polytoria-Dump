namespace UnityEngine.UIElements.Experimental;

[Token(Token = "0x2000625")]
public sealed class PointerDownLinkTagEvent : PointerEventBase<PointerDownLinkTagEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x2000626")]
	private sealed class <>c
	{
		[Token(Token = "0x40016EB")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x1BCDB20", Offset = "0x1BCCD20", Length = "0x1AC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = "UnityEngine.UIElements.BaseVerticalCollectionView+<get_selectedItems>d__88", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_reorderable", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002B20")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B21")]
		public <>c() { }

		[Address(RVA = "0x1BCD8F0", Offset = "0x1BCCAF0", Length = "0x6C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(PointerEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6002B22")]
		internal PointerDownLinkTagEvent <.cctor>b__0_0() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40016E9")]
	private string <linkID>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40016EA")]
	private string <linkText>k__BackingField; //Field offset: 0x108

	[Token(Token = "0x17000AF5")]
	private string linkID
	{
		[Address(RVA = "0x507950", Offset = "0x506B50", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B1A")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000AF6")]
	private string linkText
	{
		[Address(RVA = "0x466DE0", Offset = "0x465FE0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B1B")]
		private set { } //Length: 19
	}

	[Address(RVA = "0x1BBF7F0", Offset = "0x1BBE9F0", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EventBase`1), Member = "SetCreateFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002B19")]
	private static PointerDownLinkTagEvent() { }

	[Address(RVA = "0x1BBF8D0", Offset = "0x1BBEAD0", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6002B1F")]
	public PointerDownLinkTagEvent() { }

	[Address(RVA = "0x1BBF700", Offset = "0x1BBE900", Length = "0x8F")]
	[CalledBy(Type = typeof(ATGTextEventHandler), Member = "LinkTagOnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerDownEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEventHandler), Member = "LinkTagOnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerDownEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002B1E")]
	public static PointerDownLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText) { }

	[Address(RVA = "0x1BBF790", Offset = "0x1BBE990", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerEventBase`1), Member = "Init", ReturnType = typeof(void))]
	[Token(Token = "0x6002B1C")]
	protected virtual void Init() { }

	[Address(RVA = "0x1BBF7E0", Offset = "0x1BBE9E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B1D")]
	private void LocalInit() { }

	[Address(RVA = "0x507950", Offset = "0x506B50", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B1A")]
	private void set_linkID(string value) { }

	[Address(RVA = "0x466DE0", Offset = "0x465FE0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B1B")]
	private void set_linkText(string value) { }

}

