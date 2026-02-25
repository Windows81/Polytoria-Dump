namespace UnityEngine.UIElements;

[Token(Token = "0x2000279")]
internal class UIDocumentRootElement : TemplateContainer
{
	[FieldOffset(Offset = "0x2F8")]
	[Token(Token = "0x40009C0")]
	public readonly UIDocument document; //Field offset: 0x2F8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x300")]
	[Token(Token = "0x40009C1")]
	private UIRenderer <uiRenderer>k__BackingField; //Field offset: 0x300

	[Token(Token = "0x17000347")]
	internal UIRenderer uiRenderer
	{
		[Address(RVA = "0x1BF7F10", Offset = "0x1BF7110", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001143")]
		internal get { } //Length: 8
		[Address(RVA = "0x1BF8000", Offset = "0x1BF7200", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001144")]
		internal set { } //Length: 19
	}

	[Address(RVA = "0x1C768C0", Offset = "0x1C75AC0", Length = "0x9F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TemplateContainer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(VisualTreeAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001145")]
	public UIDocumentRootElement(UIDocument document, VisualTreeAsset sourceAsset) { }

	[Address(RVA = "0x1BF7F10", Offset = "0x1BF7110", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001143")]
	internal UIRenderer get_uiRenderer() { }

	[Address(RVA = "0x1BF8000", Offset = "0x1BF7200", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001144")]
	internal void set_uiRenderer(UIRenderer value) { }

}

