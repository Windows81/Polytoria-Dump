namespace Unity.Properties;

[IsReadOnly]
[Token(Token = "0x200001A")]
public struct PropertyPathPart : IEquatable<PropertyPathPart>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000028")]
	private readonly PropertyPathPartKind m_Kind; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000029")]
	private readonly string m_Name; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400002A")]
	private readonly int m_Index; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400002B")]
	private readonly object m_Key; //Field offset: 0x18

	[Token(Token = "0x17000010")]
	public int Index
	{
		[Address(RVA = "0x1A0F0F0", Offset = "0x1A0E2F0", Length = "0x53")]
		[CalledBy(Type = "UnityEngine.UIElements.VisualTreeDataBindingsUpdater", Member = "IsPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(PropertyPath&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.Internal.TypePathVisitor", Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PathVisitor), Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000045")]
		 get { } //Length: 83
	}

	[Token(Token = "0x1700000D")]
	public bool IsIndex
	{
		[Address(RVA = "0x1A0F150", Offset = "0x1A0E350", Length = "0x7")]
		[CalledBy(Type = "UnityEngine.UIElements.Internal.TypePathVisitor", Member = "Unity.Properties.ITypeVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000042")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700000C")]
	public bool IsName
	{
		[Address(RVA = "0x181F400", Offset = "0x181E600", Length = "0x7")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000041")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000011")]
	public object Key
	{
		[Address(RVA = "0x1A0F160", Offset = "0x1A0E360", Length = "0x54")]
		[CalledBy(Type = "UnityEngine.UIElements.VisualTreeDataBindingsUpdater", Member = "IsPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(PropertyPath&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(PathVisitor), Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000046")]
		 get { } //Length: 84
	}

	[Token(Token = "0x1700000E")]
	public PropertyPathPartKind Kind
	{
		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000043")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700000F")]
	public string Name
	{
		[Address(RVA = "0x1A0F1C0", Offset = "0x1A0E3C0", Length = "0x54")]
		[CalledBy(Type = "UnityEngine.UIElements.VisualTreeDataBindingsUpdater", Member = "IsPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(PropertyPath&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.Internal.TypePathVisitor", Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.Internal.TypePathVisitor", Member = "Unity.Properties.ITypeVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PathVisitor), Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000044")]
		 get { } //Length: 84
	}

	[Address(RVA = "0x1A0F0B0", Offset = "0x1A0E2B0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000047")]
	public PropertyPathPart(string name) { }

	[Address(RVA = "0x1A0F050", Offset = "0x1A0E250", Length = "0x53")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseListViewController", Member = "SetBindingContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ReusableCollectionItem", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.AutoCompletePathVisitor+VisitedPropertyScope", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Internal.AutoCompletePathVisitor+VisitContext", typeof(int), typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000048")]
	public PropertyPathPart(int index) { }

	[Address(RVA = "0x1A0EFF0", Offset = "0x1A0E1F0", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000049")]
	public PropertyPathPart(object key) { }

	[Address(RVA = "0x1A0ECB0", Offset = "0x1A0DEB0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600004A")]
	private void CheckKind(PropertyPathPartKind type) { }

	[Address(RVA = "0x1A0EDD0", Offset = "0x1A0DFD0", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600004C")]
	public override bool Equals(PropertyPathPart other) { }

	[Address(RVA = "0x1A0ED00", Offset = "0x1A0DF00", Length = "0xCB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600004D")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1A0F0F0", Offset = "0x1A0E2F0", Length = "0x53")]
	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeDataBindingsUpdater", Member = "IsPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(PropertyPath&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.TypePathVisitor", Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PathVisitor), Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000045")]
	public int get_Index() { }

	[Address(RVA = "0x1A0F150", Offset = "0x1A0E350", Length = "0x7")]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.TypePathVisitor", Member = "Unity.Properties.ITypeVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000042")]
	public bool get_IsIndex() { }

	[Address(RVA = "0x181F400", Offset = "0x181E600", Length = "0x7")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000041")]
	public bool get_IsName() { }

	[Address(RVA = "0x1A0F160", Offset = "0x1A0E360", Length = "0x54")]
	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeDataBindingsUpdater", Member = "IsPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(PropertyPath&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PathVisitor), Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000046")]
	public object get_Key() { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000043")]
	public PropertyPathPartKind get_Kind() { }

	[Address(RVA = "0x1A0F1C0", Offset = "0x1A0E3C0", Length = "0x54")]
	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeDataBindingsUpdater", Member = "IsPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(PropertyPath&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.TypePathVisitor", Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.TypePathVisitor", Member = "Unity.Properties.ITypeVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PathVisitor), Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000044")]
	public string get_Name() { }

	[Address(RVA = "0x1A0EE30", Offset = "0x1A0E030", Length = "0xAA")]
	[CalledBy(Type = typeof(PropertyPath), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004E")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1A0EEE0", Offset = "0x1A0E0E0", Length = "0x107")]
	[CalledBy(Type = typeof(PropertyPath), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(PropertyPath), Member = "AppendToBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPathPart&), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004B")]
	public virtual string ToString() { }

}

