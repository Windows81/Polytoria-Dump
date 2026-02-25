namespace Unity.Properties;

[DefaultMember("Item")]
[IsReadOnly]
[Token(Token = "0x200001B")]
public struct PropertyPath : IEquatable<PropertyPath>
{
	[CompilerGenerated]
	[Token(Token = "0x200001C")]
	private struct <>c__DisplayClass36_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000033")]
		public int index; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000034")]
		public int length; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000035")]
		public string path; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000036")]
		public int state; //Field offset: 0x10

	}

	[Token(Token = "0x400002C")]
	internal const int k_InlineCount = 4; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400002D")]
	private readonly PropertyPathPart m_Part0; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400002E")]
	private readonly PropertyPathPart m_Part1; //Field offset: 0x20
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400002F")]
	private readonly PropertyPathPart m_Part2; //Field offset: 0x40
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000030")]
	private readonly PropertyPathPart m_Part3; //Field offset: 0x60
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000031")]
	private readonly PropertyPathPart[] m_AdditionalParts; //Field offset: 0x80
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000032")]
	private readonly int <Length>k__BackingField; //Field offset: 0x88

	[Token(Token = "0x17000013")]
	public bool IsEmpty
	{
		[Address(RVA = "0x1A12F80", Offset = "0x1A12180", Length = "0xB")]
		[CalledBy(Type = "UnityEngine.UIElements.BindingUpdater", Member = "UpdateUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BindingContext&", "UnityEngine.UIElements.DataBinding"}, ReturnType = "UnityEngine.UIElements.BindingResult")]
		[CalledBy(Type = "UnityEngine.UIElements.BindingUpdater", Member = "UpdateDataSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BindingContext&", "UnityEngine.UIElements.DataBinding"}, ReturnType = "UnityEngine.UIElements.BindingResult")]
		[CalledBy(Type = "UnityEngine.UIElements.ConverterGroup", Member = "TrySetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer&", typeof(PropertyPath&), "TValue", typeof(VisitReturnCode&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.DataBinding", Member = "UpdateUI", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BindingContext&", "TValue&"}, ReturnType = "UnityEngine.UIElements.BindingResult")]
		[CalledBy(Type = "UnityEngine.UIElements.DataBinding", Member = "GetSetValueErrorString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisitReturnCode), typeof(object), typeof(PropertyPath&), typeof(object), "UnityEngine.UIElements.BindingId&", "TValue"}, ReturnType = typeof(string))]
		[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyDataSourceTracker", Member = "GetResolvedDataSourceContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", "UnityEngine.UIElements.DataBindingManager+BindingData"}, ReturnType = "UnityEngine.UIElements.DataSourceContext")]
		[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager", Member = "RegisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", "UnityEngine.UIElements.BindingId&", "UnityEngine.UIElements.Binding"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.VisualTreeDataBindingsUpdater", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "set_dataSourcePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PathRef", Member = "get_IsEmpty", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(PropertyContainer), Member = "TryGetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer&", typeof(PropertyPath&), "TValue&", typeof(VisitReturnCode&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 11)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000050")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000014")]
	public PropertyPathPart Item
	{
		[Address(RVA = "0x1A12F90", Offset = "0x1A12190", Length = "0x1F3")]
		[CalledBy(Type = typeof(PropertyPath), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.VisualTreeDataBindingsUpdater", Member = "IsPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(PropertyPath&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.Internal.TypePathVisitor", Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.Internal.TypePathVisitor", Member = "Unity.Properties.ITypeVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PropertyPath), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(PropertyPath&)}, ReturnType = typeof(PropertyPath))]
		[CalledBy(Type = typeof(PropertyPath), Member = "SubPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(int), typeof(int)}, ReturnType = typeof(PropertyPath))]
		[CalledBy(Type = typeof(PropertyPath), Member = "GetParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(System.Collections.Generic.List`1<Unity.Properties.PropertyPathPart>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PathVisitor), Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Token(Token = "0x6000051")]
		 get { } //Length: 499
	}

	[Token(Token = "0x17000012")]
	public int Length
	{
		[Address(RVA = "0x504490", Offset = "0x503690", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600004F")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x1A12AA0", Offset = "0x1A11CA0", Length = "0x107")]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement+UxmlTraits", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", "UnityEngine.UIElements.IUxmlAttributes", "UnityEngine.UIElements.CreationContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BindingId", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyContainer), Member = "TryGetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer&", typeof(string), "TValue&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PropertyPath), Member = "ConstructFromPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyPath))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000052")]
	public PropertyPath(string path) { }

	[Address(RVA = "0x1A129A0", Offset = "0x1A11BA0", Length = "0x69")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseListViewController", Member = "SetBindingContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ReusableCollectionItem", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000053")]
	private PropertyPath(in PropertyPathPart part) { }

	[Address(RVA = "0x1A12A10", Offset = "0x1A11C10", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000054")]
	private PropertyPath(in PropertyPathPart part0, in PropertyPathPart part1) { }

	[Address(RVA = "0x1A12BB0", Offset = "0x1A11DB0", Length = "0xA3")]
	[CalledBy(Type = typeof(PropertyPath), Member = "AppendPart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(PropertyPathPart&)}, ReturnType = typeof(PropertyPath))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000055")]
	private PropertyPath(in PropertyPathPart part0, in PropertyPathPart part1, in PropertyPathPart part2) { }

	[Address(RVA = "0x1A12EC0", Offset = "0x1A120C0", Length = "0xB7")]
	[CalledBy(Type = typeof(PropertyPath), Member = "AppendPart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(PropertyPathPart&)}, ReturnType = typeof(PropertyPath))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000056")]
	private PropertyPath(in PropertyPathPart part0, in PropertyPathPart part1, in PropertyPathPart part2, in PropertyPathPart part3) { }

	[Address(RVA = "0x1A12C60", Offset = "0x1A11E60", Length = "0x251")]
	[CalledBy(Type = typeof(PropertyPath), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(PropertyPath&)}, ReturnType = typeof(PropertyPath))]
	[CalledBy(Type = typeof(PropertyPath), Member = "AppendPart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(PropertyPathPart&)}, ReturnType = typeof(PropertyPath))]
	[CalledBy(Type = typeof(PropertyPath), Member = "SubPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(int), typeof(int)}, ReturnType = typeof(PropertyPath))]
	[CalledBy(Type = typeof(PropertyPath), Member = "ConstructFromPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyPath))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000057")]
	internal PropertyPath(List<PropertyPathPart> parts) { }

	[Address(RVA = "0x1A12810", Offset = "0x1A11A10", Length = "0x14A")]
	[CalledBy(Type = typeof(PropertyPath), Member = "ConstructFromPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyPath))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CompilerGenerated]
	[Token(Token = "0x6000069")]
	internal static void <ConstructFromPath>g__ReadNext|36_1(ref <>c__DisplayClass36_0 unnamed_param_0) { }

	[Address(RVA = "0x1A12960", Offset = "0x1A11B60", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CompilerGenerated]
	[Token(Token = "0x6000068")]
	internal static void <ConstructFromPath>g__TrimStart|36_0(ref <>c__DisplayClass36_0 unnamed_param_0) { }

	[Address(RVA = "0x1A0F220", Offset = "0x1A0E420", Length = "0xF3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PropertyPath), Member = "AppendPart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(PropertyPathPart&)}, ReturnType = typeof(PropertyPath))]
	[Token(Token = "0x600005B")]
	public static PropertyPath AppendIndex(in PropertyPath path, int index) { }

	[Address(RVA = "0x1A0F320", Offset = "0x1A0E520", Length = "0x4EB")]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.AutoCompletePathVisitor+VisitedPropertyScope", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Internal.AutoCompletePathVisitor+VisitContext", typeof(int), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyPath), Member = "AppendIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(int)}, ReturnType = typeof(PropertyPath))]
	[CalledBy(Type = typeof(PropertyPath), Member = "AppendProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(IProperty)}, ReturnType = typeof(PropertyPath))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PropertyPath), Member = "GetParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(System.Collections.Generic.List`1<Unity.Properties.PropertyPathPart>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PropertyPath), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPathPart&), typeof(PropertyPathPart&), typeof(PropertyPathPart&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyPath), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPathPart&), typeof(PropertyPathPart&), typeof(PropertyPathPart&), typeof(PropertyPathPart&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1819F4950")]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D3850")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PropertyPath), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Unity.Properties.PropertyPathPart>)}, ReturnType = typeof(void))]
	[Token(Token = "0x600005A")]
	public static PropertyPath AppendPart(in PropertyPath path, in PropertyPathPart part) { }

	[Address(RVA = "0x1A0F810", Offset = "0x1A0EA10", Length = "0x312")]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.AutoCompletePathVisitor+VisitedPropertyScope", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Internal.AutoCompletePathVisitor+VisitContext", typeof(IProperty)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(PropertyPath), Member = "AppendPart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(PropertyPathPart&)}, ReturnType = typeof(PropertyPath))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600005C")]
	public static PropertyPath AppendProperty(in PropertyPath path, IProperty property) { }

	[Address(RVA = "0x1A0FB30", Offset = "0x1A0ED30", Length = "0xB3")]
	[CalledBy(Type = typeof(PropertyPath), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(PropertyPathPart), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000060")]
	private static void AppendToBuilder(in PropertyPathPart part, StringBuilder builder) { }

	[Address(RVA = "0x1A0FBF0", Offset = "0x1A0EDF0", Length = "0x6FD")]
	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyDataSourceTracker", Member = "GetResolvedDataSourceContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", "UnityEngine.UIElements.DataBindingManager+BindingData"}, ReturnType = "UnityEngine.UIElements.DataSourceContext")]
	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyDataSourceTracker", Member = "GetHierarchicalDataSourceContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement"}, ReturnType = "UnityEngine.UIElements.DataSourceContext")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PropertyPath), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(PropertyPathPart))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(PropertyPath), Member = "GetParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(System.Collections.Generic.List`1<Unity.Properties.PropertyPathPart>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyPath), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Unity.Properties.PropertyPathPart>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1819F4950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000059")]
	public static PropertyPath Combine(in PropertyPath path, in PropertyPath pathToAppend) { }

	[Address(RVA = "0x1A102F0", Offset = "0x1A0F4F0", Length = "0x116D")]
	[CalledBy(Type = typeof(PropertyPath), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PropertyPath), Member = "<ConstructFromPath>g__ReadNext|36_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<>c__DisplayClass36_0&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1819F4950")]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyPath), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Unity.Properties.PropertyPathPart>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D3850")]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000062")]
	private static PropertyPath ConstructFromPath(string path) { }

	[Address(RVA = "0x1A11460", Offset = "0x1A10660", Length = "0x125")]
	[CalledBy(Type = typeof(PropertyPath), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath), typeof(PropertyPath)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PropertyPath), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath), typeof(PropertyPath)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PropertyPath), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PropertyPath), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(PropertyPathPart))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000065")]
	public override bool Equals(PropertyPath other) { }

	[Address(RVA = "0x1A11590", Offset = "0x1A10790", Length = "0xFF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(PropertyPath), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000066")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1A11690", Offset = "0x1A10890", Length = "0xE7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000058")]
	public static PropertyPath FromIndex(int index) { }

	[Address(RVA = "0x1A12F80", Offset = "0x1A12180", Length = "0xB")]
	[CalledBy(Type = "UnityEngine.UIElements.BindingUpdater", Member = "UpdateUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BindingContext&", "UnityEngine.UIElements.DataBinding"}, ReturnType = "UnityEngine.UIElements.BindingResult")]
	[CalledBy(Type = "UnityEngine.UIElements.BindingUpdater", Member = "UpdateDataSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BindingContext&", "UnityEngine.UIElements.DataBinding"}, ReturnType = "UnityEngine.UIElements.BindingResult")]
	[CalledBy(Type = "UnityEngine.UIElements.ConverterGroup", Member = "TrySetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer&", typeof(PropertyPath&), "TValue", typeof(VisitReturnCode&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.DataBinding", Member = "UpdateUI", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BindingContext&", "TValue&"}, ReturnType = "UnityEngine.UIElements.BindingResult")]
	[CalledBy(Type = "UnityEngine.UIElements.DataBinding", Member = "GetSetValueErrorString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisitReturnCode), typeof(object), typeof(PropertyPath&), typeof(object), "UnityEngine.UIElements.BindingId&", "TValue"}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyDataSourceTracker", Member = "GetResolvedDataSourceContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", "UnityEngine.UIElements.DataBindingManager+BindingData"}, ReturnType = "UnityEngine.UIElements.DataSourceContext")]
	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager", Member = "RegisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", "UnityEngine.UIElements.BindingId&", "UnityEngine.UIElements.Binding"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeDataBindingsUpdater", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "set_dataSourcePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PathRef", Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PropertyContainer), Member = "TryGetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer&", typeof(PropertyPath&), "TValue&", typeof(VisitReturnCode&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 11)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000050")]
	public bool get_IsEmpty() { }

	[Address(RVA = "0x1A12F90", Offset = "0x1A12190", Length = "0x1F3")]
	[CalledBy(Type = typeof(PropertyPath), Member = "GetParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(System.Collections.Generic.List`1<Unity.Properties.PropertyPathPart>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyPath), Member = "SubPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(int), typeof(int)}, ReturnType = typeof(PropertyPath))]
	[CalledBy(Type = typeof(PropertyPath), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(PropertyPath&)}, ReturnType = typeof(PropertyPath))]
	[CalledBy(Type = typeof(PathVisitor), Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.TypePathVisitor", Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeDataBindingsUpdater", Member = "IsPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(PropertyPath&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PropertyPath), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.TypePathVisitor", Member = "Unity.Properties.ITypeVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, ReturnType = typeof(void))]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000051")]
	public PropertyPathPart get_Item(int index) { }

	[Address(RVA = "0x504490", Offset = "0x503690", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600004F")]
	public int get_Length() { }

	[Address(RVA = "0x1A11780", Offset = "0x1A10980", Length = "0x1DA")]
	[CalledBy(Type = "UnityEngine.UIElements.BindingId", Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PropertyPathPart), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000067")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1A11960", Offset = "0x1A10B60", Length = "0x10F")]
	[CalledBy(Type = typeof(PropertyPath), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(PropertyPath&)}, ReturnType = typeof(PropertyPath))]
	[CalledBy(Type = typeof(PropertyPath), Member = "AppendPart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(PropertyPathPart&)}, ReturnType = typeof(PropertyPath))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PropertyPath), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(PropertyPathPart))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000061")]
	private static void GetParts(in PropertyPath path, List<PropertyPathPart> parts) { }

	[Address(RVA = "0x1A13190", Offset = "0x1A12390", Length = "0x6B")]
	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+BindingData", Member = "set_context", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.DataSourceContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "set_dataSourcePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BindingId", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BindingId"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.BindingId", Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BindingId&", "UnityEngine.UIElements.BindingId&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.BindingId", Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BindingId&", "UnityEngine.UIElements.BindingId&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnitySourceGeneratedAssemblyMonoScriptTypes_v1", Member = "Get", ReturnType = "UnitySourceGeneratedAssemblyMonoScriptTypes_v1+MonoScriptData")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(PropertyPath), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000063")]
	public static bool op_Equality(PropertyPath lhs, PropertyPath rhs) { }

	[Address(RVA = "0x1A13200", Offset = "0x1A12400", Length = "0xD1")]
	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager", Member = "RegisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", "UnityEngine.UIElements.BindingId&", "UnityEngine.UIElements.Binding"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager", Member = "UnregisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", "UnityEngine.UIElements.BindingId&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PropertyPath), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000064")]
	public static bool op_Inequality(PropertyPath lhs, PropertyPath rhs) { }

	[Address(RVA = "0x1A11A70", Offset = "0x1A10C70", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyPath), Member = "SubPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(int), typeof(int)}, ReturnType = typeof(PropertyPath))]
	[Token(Token = "0x600005D")]
	public static PropertyPath Pop(in PropertyPath path) { }

	[Address(RVA = "0x1A11B00", Offset = "0x1A10D00", Length = "0xA3A")]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.AutoCompletePathVisitor+VisitedPropertyScope", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyPath), Member = "Pop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&)}, ReturnType = typeof(PropertyPath))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1819F4950")]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(PropertyPath), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(PropertyPathPart))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PropertyPath), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Unity.Properties.PropertyPathPart>)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600005E")]
	public static PropertyPath SubPath(in PropertyPath path, int startIndex, int length) { }

	[Address(RVA = "0x1A12540", Offset = "0x1A11740", Length = "0x2C0")]
	[CalledBy(Type = "UnityEngine.UIElements.BindingId", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PropertyPathPart), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(PropertyPath), Member = "AppendToBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPathPart&), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600005F")]
	public virtual string ToString() { }

}

