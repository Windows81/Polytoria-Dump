namespace System.Reflection;

[ComVisible(True)]
[Token(Token = "0x2000503")]
public class CustomAttributeData
{
	[Token(Token = "0x2000504")]
	private class LazyCAttrData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001450")]
		internal Assembly assembly; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001451")]
		internal IntPtr data; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001452")]
		internal uint data_length; //Field offset: 0x20

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002376")]
		public LazyCAttrData() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400144C")]
	private ConstructorInfo ctorInfo; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400144D")]
	private IList<CustomAttributeTypedArgument> ctorArgs; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400144E")]
	private IList<CustomAttributeNamedArgument> namedArgs; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400144F")]
	private LazyCAttrData lazyData; //Field offset: 0x28

	[Token(Token = "0x170004C7")]
	public Type AttributeType
	{
		[Address(RVA = "0x1393590", Offset = "0x1392790", Length = "0x2A")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002371")]
		 get { } //Length: 42
	}

	[ComVisible(True)]
	[Token(Token = "0x170004C4")]
	public override ConstructorInfo Constructor
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002369")]
		 get { } //Length: 5
	}

	[ComVisible(True)]
	[Token(Token = "0x170004C5")]
	public override IList<CustomAttributeTypedArgument> ConstructorArguments
	{
		[Address(RVA = "0x13D8E20", Offset = "0x13D8020", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CustomAttributeData), Member = "ResolveArguments", ReturnType = typeof(void))]
		[Token(Token = "0x600236A")]
		 get { } //Length: 26
	}

	[Token(Token = "0x170004C6")]
	public override IList<CustomAttributeNamedArgument> NamedArguments
	{
		[Address(RVA = "0x13D8E40", Offset = "0x13D8040", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CustomAttributeData), Member = "ResolveArguments", ReturnType = typeof(void))]
		[Token(Token = "0x600236B")]
		 get { } //Length: 26
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002363")]
	protected CustomAttributeData() { }

	[Address(RVA = "0x13D8CA0", Offset = "0x13D7EA0", Length = "0xCF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002364")]
	internal CustomAttributeData(ConstructorInfo ctorInfo, Assembly assembly, IntPtr data, uint data_length) { }

	[Address(RVA = "0x13D8D70", Offset = "0x13D7F70", Length = "0xAE")]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetPseudoCustomAttributesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(CustomAttributeData[]))]
	[CalledBy(Type = typeof(FieldInfo), Member = "GetPseudoCustomAttributesData", ReturnType = typeof(CustomAttributeData[]))]
	[CalledBy(Type = typeof(RuntimeMethodInfo), Member = "GetPseudoCustomAttributesData", ReturnType = typeof(CustomAttributeData[]))]
	[CalledBy(Type = typeof(RuntimeParameterInfo), Member = "GetPseudoCustomAttributesData", ReturnType = typeof(CustomAttributeData[]))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002365")]
	internal CustomAttributeData(ConstructorInfo ctorInfo) { }

	[Address(RVA = "0x1013590", Offset = "0x1012790", Length = "0x6B")]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002366")]
	internal CustomAttributeData(ConstructorInfo ctorInfo, IList<CustomAttributeTypedArgument> ctorArgs, IList<CustomAttributeNamedArgument> namedArgs) { }

	[Address(RVA = "0x13D7A10", Offset = "0x13D6C10", Length = "0x4F8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ConstructorInfo), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstructorInfo), typeof(ConstructorInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F48C0")]
	[Calls(Type = typeof(CustomAttributeNamedArgument), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002374")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1393590", Offset = "0x1392790", Length = "0x2A")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002371")]
	public Type get_AttributeType() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002369")]
	public override ConstructorInfo get_Constructor() { }

	[Address(RVA = "0x13D8E20", Offset = "0x13D8020", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomAttributeData), Member = "ResolveArguments", ReturnType = typeof(void))]
	[Token(Token = "0x600236A")]
	public override IList<CustomAttributeTypedArgument> get_ConstructorArguments() { }

	[Address(RVA = "0x13D8E40", Offset = "0x13D8040", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomAttributeData), Member = "ResolveArguments", ReturnType = typeof(void))]
	[Token(Token = "0x600236B")]
	public override IList<CustomAttributeNamedArgument> get_NamedArguments() { }

	[Address(RVA = "0x13D7FB0", Offset = "0x13D71B0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
	[Token(Token = "0x6002370")]
	public static IList<CustomAttributeData> GetCustomAttributes(ParameterInfo target) { }

	[Address(RVA = "0x13D7F60", Offset = "0x13D7160", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
	[Token(Token = "0x600236F")]
	public static IList<CustomAttributeData> GetCustomAttributes(Module target) { }

	[Address(RVA = "0x13D8050", Offset = "0x13D7250", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
	[Token(Token = "0x600236C")]
	public static IList<CustomAttributeData> GetCustomAttributes(Assembly target) { }

	[Address(RVA = "0x13D8000", Offset = "0x13D7200", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
	[Token(Token = "0x600236D")]
	public static IList<CustomAttributeData> GetCustomAttributes(MemberInfo target) { }

	[Address(RVA = "0x13D7F10", Offset = "0x13D7110", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
	[Token(Token = "0x600236E")]
	internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeType target) { }

	[Address(RVA = "0x13D80A0", Offset = "0x13D72A0", Length = "0x436")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(CustomAttributeNamedArgument), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6002375")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x13D84F0", Offset = "0x13D76F0", Length = "0x14A")]
	[CalledBy(Type = typeof(CustomAttributeData), Member = "get_ConstructorArguments", ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeTypedArgument>))]
	[CalledBy(Type = typeof(CustomAttributeData), Member = "get_NamedArguments", ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeNamedArgument>))]
	[CalledBy(Type = typeof(CustomAttributeData), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020E420")]
	[Calls(Type = typeof(CustomAttributeData), Member = "UnboxValues", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CustomAttributeTypedArgument)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(CustomAttributeTypedArgument[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
	[Calls(Type = typeof(Array), Member = "AsReadOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CustomAttributeData), Member = "UnboxValues", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = "T[]")]
	[Token(Token = "0x6002368")]
	private void ResolveArguments() { }

	[Address(RVA = "0x13D84E0", Offset = "0x13D76E0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020E420")]
	[Token(Token = "0x6002367")]
	private static void ResolveArgumentsInternal(ConstructorInfo ctor, Assembly assembly, IntPtr data, uint data_length, out Object[] ctorArgs, out Object[] namedArgs) { }

	[Address(RVA = "0x13D8640", Offset = "0x13D7840", Length = "0x653")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CustomAttributeNamedArgument), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CustomAttributeTypedArgument), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CustomAttributeData), Member = "ResolveArguments", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 9)]
	[Token(Token = "0x6002372")]
	public virtual string ToString() { }

	[Address(RVA = "0x68E780", Offset = "0x68D980", Length = "0x149")]
	[CalledBy(Type = typeof(CustomAttributeData), Member = "ResolveArguments", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002373")]
	private static T[] UnboxValues(Object[] values) { }

}

