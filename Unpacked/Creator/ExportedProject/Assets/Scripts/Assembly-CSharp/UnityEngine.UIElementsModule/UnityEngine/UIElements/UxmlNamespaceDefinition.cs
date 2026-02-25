namespace UnityEngine.UIElements;

[Token(Token = "0x20004E6")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal struct UxmlNamespaceDefinition : IEquatable<UxmlNamespaceDefinition>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4001019")]
	private static readonly UxmlNamespaceDefinition <Empty>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400101A")]
	public string prefix; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400101B")]
	public string resolvedNamespace; //Field offset: 0x8

	[Address(RVA = "0x1B52050", Offset = "0x1B51250", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600243A")]
	private static UxmlNamespaceDefinition() { }

	[Address(RVA = "0x1B51F30", Offset = "0x1B51130", Length = "0xA4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002437")]
	public override bool Equals(UxmlNamespaceDefinition other) { }

	[Address(RVA = "0x1B51E00", Offset = "0x1B51000", Length = "0x12E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002438")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1B51FE0", Offset = "0x1B511E0", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HashCode), Member = "Combine", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[Token(Token = "0x6002439")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1B52090", Offset = "0x1B51290", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002436")]
	public static bool op_Equality(UxmlNamespaceDefinition lhs, UxmlNamespaceDefinition rhs) { }

}

