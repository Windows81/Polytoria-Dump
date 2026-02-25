namespace UnityEngine.UIElements;

[IsReadOnly]
[Token(Token = "0x2000044")]
public struct BindablePropertyChangedEventArgs
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000146")]
	private readonly BindingId m_PropertyName; //Field offset: 0x0

	[Token(Token = "0x17000041")]
	public BindingId propertyName
	{
		[Address(RVA = "0xCE36D0", Offset = "0xCE28D0", Length = "0x60")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000203")]
		 get { } //Length: 96
	}

	[Address(RVA = "0x1AC4150", Offset = "0x1AC3350", Length = "0x9F")]
	[CalledBy(Type = typeof(Column), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Columns), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SortColumnDescription), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000202")]
	public BindablePropertyChangedEventArgs(in BindingId propertyName) { }

	[Address(RVA = "0xCE36D0", Offset = "0xCE28D0", Length = "0x60")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000203")]
	public BindingId get_propertyName() { }

}

