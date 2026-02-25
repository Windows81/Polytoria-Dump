namespace Unity.Properties;

[IsReadOnly]
[Token(Token = "0x2000042")]
public struct PropertyCollection : IEnumerable<IProperty`1<TContainer>>, IEnumerable
{
	[Token(Token = "0x2000044")]
	internal struct Enumerator : IEnumerator<IProperty`1<TContainer>>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006A")]
		private readonly EnumeratorType<TContainer> m_Type; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006B")]
		private IEnumerator<IProperty`1<TContainer>> m_Enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006C")]
		private Enumerator<IProperty<TContainer>> m_Properties; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006D")]
		private IndexedCollectionPropertyBagEnumerator<TContainer> m_IndexedCollectionPropertyBag; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006E")]
		private IProperty<TContainer> <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000034")]
		public private override IProperty<TContainer> Current
		{
			[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
			[CallerCount(Count = 4)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			[Token(Token = "0x600010C")]
			 get { } //Length: 5
			[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x600010D")]
			private set { } //Length: 13
		}

		[Token(Token = "0x17000035")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0xAE5380", Offset = "0xAE4580", Length = "0x25")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[DeduplicatedMethod]
			[Token(Token = "0x600010E")]
			private get { } //Length: 37
		}

		[Address(RVA = "0xAE55C0", Offset = "0xAE47C0", Length = "0x67")]
		[CalledBy(Type = typeof(PropertyCollection`1), Member = "GetEnumerator", ReturnType = "Unity.Properties.PropertyCollection`1<TContainer>+Enumerator<TContainer>")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[DeduplicatedMethod]
		[Token(Token = "0x600010F")]
		internal Enumerator(IEnumerator<IProperty`1<TContainer>> enumerator) { }

		[Address(RVA = "0xAE5630", Offset = "0xAE4830", Length = "0x8C")]
		[CalledBy(Type = typeof(PropertyCollection`1), Member = "GetEnumerator", ReturnType = "Unity.Properties.PropertyCollection`1<TContainer>+Enumerator<TContainer>")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000110")]
		internal Enumerator(Enumerator<IProperty<TContainer>> properties) { }

		[Address(RVA = "0xAE5800", Offset = "0xAE4A00", Length = "0x8C")]
		[CalledBy(Type = typeof(PropertyCollection`1), Member = "GetEnumerator", ReturnType = "Unity.Properties.PropertyCollection`1<TContainer>+Enumerator<TContainer>")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000111")]
		internal Enumerator(IndexedCollectionPropertyBagEnumerator<TContainer> enumerator) { }

		[Address(RVA = "0xAE34E0", Offset = "0xAE26E0", Length = "0xD0")]
		[CalledBy(Type = "UnityEngine.UIElements.Internal.AutoCompletePathVisitor", Member = "Unity.Properties.ITypeVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.Internal.AutoCompletePathVisitor", Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.Internal.TypePathVisitor", Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.Internal.TypePathVisitor", Member = "Unity.Properties.ITypeVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000114")]
		public override void Dispose() { }

		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x600010C")]
		public override IProperty<TContainer> get_Current() { }

		[Address(RVA = "0xAE3AA0", Offset = "0xAE2CA0", Length = "0x1DB")]
		[CalledBy(Type = "UnityEngine.UIElements.Internal.AutoCompletePathVisitor", Member = "Unity.Properties.ITypeVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.Internal.AutoCompletePathVisitor", Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.Internal.TypePathVisitor", Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.Internal.TypePathVisitor", Member = "Unity.Properties.ITypeVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(IndexedCollectionPropertyBagEnumerator`1), Member = "get_Current", ReturnType = "Unity.Properties.IProperty`1<TContainer>")]
		[Calls(Type = typeof(IndexedCollectionPropertyBagEnumerator`1), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000112")]
		public override bool MoveNext() { }

		[Address(RVA = "0xAE4A80", Offset = "0xAE3C80", Length = "0x127")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(IndexedCollectionPropertyBagEnumerator`1), Member = "Reset", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000113")]
		public override void Reset() { }

		[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600010D")]
		private void set_Current(IProperty<TContainer> value) { }

		[Address(RVA = "0xAE5380", Offset = "0xAE4580", Length = "0x25")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[DeduplicatedMethod]
		[Token(Token = "0x600010E")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[Token(Token = "0x2000043")]
	private enum EnumeratorType
	{
		Empty = 0,
		Enumerable = 1,
		List = 2,
		IndexedCollectionPropertyBag = 3,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000064")]
	private static readonly PropertyCollection<TContainer> <Empty>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000060")]
	private readonly EnumeratorType<TContainer> m_Type; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000061")]
	private readonly IEnumerable<IProperty`1<TContainer>> m_Enumerable; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000062")]
	private readonly List<IProperty`1<TContainer>> m_Properties; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000063")]
	private readonly IndexedCollectionPropertyBagEnumerable<TContainer> m_IndexedCollectionPropertyBag; //Field offset: 0x0

	[Token(Token = "0x17000033")]
	public static PropertyCollection<TContainer> Empty
	{
		[Address(RVA = "0xE93130", Offset = "0xE92330", Length = "0xB0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000104")]
		 get { } //Length: 176
	}

	[Address(RVA = "0xE92430", Offset = "0xE91630", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[DeduplicatedMethod]
	[Token(Token = "0x600010B")]
	private static PropertyCollection`1() { }

	[Address(RVA = "0xE92570", Offset = "0xE91770", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000105")]
	public PropertyCollection`1(IEnumerable<IProperty`1<TContainer>> enumerable) { }

	[Address(RVA = "0xE92A80", Offset = "0xE91C80", Length = "0x4B")]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag", Member = "GetProperties", ReturnType = "Unity.Properties.PropertyCollection`1<InlineStyleAccess>")]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag", Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.InlineStyleAccess&"}, ReturnType = "Unity.Properties.PropertyCollection`1<InlineStyleAccess>")]
	[CalledBy(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag", Member = "GetProperties", ReturnType = "Unity.Properties.PropertyCollection`1<ResolvedStyleAccess>")]
	[CalledBy(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag", Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ResolvedStyleAccess&"}, ReturnType = "Unity.Properties.PropertyCollection`1<ResolvedStyleAccess>")]
	[CalledBy(Type = typeof(ContainerPropertyBag`1), Member = "GetProperties", ReturnType = "Unity.Properties.PropertyCollection`1<TContainer>")]
	[CalledBy(Type = typeof(ContainerPropertyBag`1), Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer&"}, ReturnType = "Unity.Properties.PropertyCollection`1<TContainer>")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000106")]
	public PropertyCollection`1(List<IProperty`1<TContainer>> properties) { }

	[Address(RVA = "0xE92AD0", Offset = "0xE91CD0", Length = "0x58")]
	[CalledBy(Type = typeof(IndexedCollectionPropertyBag`2), Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TList&"}, ReturnType = "Unity.Properties.PropertyCollection`1<TList>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000107")]
	internal PropertyCollection`1(IndexedCollectionPropertyBagEnumerable<TContainer> enumerable) { }

	[Address(RVA = "0xE93130", Offset = "0xE92330", Length = "0xB0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000104")]
	public static PropertyCollection<TContainer> get_Empty() { }

	[Address(RVA = "0xE8E7F0", Offset = "0xE8D9F0", Length = "0x29C")]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.AutoCompletePathVisitor", Member = "Unity.Properties.ITypeVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.AutoCompletePathVisitor", Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.TypePathVisitor", Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.TypePathVisitor", Member = "Unity.Properties.ITypeVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyCollection`1), Member = "System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<IProperty`1<TContainer>>")]
	[CalledBy(Type = typeof(PropertyCollection`1), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerator`1<IProperty`1<TContainer>>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IndexedCollectionPropertyBagEnumerator`1<TContainer>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IndexedCollectionPropertyBagEnumerable`1), Member = "GetEnumerator", ReturnType = "Unity.Properties.IndexedCollectionPropertyBagEnumerator`1<TContainer>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<IProperty`1<TContainer>>+Enumerator<IProperty`1<TContainer>>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000108")]
	public Enumerator<TContainer> GetEnumerator() { }

	[Address(RVA = "0xE91090", Offset = "0xE90290", Length = "0xFE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PropertyCollection`1), Member = "GetEnumerator", ReturnType = "Unity.Properties.PropertyCollection`1<TContainer>+Enumerator<TContainer>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000109")]
	private override IEnumerator<IProperty`1<TContainer>> System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator() { }

	[Address(RVA = "0xE91090", Offset = "0xE90290", Length = "0xFE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PropertyCollection`1), Member = "GetEnumerator", ReturnType = "Unity.Properties.PropertyCollection`1<TContainer>+Enumerator<TContainer>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[DeduplicatedMethod]
	[Token(Token = "0x600010A")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

