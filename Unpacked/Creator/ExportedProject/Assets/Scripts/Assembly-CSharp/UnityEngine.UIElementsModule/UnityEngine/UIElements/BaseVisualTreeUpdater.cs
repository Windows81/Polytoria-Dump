namespace UnityEngine.UIElements;

[Token(Token = "0x2000536")]
internal abstract class BaseVisualTreeUpdater : IVisualTreeUpdater, IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001144")]
	private long frameCount; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001145")]
	private Action<BaseVisualElementPanel> panelChanged; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001146")]
	private BaseVisualElementPanel m_Panel; //Field offset: 0x20

	[Token(Token = "0x14000030")]
	public event Action<BaseVisualElementPanel> panelChanged
	{
		[Address(RVA = "0x1B5F150", Offset = "0x1B5E350", Length = "0xAC")]
		[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIRRepaintUpdater), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60025B9")]
		 add { } //Length: 172
		[Address(RVA = "0x1B5F200", Offset = "0x1B5E400", Length = "0xAC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60025BA")]
		 remove { } //Length: 172
	}

	[Token(Token = "0x170009C2")]
	public override BaseVisualElementPanel panel
	{
		[Address(RVA = "0x19865C0", Offset = "0x19857C0", Length = "0x7")]
		[CallerCount(Count = 69)]
		[DeduplicatedMethod]
		[Token(Token = "0x60025BB")]
		 get { } //Length: 7
		[Address(RVA = "0x1B5F2B0", Offset = "0x1B5E4B0", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60025BC")]
		 set { } //Length: 68
	}

	[Token(Token = "0x170009C4")]
	public abstract ProfilerMarker profilerMarker
	{
		[Token(Token = "0x60025BE")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170009C1")]
	private override long UnityEngine.UIElements.IVisualTreeUpdater.FrameCount
	{
		[Address(RVA = "0xC4A010", Offset = "0xC49210", Length = "0x7")]
		[CallerCount(Count = 196)]
		[DeduplicatedMethod]
		[Token(Token = "0x60025B7")]
		private get { } //Length: 7
		[Address(RVA = "0x5A98F0", Offset = "0x5A8AF0", Length = "0x5")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60025B8")]
		private set { } //Length: 5
	}

	[Token(Token = "0x170009C3")]
	public VisualElement visualTree
	{
		[Address(RVA = "0x1631460", Offset = "0x1630660", Length = "0x2A")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60025BD")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60025C3")]
	protected BaseVisualTreeUpdater() { }

	[Address(RVA = "0x1B5F150", Offset = "0x1B5E350", Length = "0xAC")]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60025B9")]
	public void add_panelChanged(Action<BaseVisualElementPanel> value) { }

	[Address(RVA = "0x1B5F0E0", Offset = "0x1B5E2E0", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60025BF")]
	public override void Dispose() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60025C0")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x19865C0", Offset = "0x19857C0", Length = "0x7")]
	[CallerCount(Count = 69)]
	[DeduplicatedMethod]
	[Token(Token = "0x60025BB")]
	public override BaseVisualElementPanel get_panel() { }

	[Token(Token = "0x60025BE")]
	public abstract ProfilerMarker get_profilerMarker() { }

	[Address(RVA = "0x1631460", Offset = "0x1630660", Length = "0x2A")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60025BD")]
	public VisualElement get_visualTree() { }

	[Token(Token = "0x60025C2")]
	public abstract void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	[Address(RVA = "0x1B5F200", Offset = "0x1B5E400", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60025BA")]
	public void remove_panelChanged(Action<BaseVisualElementPanel> value) { }

	[Address(RVA = "0x1B5F2B0", Offset = "0x1B5E4B0", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60025BC")]
	public override void set_panel(BaseVisualElementPanel value) { }

	[Address(RVA = "0xC4A010", Offset = "0xC49210", Length = "0x7")]
	[CallerCount(Count = 196)]
	[DeduplicatedMethod]
	[Token(Token = "0x60025B7")]
	private override long UnityEngine.UIElements.IVisualTreeUpdater.get_FrameCount() { }

	[Address(RVA = "0x5A98F0", Offset = "0x5A8AF0", Length = "0x5")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60025B8")]
	private override void UnityEngine.UIElements.IVisualTreeUpdater.set_FrameCount(long value) { }

	[Token(Token = "0x60025C1")]
	public abstract void Update() { }

}

