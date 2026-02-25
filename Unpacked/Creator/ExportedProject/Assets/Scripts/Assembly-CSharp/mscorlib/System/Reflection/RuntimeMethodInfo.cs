namespace System.Reflection;

[Token(Token = "0x200050E")]
internal class RuntimeMethodInfo : MethodInfo, ISerializable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400147C")]
	internal IntPtr mhandle; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400147D")]
	private string name; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400147E")]
	private Type reftype; //Field offset: 0x20

	[Token(Token = "0x170004E5")]
	public virtual MethodAttributes Attributes
	{
		[Address(RVA = "0x13E64D0", Offset = "0x13E56D0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801FCB00")]
		[DeduplicatedMethod]
		[Token(Token = "0x60023FF")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170004DE")]
	internal BindingFlags BindingFlags
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x60023E1")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x170004E6")]
	public virtual CallingConventions CallingConvention
	{
		[Address(RVA = "0x13E64E0", Offset = "0x13E56E0", Length = "0x28")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210420")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002400")]
		 get { } //Length: 40
	}

	[Token(Token = "0x170004EC")]
	public virtual bool ContainsGenericParameters
	{
		[Address(RVA = "0x13E9FC0", Offset = "0x13E91C0", Length = "0xEA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsUnknownMethods(Count = 5)]
		[Token(Token = "0x6002412")]
		 get { } //Length: 234
	}

	[Token(Token = "0x170004E8")]
	public virtual Type DeclaringType
	{
		[Address(RVA = "0x13E6550", Offset = "0x13E5750", Length = "0x29")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210420")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002402")]
		 get { } //Length: 41
	}

	[Token(Token = "0x170004EB")]
	public virtual bool IsGenericMethod
	{
		[Address(RVA = "0x13EA0C0", Offset = "0x13E92C0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020E800")]
		[Token(Token = "0x6002411")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004EA")]
	public virtual bool IsGenericMethodDefinition
	{
		[Address(RVA = "0x13EA0B0", Offset = "0x13E92B0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020E840")]
		[Token(Token = "0x6002410")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004ED")]
	public virtual bool IsSecurityCritical
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002414")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170004E3")]
	public virtual int MetadataToken
	{
		[Address(RVA = "0x13E6580", Offset = "0x13E5780", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020E9B0")]
		[DeduplicatedMethod]
		[Token(Token = "0x60023F6")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004E4")]
	public virtual RuntimeMethodHandle MethodHandle
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x60023FE")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004DF")]
	public virtual Module Module
	{
		[Address(RVA = "0x13E9720", Offset = "0x13E8920", Length = "0x89")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60023E2")]
		 get { } //Length: 137
	}

	[Token(Token = "0x170004E9")]
	public virtual string Name
	{
		[Address(RVA = "0x13E6590", Offset = "0x13E5790", Length = "0x10")]
		[CallerCount(Count = 0)]
		[ContainsInvalidInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6002403")]
		 get { } //Length: 16
	}

	[Token(Token = "0x170004E7")]
	public virtual Type ReflectedType
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002401")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004E0")]
	private RuntimeType ReflectedTypeInternal
	{
		[Address(RVA = "0x13EA0D0", Offset = "0x13E92D0", Length = "0x7D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60023E3")]
		private get { } //Length: 125
	}

	[Token(Token = "0x170004E1")]
	public virtual ParameterInfo ReturnParameter
	{
		[Address(RVA = "0x13E4650", Offset = "0x13E3850", Length = "0xE3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210420")]
		[Calls(Type = typeof(CppNativeMethods), Member = "mini_get_interp_callbacks")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60023F4")]
		 get { } //Length: 227
	}

	[Token(Token = "0x170004E2")]
	public virtual Type ReturnType
	{
		[Address(RVA = "0x13EA150", Offset = "0x13E9350", Length = "0x29")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210420")]
		[Token(Token = "0x60023F5")]
		 get { } //Length: 41
	}

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60023EF")]
	internal RuntimeMethodInfo() { }

	[Address(RVA = "0x13E7CC0", Offset = "0x13E6EC0", Length = "0x367")]
	[CalledBy(Type = typeof(RuntimeMethodInfo), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeConstructorInfo), Member = "DoInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TargetParameterCountException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(RuntimeType), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Binder), typeof(CultureInfo), typeof(BindingFlags)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60023FD")]
	internal static void ConvertValues(Binder binder, Object[] args, ParameterInfo[] pinfo, CultureInfo culture, BindingFlags invokeAttr) { }

	[Address(RVA = "0x13E8030", Offset = "0x13E7230", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "CreateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(Delegate))]
	[Token(Token = "0x60023E5")]
	public virtual Delegate CreateDelegate(Type delegateType) { }

	[Address(RVA = "0x13E8050", Offset = "0x13E7250", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "CreateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(MethodInfo)}, ReturnType = typeof(Delegate))]
	[Token(Token = "0x60023E6")]
	public virtual Delegate CreateDelegate(Type delegateType, object target) { }

	[Address(RVA = "0x13E8070", Offset = "0x13E7270", Length = "0x302")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeMethodHandle), Member = "ConstructInstantiation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeMethodInfo), typeof(TypeNameFormatFlags)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "TrimEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60023E4")]
	internal virtual string FormatNameAndSig(bool serialization) { }

	[Address(RVA = "0x13E64D0", Offset = "0x13E56D0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801FCB00")]
	[DeduplicatedMethod]
	[Token(Token = "0x60023FF")]
	public virtual MethodAttributes get_Attributes() { }

	[Address(RVA = "0x13EA180", Offset = "0x13E9380", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020E850")]
	[Token(Token = "0x60023F1")]
	internal static RuntimeMethodInfo get_base_method(RuntimeMethodInfo method, bool definition) { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x60023E1")]
	internal BindingFlags get_BindingFlags() { }

	[Address(RVA = "0x13E64E0", Offset = "0x13E56E0", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210420")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002400")]
	public virtual CallingConventions get_CallingConvention() { }

	[Address(RVA = "0x13E9FC0", Offset = "0x13E91C0", Length = "0xEA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6002412")]
	public virtual bool get_ContainsGenericParameters() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002413")]
	private static int get_core_clr_security_level() { }

	[Address(RVA = "0x13E6550", Offset = "0x13E5750", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210420")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002402")]
	public virtual Type get_DeclaringType() { }

	[Address(RVA = "0x13EA0C0", Offset = "0x13E92C0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020E800")]
	[Token(Token = "0x6002411")]
	public virtual bool get_IsGenericMethod() { }

	[Address(RVA = "0x13EA0B0", Offset = "0x13E92B0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020E840")]
	[Token(Token = "0x6002410")]
	public virtual bool get_IsGenericMethodDefinition() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002414")]
	public virtual bool get_IsSecurityCritical() { }

	[Address(RVA = "0x13E6580", Offset = "0x13E5780", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020E9B0")]
	[DeduplicatedMethod]
	[Token(Token = "0x60023F2")]
	internal static int get_metadata_token(RuntimeMethodInfo method) { }

	[Address(RVA = "0x13E6580", Offset = "0x13E5780", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020E9B0")]
	[DeduplicatedMethod]
	[Token(Token = "0x60023F6")]
	public virtual int get_MetadataToken() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x60023FE")]
	public virtual RuntimeMethodHandle get_MethodHandle() { }

	[Address(RVA = "0x13E9720", Offset = "0x13E8920", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60023E2")]
	public virtual Module get_Module() { }

	[Address(RVA = "0x13EA190", Offset = "0x13E9390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020E9C0")]
	[Token(Token = "0x60023F0")]
	internal static string get_name(MethodBase method) { }

	[Address(RVA = "0x13E6590", Offset = "0x13E5790", Length = "0x10")]
	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002403")]
	public virtual string get_Name() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002401")]
	public virtual Type get_ReflectedType() { }

	[Address(RVA = "0x13EA0D0", Offset = "0x13E92D0", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60023E3")]
	private RuntimeType get_ReflectedTypeInternal() { }

	[Address(RVA = "0x13E4650", Offset = "0x13E3850", Length = "0xE3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210420")]
	[Calls(Type = typeof(CppNativeMethods), Member = "mini_get_interp_callbacks")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60023F4")]
	public virtual ParameterInfo get_ReturnParameter() { }

	[Address(RVA = "0x13EA150", Offset = "0x13E9350", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210420")]
	[Token(Token = "0x60023F5")]
	public virtual Type get_ReturnType() { }

	[Address(RVA = "0x13E8380", Offset = "0x13E7580", Length = "0x7")]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetBasePropertyDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimePropertyInfo)}, ReturnType = typeof(PropertyInfo))]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetBaseEventDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeEventInfo)}, ReturnType = typeof(EventInfo))]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider)}, ReturnType = typeof(ICustomAttributeProvider))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020E850")]
	[Token(Token = "0x60023F3")]
	internal MethodInfo GetBaseMethod() { }

	[Address(RVA = "0x13E8390", Offset = "0x13E7590", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
	[Token(Token = "0x6002406")]
	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Address(RVA = "0x13E8400", Offset = "0x13E7600", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(bool)}, ReturnType = typeof(Object[]))]
	[Token(Token = "0x6002405")]
	public virtual Object[] GetCustomAttributes(bool inherit) { }

	[Address(RVA = "0x13E8460", Offset = "0x13E7660", Length = "0xB6C")]
	[CalledBy(Type = typeof(RuntimeMethodInfo), Member = "GetPseudoCustomAttributesData", ReturnType = typeof(CustomAttributeData[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type[])}, ReturnType = typeof(ConstructorInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CustomAttributeNamedArgument), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(FieldInfo))]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Array), Member = "GetLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020DB60")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CustomAttributeTypedArgument), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600240A")]
	private CustomAttributeData GetDllImportAttributeData() { }

	[Address(RVA = "0x13E8FF0", Offset = "0x13E81F0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020D870")]
	[Token(Token = "0x600240D")]
	public virtual Type[] GetGenericArguments() { }

	[Address(RVA = "0x13E9010", Offset = "0x13E8210", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020D990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600240F")]
	public virtual MethodInfo GetGenericMethodDefinition() { }

	[Address(RVA = "0x13E9000", Offset = "0x13E8200", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020D990")]
	[Token(Token = "0x600240E")]
	private MethodInfo GetGenericMethodDefinition_impl() { }

	[Address(RVA = "0x13E9080", Offset = "0x13E8280", Length = "0x8")]
	[CalledBy(Type = typeof(MethodBase), Member = "GetMethodFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeMethodHandle)}, ReturnType = typeof(MethodBase))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020DA00")]
	[Token(Token = "0x60023ED")]
	internal static MethodBase GetMethodFromHandleInternalType(IntPtr method_handle, IntPtr type_handle) { }

	[Address(RVA = "0x13E9090", Offset = "0x13E8290", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020DA00")]
	[Token(Token = "0x60023EE")]
	private static MethodBase GetMethodFromHandleInternalType_native(IntPtr method_handle, IntPtr type_handle, bool genericCheck) { }

	[Address(RVA = "0x13E90B0", Offset = "0x13E82B0", Length = "0x8")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodsByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimeMethodInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetConstructors_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(RuntimeType)}, ReturnType = typeof(RuntimeConstructorInfo[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020DA00")]
	[Token(Token = "0x60023EC")]
	internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle, RuntimeTypeHandle reflectedType) { }

	[Address(RVA = "0x13E90A0", Offset = "0x13E82A0", Length = "0xA")]
	[CalledBy(Type = typeof(Delegate), Member = "GetMethodImpl", ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = typeof(MulticastDelegate), Member = "GetMethodImpl", ReturnType = typeof(MethodInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020DA00")]
	[Token(Token = "0x60023EB")]
	internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle) { }

	[Address(RVA = "0x13E5D50", Offset = "0x13E4F50", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210420")]
	[DeduplicatedMethod]
	[Token(Token = "0x60023F7")]
	public virtual MethodImplAttributes GetMethodImplementationFlags() { }

	[Address(RVA = "0x13E90C0", Offset = "0x13E82C0", Length = "0x1C2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RuntimeMethodInfo), Member = "SerializationToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(MemberInfoSerializationHolder), Member = "GetSerializationInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(string), typeof(RuntimeType), typeof(string), typeof(string), typeof(MemberTypes), typeof(Type[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60023E9")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x13E92D0", Offset = "0x13E84D0", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210480")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "FastCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60023F8")]
	public virtual ParameterInfo[] GetParameters() { }

	[Address(RVA = "0x13E92A0", Offset = "0x13E84A0", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210480")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60023FA")]
	internal virtual int GetParametersCount() { }

	[Address(RVA = "0x13E5F30", Offset = "0x13E5130", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210480")]
	[DeduplicatedMethod]
	[Token(Token = "0x60023F9")]
	internal virtual ParameterInfo[] GetParametersInternal() { }

	[Address(RVA = "0x13E9290", Offset = "0x13E8490", Length = "0x5")]
	[CalledBy(Type = typeof(DllImportAttribute), Member = "GetCustomAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeMethodInfo)}, ReturnType = typeof(Attribute))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020DB60")]
	[Token(Token = "0x6002407")]
	internal void GetPInvoke(out PInvokeAttributes flags, out string entryPoint, out string dllName) { }

	[Address(RVA = "0x13E9570", Offset = "0x13E8770", Length = "0x1A3")]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetPseudoCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type)}, ReturnType = typeof(Object[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210420")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DllImportAttribute), Member = "GetCustomAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeMethodInfo)}, ReturnType = typeof(Attribute))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002408")]
	internal Object[] GetPseudoCustomAttributes() { }

	[Address(RVA = "0x13E9360", Offset = "0x13E8560", Length = "0x209")]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetPseudoCustomAttributesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type)}, ReturnType = typeof(CustomAttributeData[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(RuntimeMethodInfo), Member = "GetDllImportAttributeData", ReturnType = typeof(CustomAttributeData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CustomAttributeData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstructorInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210420")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type[])}, ReturnType = typeof(ConstructorInfo))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002409")]
	internal CustomAttributeData[] GetPseudoCustomAttributesData() { }

	[Address(RVA = "0x13E9720", Offset = "0x13E8920", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60023E8")]
	internal RuntimeModule GetRuntimeModule() { }

	[Address(RVA = "0x13E97B0", Offset = "0x13E89B0", Length = "0x5")]
	[CalledBy(Type = typeof(AppDomain), Member = "InvokeInDomainByID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(MethodInfo), typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Marshal), Member = "GetCustomMarshalerInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(ICustomMarshaler))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020DF90")]
	[Token(Token = "0x60023FB")]
	internal object InternalInvoke(object obj, Object[] parameters, out Exception exc) { }

	[Address(RVA = "0x13E97C0", Offset = "0x13E89C0", Length = "0x2C6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_DefaultBinder", ReturnType = typeof(Binder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(TargetException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020DF90")]
	[Calls(Type = typeof(RuntimeMethodInfo), Member = "ConvertValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Binder), typeof(Object[]), typeof(ParameterInfo[]), typeof(CultureInfo), typeof(BindingFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(MethodBase), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(TargetInvocationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x60023FC")]
	public virtual object Invoke(object obj, BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture) { }

	[Address(RVA = "0x13E9A90", Offset = "0x13E8C90", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6002404")]
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	[Address(RVA = "0x13E9B10", Offset = "0x13E8D10", Length = "0x37C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020E310")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600240B")]
	public virtual MethodInfo MakeGenericMethod(Type[] methodInstantiation) { }

	[Address(RVA = "0x13E9B00", Offset = "0x13E8D00", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020E310")]
	[Token(Token = "0x600240C")]
	private MethodInfo MakeGenericMethod_impl(Type[] types) { }

	[Address(RVA = "0x13E9E90", Offset = "0x13E9090", Length = "0x9E")]
	[CalledBy(Type = typeof(MemberInfoSerializationHolder), Member = "GetRealObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamingContext)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeMethodInfo), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60023EA")]
	internal string SerializationToString() { }

	[Address(RVA = "0x13E9F30", Offset = "0x13E9130", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Type), Member = "FormatTypeName", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60023E7")]
	public virtual string ToString() { }

}

