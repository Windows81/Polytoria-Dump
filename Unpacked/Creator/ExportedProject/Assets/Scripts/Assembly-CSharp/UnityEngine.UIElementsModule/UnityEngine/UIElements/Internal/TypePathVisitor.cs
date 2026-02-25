namespace UnityEngine.UIElements.Internal;

[Token(Token = "0x2000633")]
internal class TypePathVisitor : ITypeVisitor, IPropertyBagVisitor, IPropertyVisitor
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001708")]
	private PropertyPath <Path>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4001709")]
	private Type <resolvedType>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400170A")]
	private VisitReturnCode <ReturnCode>k__BackingField; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400170B")]
	private Type m_LastType; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400170C")]
	private int m_PathIndex; //Field offset: 0xB8

	[Token(Token = "0x17000B27")]
	public PropertyPath Path
	{
		[Address(RVA = "0xB11750", Offset = "0xB10950", Length = "0x54")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B91")]
		 get { } //Length: 84
		[Address(RVA = "0x1BF86D0", Offset = "0x1BF78D0", Length = "0x5B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x6002B92")]
		 set { } //Length: 91
	}

	[Token(Token = "0x17000B28")]
	private Type resolvedType
	{
		[Address(RVA = "0x2DD5C0", Offset = "0x2DC7C0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B93")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000B29")]
	public internal VisitReturnCode ReturnCode
	{
		[Address(RVA = "0x50C450", Offset = "0x50B650", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B94")]
		 get { } //Length: 7
		[Address(RVA = "0x165F430", Offset = "0x165E630", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B95")]
		internal set { } //Length: 7
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B9C")]
	public TypePathVisitor() { }

	[Address(RVA = "0xB11750", Offset = "0xB10950", Length = "0x54")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B91")]
	public PropertyPath get_Path() { }

	[Address(RVA = "0x50C450", Offset = "0x50B650", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B94")]
	public VisitReturnCode get_ReturnCode() { }

	[Address(RVA = "0x1BF83E0", Offset = "0x1BF75E0", Length = "0x1BC")]
	[CalledBy(Type = typeof(TypePathVisitor), Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TypePathVisitor), Member = "Unity.Properties.ITypeVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x6002B9B")]
	private static Type GetElementType(Type type) { }

	[Address(RVA = "0x1BF85A0", Offset = "0x1BF77A0", Length = "0x92")]
	[CalledBy(Type = typeof(TypePathVisitor), Member = "Unity.Properties.ITypeVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002B9A")]
	private bool IsLastPartReached() { }

	[Address(RVA = "0x1BF8640", Offset = "0x1BF7840", Length = "0x88")]
	[CalledBy(Type = "UnityEngine.UIElements.DataBindingUtility+<>c", Member = "<.cctor>b__23_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypePathVisitor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002B96")]
	public void Reset() { }

	[Address(RVA = "0x1BF86D0", Offset = "0x1BF78D0", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[Token(Token = "0x6002B92")]
	public void set_Path(PropertyPath value) { }

	[Address(RVA = "0x2DD5C0", Offset = "0x2DC7C0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B93")]
	private void set_resolvedType(Type value) { }

	[Address(RVA = "0x165F430", Offset = "0x165E630", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B95")]
	internal void set_ReturnCode(VisitReturnCode value) { }

	[Address(RVA = "0x775A60", Offset = "0x774C60", Length = "0x6B8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypePathVisitor), Member = "GetElementType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PropertyCollection`1), Member = "GetEnumerator", ReturnType = "Unity.Properties.PropertyCollection`1<TContainer>+Enumerator<TContainer>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(PropertyPathPart), Member = "get_Name", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(PropertyBag), Member = "GetPropertyBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(IPropertyBag))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(PropertyPathPart), Member = "get_Index", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(PropertyPath), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(PropertyPathPart))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B97")]
	private override void Unity.Properties.IPropertyBagVisitor.Visit(IPropertyBag<TContainer> properties, ref TContainer container) { }

	[Address(RVA = "0x7895F0", Offset = "0x7887F0", Length = "0x1C1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(PropertyBag), Member = "TryGetPropertyBagForValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), typeof(IPropertyBag&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180028180")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180023C20")]
	[Calls(Type = typeof(PropertyBag), Member = "GetPropertyBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(IPropertyBag))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(PropertyContainer), Member = "Accept", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPropertyBagVisitor), typeof(Int32Enum&), typeof(VisitParameters)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B98")]
	private override void Unity.Properties.IPropertyVisitor.Visit(Property<TContainer, TValue> property, ref TContainer container) { }

	[Address(RVA = "0x7B5120", Offset = "0x7B4320", Length = "0x6CD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyCollection`1), Member = "GetEnumerator", ReturnType = "Unity.Properties.PropertyCollection`1<TContainer>+Enumerator<TContainer>")]
	[Calls(Type = typeof(Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(PropertyPathPart), Member = "get_IsIndex", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypePathVisitor), Member = "GetElementType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(PropertyBag), Member = "GetPropertyBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(IPropertyBag))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PropertyPathPart), Member = "get_Name", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(PropertyBag), Member = "GetPropertyBag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, ReturnType = "Unity.Properties.IPropertyBag`1<TContainer>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PropertyPath), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(PropertyPathPart))]
	[Calls(Type = typeof(TypePathVisitor), Member = "IsLastPartReached", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B99")]
	private override void Unity.Properties.ITypeVisitor.Visit() { }

}

