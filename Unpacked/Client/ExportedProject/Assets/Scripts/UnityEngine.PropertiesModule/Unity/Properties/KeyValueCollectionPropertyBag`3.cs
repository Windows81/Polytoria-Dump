namespace Unity.Properties;

[Token(Token = "0x2000038")]
public class KeyValueCollectionPropertyBag : PropertyBag<TDictionary>, IDictionaryPropertyBag<TDictionary, TKey, TValue>, ICollectionPropertyBag<TDictionary, KeyValuePair`2<TKey, TValue>>, IPropertyBag<TDictionary>, IPropertyBag, ICollectionPropertyBagAccept<TDictionary>, IDictionaryPropertyBagAccept<TDictionary>, IKeyedProperties<TDictionary, Object>
{
	[IsReadOnly]
	[Token(Token = "0x200003A")]
	private struct Enumerable : IEnumerable<IProperty`1<TDictionary>>, IEnumerable
	{
		[Token(Token = "0x200003B")]
		private class Enumerator : IEnumerator<IProperty`1<TDictionary>>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000054")]
			private readonly TDictionary m_Dictionary; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000055")]
			private readonly KeyValuePairProperty<TDictionary, TKey, TValue> m_Property; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000056")]
			private readonly TKey m_Previous; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000057")]
			private readonly List<TKey> m_Keys; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000058")]
			private int m_Position; //Field offset: 0x0

			[Token(Token = "0x1700002C")]
			public override IProperty<TDictionary> Current
			{
				[Address(RVA = "0xB41000", Offset = "0xB40200", Length = "0x2B")]
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
				[DeduplicatedMethod]
				[Token(Token = "0x60000D4")]
				 get { } //Length: 43
			}

			[Token(Token = "0x1700002D")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x812930", Offset = "0x811B30", Length = "0x18")]
				[CallerCount(Count = 0)]
				[CallsUnknownMethods(Count = 1)]
				[DeduplicatedMethod]
				[Token(Token = "0x60000D5")]
				private get { } //Length: 24
			}

			[Address(RVA = "0xB40C70", Offset = "0xB3FE70", Length = "0x383")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEC40")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_custom_attrs_free")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED940")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEB00")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 3)]
			[DeduplicatedMethod]
			[Token(Token = "0x60000D3")]
			public Enumerator(TDictionary dictionary, KeyValuePairProperty<TDictionary, TKey, TValue> property) { }

			[Address(RVA = "0xB3FF20", Offset = "0xB3F120", Length = "0x85")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60000D8")]
			public override void Dispose() { }

			[Address(RVA = "0xB41000", Offset = "0xB40200", Length = "0x2B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
			[DeduplicatedMethod]
			[Token(Token = "0x60000D4")]
			public override IProperty<TDictionary> get_Current() { }

			[Address(RVA = "0xB3FFB0", Offset = "0xB3F1B0", Length = "0x3C6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_custom_attrs_free")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED940")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEB00")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsUnknownMethods(Count = 3)]
			[DeduplicatedMethod]
			[Token(Token = "0x60000D6")]
			public override bool MoveNext() { }

			[Address(RVA = "0xB40380", Offset = "0xB3F580", Length = "0x164")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_custom_attrs_free")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED940")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60000D7")]
			public override void Reset() { }

			[Address(RVA = "0x812930", Offset = "0x811B30", Length = "0x18")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60000D5")]
			private override object System.Collections.IEnumerator.get_Current() { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000052")]
		private readonly TDictionary m_Dictionary; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000053")]
		private readonly KeyValuePairProperty<TDictionary, TKey, TValue> m_Property; //Field offset: 0x0

		[Address(RVA = "0xAE31A0", Offset = "0xAE23A0", Length = "0x145")]
		[CalledBy(Type = typeof(KeyValueCollectionPropertyBag`3), Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDictionary&"}, ReturnType = "Unity.Properties.PropertyCollection`1<TDictionary>")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEC40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_custom_attrs_free")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED940")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000D0")]
		public Enumerable(TDictionary dictionary, KeyValuePairProperty<TDictionary, TKey, TValue> property) { }

		[Address(RVA = "0xAE2FE0", Offset = "0xAE21E0", Length = "0x1BE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000D2")]
		private override IEnumerator<IProperty`1<TDictionary>> System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TDictionary>>.GetEnumerator() { }

		[Address(RVA = "0xAE2FE0", Offset = "0xAE21E0", Length = "0x1BE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000D1")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[Token(Token = "0x2000039")]
	private class KeyValuePairProperty : Property<TDictionary, KeyValuePair`2<TKey, TValue>>, IDictionaryElementProperty
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000051")]
		private TKey <Key>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000029")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60000C9")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700002A")]
		public internal override TKey Key
		{
			[Address(RVA = "0xCE0AC0", Offset = "0xCDFCC0", Length = "0xA9")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60000CC")]
			 get { } //Length: 169
			[Address(RVA = "0xCE0D90", Offset = "0xCDFF90", Length = "0xB6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEC40")]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60000CD")]
			internal set { } //Length: 182
		}

		[Token(Token = "0x17000028")]
		public virtual string Name
		{
			[Address(RVA = "0xCE0B70", Offset = "0xCDFD70", Length = "0x162")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEB00")]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60000C8")]
			 get { } //Length: 354
		}

		[Token(Token = "0x1700002B")]
		public override object ObjectKey
		{
			[Address(RVA = "0xCE0CE0", Offset = "0xCDFEE0", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60000CE")]
			 get { } //Length: 166
		}

		[Address(RVA = "0xCE0AA0", Offset = "0xCDFCA0", Length = "0x15")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000CF")]
		public KeyValuePairProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C9")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0xCE0AC0", Offset = "0xCDFCC0", Length = "0xA9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000CC")]
		public override TKey get_Key() { }

		[Address(RVA = "0xCE0B70", Offset = "0xCDFD70", Length = "0x162")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEB00")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C8")]
		public virtual string get_Name() { }

		[Address(RVA = "0xCE0CE0", Offset = "0xCDFEE0", Length = "0xA6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000CE")]
		public override object get_ObjectKey() { }

		[Address(RVA = "0xCE0570", Offset = "0xCDF770", Length = "0x354")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEB00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000CA")]
		public virtual KeyValuePair<TKey, TValue> GetValue(ref TDictionary container) { }

		[Address(RVA = "0xCE0D90", Offset = "0xCDFF90", Length = "0xB6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEC40")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000CD")]
		internal void set_Key(TKey value) { }

		[Address(RVA = "0xCE08D0", Offset = "0xCDFAD0", Length = "0x1C1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEB00")]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000CB")]
		public virtual void SetValue(ref TDictionary container, KeyValuePair<TKey, TValue> value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000050")]
	private readonly KeyValuePairProperty<TDictionary, TKey, TValue> m_KeyValuePairProperty; //Field offset: 0x0

	[Address(RVA = "0xCDF770", Offset = "0xCDE970", Length = "0xC9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C7")]
	public KeyValueCollectionPropertyBag`3() { }

	[Address(RVA = "0xC8C690", Offset = "0xC8B890", Length = "0x11E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C2")]
	public virtual PropertyCollection<TDictionary> GetProperties() { }

	[Address(RVA = "0xCDF2A0", Offset = "0xCDE4A0", Length = "0x217")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
	[Calls(Type = typeof(Enumerable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDictionary", "Unity.Properties.KeyValueCollectionPropertyBag`3<TDictionary, TKey, TValue>+KeyValuePairProperty<TDictionary, TKey, TValue>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(Unity.Properties.PropertyCollection`1<Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericType>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Unity.Properties.IProperty`1<Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericType>>)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C3")]
	public virtual PropertyCollection<TDictionary> GetProperties(ref TDictionary container) { }

	[Address(RVA = "0xCDF4C0", Offset = "0xCDE6C0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800B7280")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C4")]
	private override void Unity.Properties.ICollectionPropertyBagAccept<TDictionary>.Accept(ICollectionPropertyBagVisitor visitor, ref TDictionary container) { }

	[Address(RVA = "0xCDF4F0", Offset = "0xCDE6F0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800B7280")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C5")]
	private override void Unity.Properties.IDictionaryPropertyBagAccept<TDictionary>.Accept(IDictionaryPropertyBagVisitor visitor, ref TDictionary container) { }

	[Address(RVA = "0xCDF520", Offset = "0xCDE720", Length = "0x246")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EDA30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEB00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C6")]
	private override bool Unity.Properties.IKeyedProperties<TDictionary,System.Object>.TryGetProperty(ref TDictionary container, object key, out IProperty<TDictionary>& property) { }

}

