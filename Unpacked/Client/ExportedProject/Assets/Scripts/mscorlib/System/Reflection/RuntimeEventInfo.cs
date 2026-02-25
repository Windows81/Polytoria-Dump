namespace System.Reflection;

[Token(Token = "0x200050A")]
internal sealed class RuntimeEventInfo : EventInfo, ISerializable
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001470")]
	private IntPtr klass; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001471")]
	private IntPtr handle; //Field offset: 0x20

	[Token(Token = "0x170004CF")]
	public virtual EventAttributes Attributes
	{
		[Address(RVA = "0x13E6D10", Offset = "0x13E5F10", Length = "0x2E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210210")]
		[Token(Token = "0x60023A3")]
		 get { } //Length: 46
	}

	[Token(Token = "0x170004CD")]
	internal BindingFlags BindingFlags
	{
		[Address(RVA = "0x13E66A0", Offset = "0x13E58A0", Length = "0x16B")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210210")]
		[Calls(Type = typeof(MethodBase), Member = "get_IsPublic", ReturnType = typeof(bool))]
		[Calls(Type = typeof(RuntimeEventInfo), Member = "GetDeclaringTypeInternal", ReturnType = typeof(RuntimeType))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(MethodBase), Member = "get_IsStatic", ReturnType = typeof(bool))]
		[Calls(Type = typeof(RuntimeType), Member = "FilterPreCalculate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(BindingFlags))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600239D")]
		internal get { } //Length: 363
	}

	[Token(Token = "0x170004D0")]
	public virtual Type DeclaringType
	{
		[Address(RVA = "0x13E6D40", Offset = "0x13E5F40", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210210")]
		[Token(Token = "0x60023A7")]
		 get { } //Length: 47
	}

	[Token(Token = "0x170004D3")]
	public virtual int MetadataToken
	{
		[Address(RVA = "0x13E6580", Offset = "0x13E5780", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020E9B0")]
		[DeduplicatedMethod]
		[Token(Token = "0x60023AE")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004CC")]
	public virtual Module Module
	{
		[Address(RVA = "0x13E6BD0", Offset = "0x13E5DD0", Length = "0x23")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RuntimeEventInfo), Member = "GetDeclaringTypeInternal", ReturnType = typeof(RuntimeType))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600239C")]
		 get { } //Length: 35
	}

	[Token(Token = "0x170004D2")]
	public virtual string Name
	{
		[Address(RVA = "0x13E6D70", Offset = "0x13E5F70", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210210")]
		[Token(Token = "0x60023A9")]
		 get { } //Length: 47
	}

	[Token(Token = "0x170004D1")]
	public virtual Type ReflectedType
	{
		[Address(RVA = "0x13E6E20", Offset = "0x13E6020", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210210")]
		[Token(Token = "0x60023A8")]
		 get { } //Length: 47
	}

	[Token(Token = "0x170004CE")]
	private RuntimeType ReflectedTypeInternal
	{
		[Address(RVA = "0x13E6DA0", Offset = "0x13E5FA0", Length = "0x7D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600239F")]
		private get { } //Length: 125
	}

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60023B0")]
	public RuntimeEventInfo() { }

	[Address(RVA = "0x13E6D10", Offset = "0x13E5F10", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210210")]
	[Token(Token = "0x60023A3")]
	public virtual EventAttributes get_Attributes() { }

	[Address(RVA = "0x13E66A0", Offset = "0x13E58A0", Length = "0x16B")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210210")]
	[Calls(Type = typeof(MethodBase), Member = "get_IsPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeEventInfo), Member = "GetDeclaringTypeInternal", ReturnType = typeof(RuntimeType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MethodBase), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeType), Member = "FilterPreCalculate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(BindingFlags))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600239D")]
	internal BindingFlags get_BindingFlags() { }

	[Address(RVA = "0x13E6D40", Offset = "0x13E5F40", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210210")]
	[Token(Token = "0x60023A7")]
	public virtual Type get_DeclaringType() { }

	[Address(RVA = "0x13E6E50", Offset = "0x13E6050", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210210")]
	[Token(Token = "0x600239A")]
	private static void get_event_info(RuntimeEventInfo ev, out MonoEventInfo info) { }

	[Address(RVA = "0x13E6580", Offset = "0x13E5780", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020E9B0")]
	[DeduplicatedMethod]
	[Token(Token = "0x60023AF")]
	internal static int get_metadata_token(RuntimeEventInfo monoEvent) { }

	[Address(RVA = "0x13E6580", Offset = "0x13E5780", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020E9B0")]
	[DeduplicatedMethod]
	[Token(Token = "0x60023AE")]
	public virtual int get_MetadataToken() { }

	[Address(RVA = "0x13E6BD0", Offset = "0x13E5DD0", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeEventInfo), Member = "GetDeclaringTypeInternal", ReturnType = typeof(RuntimeType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600239C")]
	public virtual Module get_Module() { }

	[Address(RVA = "0x13E6D70", Offset = "0x13E5F70", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210210")]
	[Token(Token = "0x60023A9")]
	public virtual string get_Name() { }

	[Address(RVA = "0x13E6E20", Offset = "0x13E6020", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210210")]
	[Token(Token = "0x60023A8")]
	public virtual Type get_ReflectedType() { }

	[Address(RVA = "0x13E6DA0", Offset = "0x13E5FA0", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600239F")]
	private RuntimeType get_ReflectedTypeInternal() { }

	[Address(RVA = "0x13E6620", Offset = "0x13E5820", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210210")]
	[Calls(Type = typeof(MethodBase), Member = "get_IsPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60023A4")]
	public virtual MethodInfo GetAddMethod(bool nonPublic) { }

	[Address(RVA = "0x13E66A0", Offset = "0x13E58A0", Length = "0x16B")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210210")]
	[Calls(Type = typeof(MethodBase), Member = "get_IsPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeEventInfo), Member = "GetDeclaringTypeInternal", ReturnType = typeof(RuntimeType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MethodBase), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeType), Member = "FilterPreCalculate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(BindingFlags))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60023A2")]
	internal BindingFlags GetBindingFlags() { }

	[Address(RVA = "0x13E6810", Offset = "0x13E5A10", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
	[Token(Token = "0x60023AD")]
	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Address(RVA = "0x13E6880", Offset = "0x13E5A80", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(bool)}, ReturnType = typeof(Object[]))]
	[Token(Token = "0x60023AC")]
	public virtual Object[] GetCustomAttributes(bool inherit) { }

	[Address(RVA = "0x13E68E0", Offset = "0x13E5AE0", Length = "0x7D")]
	[CalledBy(Type = typeof(RuntimeEventInfo), Member = "get_Module", ReturnType = typeof(Module))]
	[CalledBy(Type = typeof(RuntimeEventInfo), Member = "get_BindingFlags", ReturnType = typeof(BindingFlags))]
	[CalledBy(Type = typeof(RuntimeEventInfo), Member = "GetRuntimeModule", ReturnType = typeof(RuntimeModule))]
	[CalledBy(Type = typeof(RuntimeEventInfo), Member = "GetBindingFlags", ReturnType = typeof(BindingFlags))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600239E")]
	internal RuntimeType GetDeclaringTypeInternal() { }

	[Address(RVA = "0x13E6960", Offset = "0x13E5B60", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210210")]
	[Token(Token = "0x600239B")]
	internal static MonoEventInfo GetEventInfo(RuntimeEventInfo ev) { }

	[Address(RVA = "0x13E69A0", Offset = "0x13E5BA0", Length = "0x12C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MemberInfoSerializationHolder), Member = "GetSerializationInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(string), typeof(RuntimeType), typeof(string), typeof(string), typeof(MemberTypes), typeof(Type[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60023A1")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x13E6AD0", Offset = "0x13E5CD0", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210210")]
	[Calls(Type = typeof(MethodBase), Member = "get_IsPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60023A5")]
	public virtual MethodInfo GetRaiseMethod(bool nonPublic) { }

	[Address(RVA = "0x13E6B50", Offset = "0x13E5D50", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210210")]
	[Calls(Type = typeof(MethodBase), Member = "get_IsPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60023A6")]
	public virtual MethodInfo GetRemoveMethod(bool nonPublic) { }

	[Address(RVA = "0x13E6BD0", Offset = "0x13E5DD0", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeEventInfo), Member = "GetDeclaringTypeInternal", ReturnType = typeof(RuntimeType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60023A0")]
	internal RuntimeModule GetRuntimeModule() { }

	[Address(RVA = "0x13E6C00", Offset = "0x13E5E00", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60023AB")]
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	[Address(RVA = "0x13E6C70", Offset = "0x13E5E70", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60023AA")]
	public virtual string ToString() { }

}

