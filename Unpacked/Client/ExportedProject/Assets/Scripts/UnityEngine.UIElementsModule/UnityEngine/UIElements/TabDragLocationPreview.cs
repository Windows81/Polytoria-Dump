namespace UnityEngine.UIElements;

[Token(Token = "0x200014F")]
internal class TabDragLocationPreview : VisualElement
{
	[Token(Token = "0x40006A6")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x40006A7")]
	public static readonly string visualUssClassName; //Field offset: 0x8
	[Token(Token = "0x40006A8")]
	public static readonly string verticalUssClassName; //Field offset: 0x10
	[Token(Token = "0x40006A9")]
	public static readonly string horizontalUssClassName; //Field offset: 0x18
	[FieldOffset(Offset = "0x2D0")]
	[Token(Token = "0x40006AA")]
	private VisualElement m_Preview; //Field offset: 0x2D0

	[Token(Token = "0x170001BD")]
	internal VisualElement preview
	{
		[Address(RVA = "0xFA13A0", Offset = "0xFA05A0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A33")]
		internal get { } //Length: 8
	}

	[Address(RVA = "0x1C29360", Offset = "0x1C28560", Length = "0x1A4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000A35")]
	private static TabDragLocationPreview() { }

	[Address(RVA = "0x1C29510", Offset = "0x1C28710", Length = "0x127")]
	[CalledBy(Type = typeof(TabDragger), Member = "BeginDragMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_pickingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000A34")]
	public TabDragLocationPreview() { }

	[Address(RVA = "0xFA13A0", Offset = "0xFA05A0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A33")]
	internal VisualElement get_preview() { }

}

