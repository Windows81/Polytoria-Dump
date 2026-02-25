namespace UnityEngine.UIElements;

[IsReadOnly]
[Token(Token = "0x200001E")]
public struct BindingContext
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400003B")]
	private readonly VisualElement m_TargetElement; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400003C")]
	private readonly BindingId m_BindingId; //Field offset: 0x8
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400003D")]
	private readonly PropertyPath m_DataSourcePath; //Field offset: 0xA0
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x400003E")]
	private readonly object m_DataSource; //Field offset: 0x130

	[Token(Token = "0x1700001E")]
	public BindingId bindingId
	{
		[Address(RVA = "0xCE3A30", Offset = "0xCE2C30", Length = "0x61")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600008B")]
		 get { } //Length: 97
	}

	[Token(Token = "0x17000020")]
	public object dataSource
	{
		[Address(RVA = "0x3F5870", Offset = "0x3F4A70", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600008D")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700001F")]
	public PropertyPath dataSourcePath
	{
		[Address(RVA = "0x1A93700", Offset = "0x1A92900", Length = "0x69")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600008C")]
		 get { } //Length: 105
	}

	[Token(Token = "0x1700001D")]
	public VisualElement targetElement
	{
		[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
		[CallerCount(Count = 140)]
		[DeduplicatedMethod]
		[Token(Token = "0x600008A")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x1A935A0", Offset = "0x1A927A0", Length = "0x157")]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "ProcessPropertyChangedEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.Binding>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600008E")]
	internal BindingContext(VisualElement targetElement, in BindingId bindingId, in PropertyPath resolvedDataSourcePath, object resolvedDataSource) { }

	[Address(RVA = "0xCE3A30", Offset = "0xCE2C30", Length = "0x61")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600008B")]
	public BindingId get_bindingId() { }

	[Address(RVA = "0x3F5870", Offset = "0x3F4A70", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600008D")]
	public object get_dataSource() { }

	[Address(RVA = "0x1A93700", Offset = "0x1A92900", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600008C")]
	public PropertyPath get_dataSourcePath() { }

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[DeduplicatedMethod]
	[Token(Token = "0x600008A")]
	public VisualElement get_targetElement() { }

}

