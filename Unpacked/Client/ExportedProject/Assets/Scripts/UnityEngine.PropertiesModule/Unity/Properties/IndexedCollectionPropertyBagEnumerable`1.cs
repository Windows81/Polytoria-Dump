namespace Unity.Properties;

[IsReadOnly]
[Token(Token = "0x2000029")]
internal struct IndexedCollectionPropertyBagEnumerable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000045")]
	private readonly IIndexedCollectionPropertyBagEnumerator<TContainer> m_Impl; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000046")]
	private readonly TContainer m_Container; //Field offset: 0x0

	[Address(RVA = "0xC89880", Offset = "0xC88A80", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600009B")]
	public IndexedCollectionPropertyBagEnumerable`1(IIndexedCollectionPropertyBagEnumerator<TContainer> impl, TContainer container) { }

	[Address(RVA = "0xC88790", Offset = "0xC87990", Length = "0xC7")]
	[CalledBy(Type = typeof(PropertyCollection`1), Member = "GetEnumerator", ReturnType = "Unity.Properties.PropertyCollection`1<TContainer>+Enumerator<TContainer>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600009C")]
	public IndexedCollectionPropertyBagEnumerator<TContainer> GetEnumerator() { }

}

