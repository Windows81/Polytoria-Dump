namespace UnityEngine.UIElements.Internal;

[Token(Token = "0x200062F")]
internal class AutoCompletePathVisitor : ITypeVisitor, IPropertyVisitor, IPropertyBagVisitor, IListPropertyVisitor
{
	[Token(Token = "0x2000631")]
	private struct InspectedTypeScope : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001706")]
		private VisitContext m_VisitContext; //Field offset: 0x0

		[Address(RVA = "0xC9C950", Offset = "0xC9BB50", Length = "0xB8")]
		[CalledBy(Type = typeof(AutoCompletePathVisitor), Member = "Unity.Properties.ITypeVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AutoCompletePathVisitor), Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B8C")]
		public InspectedTypeScope`1(VisitContext context) { }

		[Address(RVA = "0xC9ABE0", Offset = "0xC99DE0", Length = "0xA7")]
		[CalledBy(Type = typeof(AutoCompletePathVisitor), Member = "Unity.Properties.ITypeVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AutoCompletePathVisitor), Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B8D")]
		public override void Dispose() { }

	}

	[Token(Token = "0x2000630")]
	private class VisitContext
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001702")]
		private List<PropertyPathInfo> <propertyPathInfos>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001703")]
		private readonly HashSet<Type> <types>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001704")]
		private PropertyPath <current>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4001705")]
		private int <currentDepth>k__BackingField; //Field offset: 0xB0

		[Token(Token = "0x17000B25")]
		public PropertyPath current
		{
			[Address(RVA = "0x1BF9370", Offset = "0x1BF8570", Length = "0x57")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[Token(Token = "0x6002B87")]
			 get { } //Length: 87
			[Address(RVA = "0x1BF93D0", Offset = "0x1BF85D0", Length = "0x5E")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CompilerGenerated]
			[Token(Token = "0x6002B88")]
			 set { } //Length: 94
		}

		[Token(Token = "0x17000B26")]
		public int currentDepth
		{
			[Address(RVA = "0x13F9F60", Offset = "0x13F9160", Length = "0x7")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6002B89")]
			 get { } //Length: 7
			[Address(RVA = "0x184DF20", Offset = "0x184D120", Length = "0x7")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6002B8A")]
			 set { } //Length: 7
		}

		[Token(Token = "0x17000B23")]
		public List<PropertyPathInfo> propertyPathInfos
		{
			[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
			[CallerCount(Count = 50)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6002B84")]
			 get { } //Length: 5
			[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6002B85")]
			 set { } //Length: 13
		}

		[Token(Token = "0x17000B24")]
		public HashSet<Type> types
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6002B86")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x1BF92F0", Offset = "0x1BF84F0", Length = "0x77")]
		[CalledBy(Type = typeof(AutoCompletePathVisitor), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002B8B")]
		public VisitContext() { }

		[Address(RVA = "0x1BF9370", Offset = "0x1BF8570", Length = "0x57")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6002B87")]
		public PropertyPath get_current() { }

		[Address(RVA = "0x13F9F60", Offset = "0x13F9160", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B89")]
		public int get_currentDepth() { }

		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B84")]
		public List<PropertyPathInfo> get_propertyPathInfos() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B86")]
		public HashSet<Type> get_types() { }

		[Address(RVA = "0x1BF93D0", Offset = "0x1BF85D0", Length = "0x5E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x6002B88")]
		public void set_current(PropertyPath value) { }

		[Address(RVA = "0x184DF20", Offset = "0x184D120", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B8A")]
		public void set_currentDepth(int value) { }

		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B85")]
		public void set_propertyPathInfos(List<PropertyPathInfo> value) { }

	}

	[Token(Token = "0x2000632")]
	private struct VisitedPropertyScope : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001707")]
		private VisitContext m_VisitContext; //Field offset: 0x0

		[Address(RVA = "0x1BF9900", Offset = "0x1BF8B00", Length = "0x611")]
		[CalledBy(Type = typeof(AutoCompletePathVisitor), Member = "Unity.Properties.ITypeVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AutoCompletePathVisitor), Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(PropertyPathInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(Type)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D38F0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(VisualElement), Member = "get_customStyle", ReturnType = typeof(ICustomStyle))]
		[Calls(Type = typeof(PropertyPath), Member = "AppendProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(IProperty)}, ReturnType = typeof(PropertyPath))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Math), Member = "ThrowMinMaxException", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Image), Member = "ReadCustomProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomStyle)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002B8E")]
		public VisitedPropertyScope(VisitContext context, IProperty property) { }

		[Address(RVA = "0x1BF95C0", Offset = "0x1BF87C0", Length = "0x337")]
		[CalledBy(Type = typeof(AutoCompletePathVisitor), Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AutoCompletePathVisitor), Member = "VisitPropertyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(PropertyPathPart), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(PropertyPath), Member = "AppendPart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(PropertyPathPart&)}, ReturnType = typeof(PropertyPath))]
		[Calls(Type = typeof(PropertyPathInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(Type)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D38F0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002B8F")]
		public VisitedPropertyScope(VisitContext context, int index, Type type) { }

		[Address(RVA = "0x1BF9430", Offset = "0x1BF8630", Length = "0x18C")]
		[CalledBy(Type = typeof(AutoCompletePathVisitor), Member = "Unity.Properties.ITypeVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AutoCompletePathVisitor), Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AutoCompletePathVisitor), Member = "VisitPropertyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(PropertyPath), Member = "SubPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(int), typeof(int)}, ReturnType = typeof(PropertyPath))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002B90")]
		public override void Dispose() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001700")]
	private VisitContext m_VisitContext; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001701")]
	private int <maxDepth>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000B22")]
	public int maxDepth
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B7B")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x1BBCD00", Offset = "0x1BBBF00", Length = "0x66")]
	[CalledBy(Type = "UnityEngine.UIElements.DataBindingUtility+<>c", Member = "<.cctor>b__23_2", ReturnType = typeof(AutoCompletePathVisitor))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VisitContext), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002B83")]
	public AutoCompletePathVisitor() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B7B")]
	public int get_maxDepth() { }

	[Address(RVA = "0x1BBC850", Offset = "0x1BBBA50", Length = "0x75")]
	[CalledBy(Type = typeof(AutoCompletePathVisitor), Member = "Unity.Properties.ITypeVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AutoCompletePathVisitor), Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002B7C")]
	private bool HasReachedEnd(Type containerType) { }

	[Address(RVA = "0x1BBC8D0", Offset = "0x1BBBAD0", Length = "0xC5")]
	[CalledBy(Type = "UnityEngine.UIElements.DataBindingUtility+<>c", Member = "<.cctor>b__23_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AutoCompletePathVisitor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002B7D")]
	public void Reset() { }

	[Address(RVA = "0x654D60", Offset = "0x653F60", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B81")]
	private override void Unity.Properties.IListPropertyVisitor.Visit(Property<TContainer, TList> property, ref TContainer container, ref TList list) { }

	[Address(RVA = "0x655B30", Offset = "0x654D30", Length = "0x68E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PropertyCollection`1), Member = "GetEnumerator", ReturnType = "Unity.Properties.PropertyCollection`1<TContainer>+Enumerator<TContainer>")]
	[Calls(Type = typeof(VisitedPropertyScope), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(VisitedPropertyScope), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisitContext), typeof(int), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(InspectedTypeScope`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(AutoCompletePathVisitor), Member = "VisitPropertyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(InspectedTypeScope`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisitContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AutoCompletePathVisitor), Member = "HasReachedEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(VisitedPropertyScope), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisitContext), typeof(IProperty)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B7F")]
	private override void Unity.Properties.IPropertyBagVisitor.Visit(IPropertyBag<TContainer> properties, ref TContainer container) { }

	[Address(RVA = "0x669F30", Offset = "0x669130", Length = "0x250")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180028180")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(AutoCompletePathVisitor), Member = "VisitPropertyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyBag), Member = "TryGetPropertyBagForValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), typeof(IPropertyBag&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180023C20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(TypeTraits), Member = "IsContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE450")]
	[Calls(Type = typeof(PropertyContainer), Member = "TryAccept", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPropertyBagVisitor), typeof(Int32Enum&), typeof(VisitParameters)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B80")]
	private override void Unity.Properties.IPropertyVisitor.Visit(Property<TContainer, TValue> property, ref TContainer container) { }

	[Address(RVA = "0x67BE30", Offset = "0x67B030", Length = "0x450")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(VisitedPropertyScope), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(AutoCompletePathVisitor), Member = "VisitPropertyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(VisitedPropertyScope), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisitContext), typeof(IProperty)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PropertyCollection`1), Member = "GetEnumerator", ReturnType = "Unity.Properties.PropertyCollection`1<TContainer>+Enumerator<TContainer>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(PropertyBag), Member = "GetPropertyBag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, ReturnType = "Unity.Properties.IPropertyBag`1<TContainer>")]
	[Calls(Type = typeof(InspectedTypeScope`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisitContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AutoCompletePathVisitor), Member = "HasReachedEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(InspectedTypeScope`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B7E")]
	private override void Unity.Properties.ITypeVisitor.Visit() { }

	[Address(RVA = "0x1BBC9A0", Offset = "0x1BBBBA0", Length = "0x359")]
	[CalledBy(Type = typeof(AutoCompletePathVisitor), Member = "Unity.Properties.ITypeVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AutoCompletePathVisitor), Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AutoCompletePathVisitor), Member = "Unity.Properties.IPropertyVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>", "TContainer&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PropertyBag), Member = "GetPropertyBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(IPropertyBag))]
	[Calls(Type = typeof(VisitedPropertyScope), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisitedPropertyScope), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisitContext), typeof(int), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x6002B82")]
	private void VisitPropertyType(Type type) { }

}

