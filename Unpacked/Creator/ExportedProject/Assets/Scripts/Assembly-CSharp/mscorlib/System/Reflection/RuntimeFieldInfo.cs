namespace System.Reflection;

[Token(Token = "0x200050C")]
internal class RuntimeFieldInfo : RtFieldInfo, ISerializable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001472")]
	internal IntPtr klass; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001473")]
	internal RuntimeFieldHandle fhandle; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001474")]
	private string name; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001475")]
	private Type type; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001476")]
	private FieldAttributes attrs; //Field offset: 0x30

	[Token(Token = "0x170004D7")]
	public virtual FieldAttributes Attributes
	{
		[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x60023BF")]
		 get { } //Length: 174
	}

	[Token(Token = "0x170004D4")]
	internal BindingFlags BindingFlags
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x60023B5")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x170004DB")]
	public virtual Type DeclaringType
	{
		[Address(RVA = "0x13E7BC0", Offset = "0x13E6DC0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802105A0")]
		[Token(Token = "0x60023C5")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170004D8")]
	public virtual RuntimeFieldHandle FieldHandle
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x60023C0")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004D9")]
	public virtual Type FieldType
	{
		[Address(RVA = "0x13E7BD0", Offset = "0x13E6DD0", Length = "0x5E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9F0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60023C2")]
		 get { } //Length: 94
	}

	[Token(Token = "0x170004DD")]
	public virtual int MetadataToken
	{
		[Address(RVA = "0x13E6580", Offset = "0x13E5780", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020E9B0")]
		[DeduplicatedMethod]
		[Token(Token = "0x60023D2")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004D5")]
	public virtual Module Module
	{
		[Address(RVA = "0x13E73A0", Offset = "0x13E65A0", Length = "0x89")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60023B6")]
		 get { } //Length: 137
	}

	[Token(Token = "0x170004DC")]
	public virtual string Name
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60023C6")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004DA")]
	public virtual Type ReflectedType
	{
		[Address(RVA = "0x13E7CB0", Offset = "0x13E6EB0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802105A0")]
		[Token(Token = "0x60023C4")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170004D6")]
	private RuntimeType ReflectedTypeInternal
	{
		[Address(RVA = "0x13E7C30", Offset = "0x13E6E30", Length = "0x7D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60023B8")]
		private get { } //Length: 125
	}

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60023D4")]
	public RuntimeFieldInfo() { }

	[Address(RVA = "0x13E6E60", Offset = "0x13E6060", Length = "0x1B7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentUICulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(TargetException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60023BC")]
	internal virtual void CheckConsistency(object target) { }

	[Address(RVA = "0x13E7020", Offset = "0x13E6220", Length = "0x93")]
	[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(BindingFlags), typeof(Binder), typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60023D1")]
	private void CheckGeneric() { }

	[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x60023BF")]
	public virtual FieldAttributes get_Attributes() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x60023B5")]
	internal BindingFlags get_BindingFlags() { }

	[Address(RVA = "0x13E7BC0", Offset = "0x13E6DC0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802105A0")]
	[Token(Token = "0x60023C5")]
	public virtual Type get_DeclaringType() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x60023C0")]
	public virtual RuntimeFieldHandle get_FieldHandle() { }

	[Address(RVA = "0x13E7BD0", Offset = "0x13E6DD0", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60023C2")]
	public virtual Type get_FieldType() { }

	[Address(RVA = "0x13E6580", Offset = "0x13E5780", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020E9B0")]
	[DeduplicatedMethod]
	[Token(Token = "0x60023D3")]
	internal static int get_metadata_token(RuntimeFieldInfo monoField) { }

	[Address(RVA = "0x13E6580", Offset = "0x13E5780", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020E9B0")]
	[DeduplicatedMethod]
	[Token(Token = "0x60023D2")]
	public virtual int get_MetadataToken() { }

	[Address(RVA = "0x13E73A0", Offset = "0x13E65A0", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60023B6")]
	public virtual Module get_Module() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60023C6")]
	public virtual string get_Name() { }

	[Address(RVA = "0x13E7CB0", Offset = "0x13E6EB0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802105A0")]
	[Token(Token = "0x60023C4")]
	public virtual Type get_ReflectedType() { }

	[Address(RVA = "0x13E7C30", Offset = "0x13E6E30", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60023B8")]
	private RuntimeType get_ReflectedTypeInternal() { }

	[Address(RVA = "0x13E7120", Offset = "0x13E6320", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
	[Token(Token = "0x60023C9")]
	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Address(RVA = "0x13E70C0", Offset = "0x13E62C0", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(bool)}, ReturnType = typeof(Object[]))]
	[Token(Token = "0x60023C8")]
	public virtual Object[] GetCustomAttributes(bool inherit) { }

	[Address(RVA = "0x13E7190", Offset = "0x13E6390", Length = "0x7D")]
	[CalledBy(Type = typeof(TypedReference), Member = "MakeTypedReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(FieldInfo[])}, ReturnType = typeof(TypedReference))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60023B7")]
	internal RuntimeType GetDeclaringTypeInternal() { }

	[Address(RVA = "0x13E7210", Offset = "0x13E6410", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210590")]
	[Token(Token = "0x60023CA")]
	internal virtual int GetFieldOffset() { }

	[Address(RVA = "0x13E7220", Offset = "0x13E6420", Length = "0x157")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MemberInfoSerializationHolder), Member = "GetSerializationInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(string), typeof(RuntimeType), typeof(string), typeof(string), typeof(MemberTypes), typeof(Type[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60023BA")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x13E7380", Offset = "0x13E6580", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802105A0")]
	[Token(Token = "0x60023C3")]
	private Type GetParentType(bool declaring) { }

	[Address(RVA = "0x13E7390", Offset = "0x13E6590", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802105C0")]
	[Token(Token = "0x60023D0")]
	public virtual object GetRawConstantValue() { }

	[Address(RVA = "0x13E73A0", Offset = "0x13E65A0", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60023B9")]
	internal RuntimeModule GetRuntimeModule() { }

	[Address(RVA = "0x13E7440", Offset = "0x13E6640", Length = "0x1A6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(FieldInfo), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(FieldInfo), Member = "get_IsLiteral", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeFieldInfo), Member = "CheckGeneric", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210720")]
	[Calls(Type = typeof(TargetException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60023CC")]
	public virtual object GetValue(object obj) { }

	[Address(RVA = "0x13E7430", Offset = "0x13E6630", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210720")]
	[DeduplicatedMethod]
	[Token(Token = "0x60023CB")]
	private object GetValueInternal(object obj) { }

	[Address(RVA = "0x13E75F0", Offset = "0x13E67F0", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60023C7")]
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	[Address(RVA = "0x13E7660", Offset = "0x13E6860", Length = "0x5")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9F0")]
	[DeduplicatedMethod]
	[Token(Token = "0x60023C1")]
	private Type ResolveType() { }

	[Address(RVA = "0x13E7810", Offset = "0x13E6A10", Length = "0x2DA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210740")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(FieldAccessException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(RuntimeType), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Binder), typeof(CultureInfo), typeof(BindingFlags)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(TargetException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeFieldInfo), Member = "CheckGeneric", ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "get_DefaultBinder", ReturnType = typeof(Binder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FieldInfo), Member = "get_IsLiteral", ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(FieldInfo), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60023CF")]
	public virtual void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	[Address(RVA = "0x13E7670", Offset = "0x13E6870", Length = "0x181")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TypedReference), Member = "get_IsNull", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeFieldHandle), Member = "SetValueDirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeFieldInfo), typeof(RuntimeType), typeof(Void*), typeof(object), typeof(RuntimeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x60023BE")]
	public virtual void SetValueDirect(TypedReference obj, object value) { }

	[Address(RVA = "0x13E7800", Offset = "0x13E6A00", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210740")]
	[Token(Token = "0x60023CE")]
	private static void SetValueInternal(FieldInfo fi, object obj, object value) { }

	[Address(RVA = "0x13E7AF0", Offset = "0x13E6CF0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60023CD")]
	public virtual string ToString() { }

	[Address(RVA = "0x13E7430", Offset = "0x13E6630", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210720")]
	[DeduplicatedMethod]
	[Token(Token = "0x60023BB")]
	internal virtual object UnsafeGetValue(object obj) { }

	[Address(RVA = "0x13E7B50", Offset = "0x13E6D50", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x60023BD")]
	internal virtual void UnsafeSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

}

