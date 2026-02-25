namespace System.Reflection;

[Token(Token = "0x20004DA")]
public abstract class MemberInfo : ICustomAttributeProvider
{

	[Token(Token = "0x17000434")]
	public abstract Type DeclaringType
	{
		[Token(Token = "0x60021A4")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000432")]
	public abstract MemberTypes MemberType
	{
		[Token(Token = "0x60021A2")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000437")]
	public override int MetadataToken
	{
		[Address(RVA = "0x13BD580", Offset = "0x13BC780", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60021AA")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000436")]
	public override Module Module
	{
		[Address(RVA = "0x13BD5C0", Offset = "0x13BC7C0", Length = "0xB2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60021A6")]
		 get { } //Length: 178
	}

	[Token(Token = "0x17000433")]
	public abstract string Name
	{
		[Token(Token = "0x60021A3")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000435")]
	public abstract Type ReflectedType
	{
		[Token(Token = "0x60021A5")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021A1")]
	protected MemberInfo() { }

	[Address(RVA = "0x13B6C10", Offset = "0x13B5E10", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021AB")]
	public virtual bool Equals(object obj) { }

	[Token(Token = "0x60021A4")]
	public abstract Type get_DeclaringType() { }

	[Token(Token = "0x60021A2")]
	public abstract MemberTypes get_MemberType() { }

	[Address(RVA = "0x13BD580", Offset = "0x13BC780", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60021AA")]
	public override int get_MetadataToken() { }

	[Address(RVA = "0x13BD5C0", Offset = "0x13BC7C0", Length = "0xB2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60021A6")]
	public override Module get_Module() { }

	[Token(Token = "0x60021A3")]
	public abstract string get_Name() { }

	[Token(Token = "0x60021A5")]
	public abstract Type get_ReflectedType() { }

	[Token(Token = "0x60021A8")]
	public abstract Object[] GetCustomAttributes(bool inherit) { }

	[Token(Token = "0x60021A9")]
	public abstract Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Address(RVA = "0x2D8E50", Offset = "0x2D8050", Length = "0x7")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021AC")]
	public virtual int GetHashCode() { }

	[Token(Token = "0x60021A7")]
	public abstract bool IsDefined(Type attributeType, bool inherit) { }

	[Address(RVA = "0x13BD680", Offset = "0x13BC880", Length = "0x380")]
	[CalledBy(Type = typeof(CustomAttributeNamedArgument), Member = "get_MemberInfo", ReturnType = typeof(MemberInfo))]
	[CalledBy(Type = "Unity.Burst.BurstCompilerOptions", Member = "HasBurstCompileAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Unity.Burst.BurstCompilerOptions", Member = "TryGetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), "Unity.Burst.BurstCompileAttribute&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Unity.Burst.BurstCompiler", Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MethodInfo), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = "System.Void*")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.DescriptorHelpers", Member = "GetVisibilityFromAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = "System.Nullable`1<Boolean>")]
	[CalledBy(Type = typeof(ValueFixup), Member = "Fixup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord), typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MemberInfo), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FormatterServices), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MemberInfo[])}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(FormatterServices), Member = "PopulateObjectMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MemberInfo[]), typeof(Object[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Attribute), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Attribute), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(bool)}, ReturnType = typeof(Attribute[]))]
	[CalledBy(Type = typeof(Attribute), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(Type), typeof(bool)}, ReturnType = typeof(Attribute[]))]
	[CalledBy(Type = typeof(ObjectManager), Member = "RecordFixup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(MemberInfo), typeof(long)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MethodBase), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(MethodBase)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60021AD")]
	public static bool op_Equality(MemberInfo left, MemberInfo right) { }

	[Address(RVA = "0x13BDA00", Offset = "0x13BCC00", Length = "0x13")]
	[CalledBy(Type = typeof(ObjectManager), Member = "RegisterObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(long), typeof(SerializationInfo), typeof(long), typeof(MemberInfo), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.ComponentModel.DecimalConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MemberInfo), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60021AE")]
	public static bool op_Inequality(MemberInfo left, MemberInfo right) { }

}

