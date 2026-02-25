namespace Unity.Properties;

[IsReadOnly]
[Token(Token = "0x200000F")]
public struct AttributesScope : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400001E")]
	private readonly IAttributes m_Target; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400001F")]
	private readonly List<Attribute> m_Previous; //Field offset: 0x8

	[Address(RVA = "0x19F4D40", Offset = "0x19F3F40", Length = "0xF3")]
	[CalledBy(Type = typeof(IndexedCollectionPropertyBag`2), Member = "Unity.Properties.IListPropertyAccept<TList>.Accept", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IListPropertyVisitor), "Unity.Properties.Property`2<TContainer, TList>", "TContainer&", "TList&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Token(Token = "0x6000020")]
	public AttributesScope(IProperty target, IProperty source) { }

	[Address(RVA = "0x19F4CA0", Offset = "0x19F3EA0", Length = "0x93")]
	[CalledBy(Type = typeof(Property`2), Member = "Unity.Properties.Internal.IAttributes.CreateAttributesScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAttributes)}, ReturnType = typeof(AttributesScope))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000021")]
	internal AttributesScope(IAttributes target, List<Attribute> attributes) { }

	[Address(RVA = "0x19F4C50", Offset = "0x19F3E50", Length = "0x4E")]
	[CalledBy(Type = typeof(IndexedCollectionPropertyBag`2), Member = "Unity.Properties.IListPropertyAccept<TList>.Accept", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IListPropertyVisitor), "Unity.Properties.Property`2<TContainer, TList>", "TContainer&", "TList&"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PathVisitor), Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Token(Token = "0x6000022")]
	public override void Dispose() { }

}

