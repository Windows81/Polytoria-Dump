namespace Unity.Properties;

[Token(Token = "0x2000045")]
public class SetPropertyBagBase : PropertyBag<TSet>, ISetPropertyBag<TSet, TElement>, ICollectionPropertyBag<TSet, TElement>, IPropertyBag<TSet>, IPropertyBag, ICollectionPropertyBagAccept<TSet>, ISetPropertyBagAccept<TSet>, IKeyedProperties<TSet, Object>
{
	[CompilerGenerated]
	[Token(Token = "0x2000047")]
	private sealed class <GetPropertiesEnumerable>d__4 : IEnumerable<IProperty`1<TSet>>, IEnumerable, IEnumerator<IProperty`1<TSet>>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000071")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000072")]
		private IProperty<TSet> <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000073")]
		private int <>l__initialThreadId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000074")]
		private TSet container; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000075")]
		public TSet <>3__container; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000076")]
		public SetPropertyBagBase<TSet, TElement> <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000077")]
		private IEnumerator<TElement> <>s__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000078")]
		private TElement <element>5__2; //Field offset: 0x0

		[Token(Token = "0x17000039")]
		private override IProperty<TSet> System.Collections.Generic.IEnumerator<Unity.Properties.IProperty<TSet>>.Current
		{
			[Address(RVA = "0x8128E0", Offset = "0x811AE0", Length = "0x2A")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000126")]
			private get { } //Length: 42
		}

		[Token(Token = "0x1700003A")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x8128E0", Offset = "0x811AE0", Length = "0x2A")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000128")]
			private get { } //Length: 42
		}

		[Address(RVA = "0x7F3CD0", Offset = "0x7F2ED0", Length = "0xBE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_custom_attrs_free")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED940")]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000122")]
		public <GetPropertiesEnumerable>d__4(int <>1__state) { }

		[Address(RVA = "0x812950", Offset = "0x811B50", Length = "0xEC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_custom_attrs_free")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED940")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000125")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x811E80", Offset = "0x811080", Length = "0x63C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED940")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEC40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002A0B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEB00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_custom_attrs_free")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1807F31A0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000124")]
		private override bool MoveNext() { }

		[Address(RVA = "0x8126B0", Offset = "0x8118B0", Length = "0x227")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_custom_attrs_free")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED940")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEC40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000129")]
		private override IEnumerator<IProperty`1<TSet>> System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TSet>>.GetEnumerator() { }

		[Address(RVA = "0x8128E0", Offset = "0x811AE0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000126")]
		private override IProperty<TSet> System.Collections.Generic.IEnumerator<Unity.Properties.IProperty<TSet>>.get_Current() { }

		[Address(RVA = "0x812930", Offset = "0x811B30", Length = "0x18")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600012A")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x8128E0", Offset = "0x811AE0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000128")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x7F3A50", Offset = "0x7F2C50", Length = "0x39")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000127")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x7F3B40", Offset = "0x7F2D40", Length = "0x95")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsUnknownMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000123")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000046")]
	private class SetElementProperty : Property<TSet, TElement>, ISetElementProperty
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000070")]
		internal TElement m_Value; //Field offset: 0x0

		[Token(Token = "0x17000037")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x600011D")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000036")]
		public virtual string Name
		{
			[Address(RVA = "0xF11780", Offset = "0xF10980", Length = "0xE6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEB00")]
			[DeduplicatedMethod]
			[Token(Token = "0x600011C")]
			 get { } //Length: 230
		}

		[Token(Token = "0x17000038")]
		public override object ObjectKey
		{
			[Address(RVA = "0xF11870", Offset = "0xF10A70", Length = "0xA9")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000120")]
			 get { } //Length: 169
		}

		[Address(RVA = "0xAF8470", Offset = "0xAF7670", Length = "0x15")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000121")]
		public SetElementProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x600011D")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0xF11780", Offset = "0xF10980", Length = "0xE6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEB00")]
		[DeduplicatedMethod]
		[Token(Token = "0x600011C")]
		public virtual string get_Name() { }

		[Address(RVA = "0xF11870", Offset = "0xF10A70", Length = "0xA9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000120")]
		public override object get_ObjectKey() { }

		[Address(RVA = "0xF11690", Offset = "0xF10890", Length = "0xA0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
		[DeduplicatedMethod]
		[Token(Token = "0x600011E")]
		public virtual TElement GetValue(ref TSet container) { }

		[Address(RVA = "0xF11730", Offset = "0xF10930", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x600011F")]
		public virtual void SetValue(ref TSet container, TElement value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400006F")]
	private readonly SetElementProperty<TSet, TElement> m_Property; //Field offset: 0x0

	[Address(RVA = "0xF11E60", Offset = "0xF11060", Length = "0xCC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600011B")]
	public SetPropertyBagBase`2() { }

	[Address(RVA = "0xC8C690", Offset = "0xC8B890", Length = "0x11E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000115")]
	public virtual PropertyCollection<TSet> GetProperties() { }

	[Address(RVA = "0xF11AA0", Offset = "0xF10CA0", Length = "0x179")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
	[Calls(Type = typeof(Unity.Properties.PropertyCollection`1<Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericType>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Unity.Properties.IProperty`1<Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericType>>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000116")]
	public virtual PropertyCollection<TSet> GetProperties(ref TSet container) { }

	[Address(RVA = "0xF11920", Offset = "0xF10B20", Length = "0x171")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_custom_attrs_free")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED940")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEC40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[IteratorStateMachine(typeof(<GetPropertiesEnumerable>d__4))]
	[Token(Token = "0x6000117")]
	private IEnumerable<IProperty`1<TSet>> GetPropertiesEnumerable(TSet container) { }

	[Address(RVA = "0xF11C20", Offset = "0xF10E20", Length = "0x231")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EDA30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEB00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEC40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600011A")]
	public override bool TryGetProperty(ref TSet container, object key, out IProperty<TSet>& property) { }

	[Address(RVA = "0xCDF4C0", Offset = "0xCDE6C0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800B7280")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000118")]
	private override void Unity.Properties.ICollectionPropertyBagAccept<TSet>.Accept(ICollectionPropertyBagVisitor visitor, ref TSet container) { }

	[Address(RVA = "0xCDF4F0", Offset = "0xCDE6F0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800B7280")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000119")]
	private override void Unity.Properties.ISetPropertyBagAccept<TSet>.Accept(ISetPropertyBagVisitor visitor, ref TSet container) { }

}

