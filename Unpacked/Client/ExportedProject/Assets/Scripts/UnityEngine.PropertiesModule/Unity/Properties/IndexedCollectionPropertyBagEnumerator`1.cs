namespace Unity.Properties;

[Token(Token = "0x200002A")]
internal struct IndexedCollectionPropertyBagEnumerator : IEnumerator<IProperty`1<TContainer>>, IEnumerator, IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000047")]
	private readonly IIndexedCollectionPropertyBagEnumerator<TContainer> m_Impl; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000048")]
	private readonly IndexedCollectionSharedPropertyState m_Previous; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000049")]
	private TContainer m_Container; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400004A")]
	private int m_Position; //Field offset: 0x0

	[Token(Token = "0x17000023")]
	public override IProperty<TContainer> Current
	{
		[Address(RVA = "0xC8C500", Offset = "0xC8B700", Length = "0x58")]
		[CalledBy(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600009E")]
		 get { } //Length: 88
	}

	[Token(Token = "0x17000024")]
	private override object System.Collections.IEnumerator.Current
	{
		[Address(RVA = "0xC8B6D0", Offset = "0xC8A8D0", Length = "0x7B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600009F")]
		private get { } //Length: 123
	}

	[Address(RVA = "0xC8B8C0", Offset = "0xC8AAC0", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600009D")]
	internal IndexedCollectionPropertyBagEnumerator`1(IIndexedCollectionPropertyBagEnumerator<TContainer> impl, TContainer container) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A2")]
	public override void Dispose() { }

	[Address(RVA = "0xC8C500", Offset = "0xC8B700", Length = "0x58")]
	[CalledBy(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600009E")]
	public override IProperty<TContainer> get_Current() { }

	[Address(RVA = "0xC89D00", Offset = "0xC88F00", Length = "0x1BF")]
	[CalledBy(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A0")]
	public override bool MoveNext() { }

	[Address(RVA = "0xC8B360", Offset = "0xC8A560", Length = "0x6F")]
	[CalledBy(Type = typeof(Enumerator), Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A1")]
	public override void Reset() { }

	[Address(RVA = "0xC8B6D0", Offset = "0xC8A8D0", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600009F")]
	private override object System.Collections.IEnumerator.get_Current() { }

}

