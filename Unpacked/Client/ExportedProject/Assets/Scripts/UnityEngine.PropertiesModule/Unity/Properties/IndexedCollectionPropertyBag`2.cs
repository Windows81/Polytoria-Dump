namespace Unity.Properties;

[Token(Token = "0x200002D")]
public class IndexedCollectionPropertyBag : PropertyBag<TList>, IListPropertyBag<TList, TElement>, ICollectionPropertyBag<TList, TElement>, IPropertyBag<TList>, IPropertyBag, ICollectionPropertyBagAccept<TList>, IListPropertyBagAccept<TList>, IListPropertyAccept<TList>, IIndexedProperties<TList>, IConstructorWithCount<TList>, IConstructor, IIndexedCollectionPropertyBagEnumerator<TList>
{
	[Token(Token = "0x200002E")]
	private class ListElementProperty : Property<TList, TElement>, IListElementProperty
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004E")]
		internal int m_Index; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004F")]
		internal bool m_IsReadOnly; //Field offset: 0x0

		[Token(Token = "0x17000025")]
		public override int Index
		{
			[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x60000B4")]
			 get { } //Length: 4
		}

		[Token(Token = "0x17000027")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x339420", Offset = "0x338620", Length = "0x5")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x60000B6")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000026")]
		public virtual string Name
		{
			[Address(RVA = "0xCF48D0", Offset = "0xCF3AD0", Length = "0x21")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
			[DeduplicatedMethod]
			[Token(Token = "0x60000B5")]
			 get { } //Length: 33
		}

		[Address(RVA = "0xCF48B0", Offset = "0xCF3AB0", Length = "0x14")]
		[CalledBy(Type = typeof(IndexedCollectionPropertyBag`2), Member = "TryGetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TList&", typeof(int), "Unity.Properties.IProperty`1<TList>&"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(IndexedCollectionPropertyBag`2), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B9")]
		public ListElementProperty() { }

		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B4")]
		public override int get_Index() { }

		[Address(RVA = "0x339420", Offset = "0x338620", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B6")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0xCF48D0", Offset = "0xCF3AD0", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B5")]
		public virtual string get_Name() { }

		[Address(RVA = "0xCF41F0", Offset = "0xCF33F0", Length = "0xB8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B7")]
		public virtual TElement GetValue(ref TList container) { }

		[Address(RVA = "0xCF44B0", Offset = "0xCF36B0", Length = "0xC7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B8")]
		public virtual void SetValue(ref TList container, TElement value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400004D")]
	private readonly ListElementProperty<TList, TElement> m_Property; //Field offset: 0x0

	[Address(RVA = "0xC8D140", Offset = "0xC8C340", Length = "0xC4")]
	[CalledBy(Type = typeof(ListPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ListElementProperty), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B3")]
	public IndexedCollectionPropertyBag`2() { }

	[Address(RVA = "0xC8C600", Offset = "0xC8B800", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800B7340")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A7")]
	public virtual PropertyCollection<TList> GetProperties() { }

	[Address(RVA = "0xC8C7B0", Offset = "0xC8B9B0", Length = "0xBC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PropertyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IndexedCollectionPropertyBagEnumerable`1<TContainer>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A8")]
	public virtual PropertyCollection<TList> GetProperties(ref TList container) { }

	[Address(RVA = "0xC8CAA0", Offset = "0xC8BCA0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000AE")]
	protected override TList InstantiateWithCount(int count) { }

	[Address(RVA = "0xC8CD20", Offset = "0xC8BF20", Length = "0xE4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ListElementProperty), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A9")]
	public override bool TryGetProperty(ref TList container, int index, out IProperty<TList>& property) { }

	[Address(RVA = "0xC8CE10", Offset = "0xC8C010", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800B7280")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000AA")]
	private override void Unity.Properties.ICollectionPropertyBagAccept<TList>.Accept(ICollectionPropertyBagVisitor visitor, ref TList container) { }

	[Address(RVA = "0xC8CF40", Offset = "0xC8C140", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000AD")]
	private override TList Unity.Properties.IConstructorWithCount<TList>.InstantiateWithCount(int count) { }

	[Address(RVA = "0xC8D030", Offset = "0xC8C230", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000AF")]
	private override int Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.GetCount(ref TList container) { }

	[Address(RVA = "0xB081E0", Offset = "0xB073E0", Length = "0x7")]
	[CallerCount(Count = 73)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B0")]
	private override IProperty<TList> Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.GetSharedProperty() { }

	[Address(RVA = "0xC8D080", Offset = "0xC8C280", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B1")]
	private override IndexedCollectionSharedPropertyState Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.GetSharedPropertyState() { }

	[Address(RVA = "0xC8D0D0", Offset = "0xC8C2D0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B2")]
	private override void Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.SetSharedPropertyState(IndexedCollectionSharedPropertyState state) { }

	[Address(RVA = "0x604E40", Offset = "0x604040", Length = "0x154")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(AttributesScope), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IProperty), typeof(IProperty)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE450")]
	[Calls(Type = typeof(AttributesScope), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000AC")]
	private override void Unity.Properties.IListPropertyAccept<TList>.Accept(IListPropertyVisitor visitor, Property<TContainer, TList> property, ref TContainer container, ref TList list) { }

	[Address(RVA = "0xC8D100", Offset = "0xC8C300", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800B7280")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000AB")]
	private override void Unity.Properties.IListPropertyBagAccept<TList>.Accept(IListPropertyBagVisitor visitor, ref TList list) { }

}

