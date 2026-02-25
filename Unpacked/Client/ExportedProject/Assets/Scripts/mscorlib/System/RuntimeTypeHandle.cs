namespace System;

[ComVisible(True)]
[Token(Token = "0x20001C2")]
public struct RuntimeTypeHandle : ISerializable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000736")]
	private IntPtr value; //Field offset: 0x0

	[Token(Token = "0x1700016C")]
	public IntPtr Value
	{
		[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
		[CallerCount(Count = 140)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FB9")]
		 get { } //Length: 4
	}

	[Address(RVA = "0xC498F0", Offset = "0xC48AF0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FB6")]
	internal RuntimeTypeHandle(IntPtr val) { }

	[Address(RVA = "0x14FE4F0", Offset = "0x14FD6F0", Length = "0x1A")]
	[CalledBy(Type = typeof(RuntimeType), Member = "get_TypeHandle", ReturnType = typeof(RuntimeTypeHandle))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodsByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimeMethodInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetConstructors_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(RuntimeType)}, ReturnType = typeof(RuntimeConstructorInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetPropertiesByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimePropertyInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetFields_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimeFieldInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetEvents_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimeEventInfo[]))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000FB7")]
	internal RuntimeTypeHandle(RuntimeType type) { }

	[Address(RVA = "0x14FE350", Offset = "0x14FD550", Length = "0x191")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FB8")]
	private RuntimeTypeHandle(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x14FDAE0", Offset = "0x14FCCE0", Length = "0xE")]
	[CalledBy(Type = typeof(RuntimeType), Member = "IsAssignableFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D1E0")]
	[Token(Token = "0x6000FD7")]
	internal static bool CanCastTo(RuntimeType type, RuntimeType target) { }

	[Address(RVA = "0x14FDAF0", Offset = "0x14FCCF0", Length = "0xE1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214040")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6000FBB")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FB9")]
	public IntPtr get_Value() { }

	[Address(RVA = "0x14FDBE0", Offset = "0x14FCDE0", Length = "0x5")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetArrayRank", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021A660")]
	[Token(Token = "0x6000FD1")]
	internal static int GetArrayRank(RuntimeType type) { }

	[Address(RVA = "0x14FDBF0", Offset = "0x14FCDF0", Length = "0x5")]
	[CalledBy(Type = typeof(RuntimeType), Member = "get_Assembly", ReturnType = typeof(Assembly))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetRuntimeAssembly", ReturnType = typeof(RuntimeAssembly))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021A680")]
	[Token(Token = "0x6000FD2")]
	internal static RuntimeAssembly GetAssembly(RuntimeType type) { }

	[Address(RVA = "0x14FDC00", Offset = "0x14FCE00", Length = "0x5")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetAttributeFlagsImpl", ReturnType = typeof(TypeAttributes))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021A6B0")]
	[Token(Token = "0x6000FBD")]
	internal static TypeAttributes GetAttributes(RuntimeType type) { }

	[Address(RVA = "0x14FDC10", Offset = "0x14FCE10", Length = "0x5")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetBaseType", ReturnType = typeof(RuntimeType))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021A6D0")]
	[Token(Token = "0x6000FD6")]
	internal static RuntimeType GetBaseType(RuntimeType type) { }

	[Address(RVA = "0x14FDC20", Offset = "0x14FCE20", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021A930")]
	[Token(Token = "0x6000FC8")]
	internal static CorElementType GetCorElementType(RuntimeType type) { }

	[Address(RVA = "0x14FDC30", Offset = "0x14FCE30", Length = "0x5")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetElementType", ReturnType = typeof(Type))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021AB30")]
	[Token(Token = "0x6000FD3")]
	internal static RuntimeType GetElementType(RuntimeType type) { }

	[Address(RVA = "0x14FDC40", Offset = "0x14FCE40", Length = "0x5")]
	[CalledBy(Type = typeof(RuntimeType), Member = "get_GenericParameterAttributes", ReturnType = typeof(GenericParameterAttributes))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetGenericParameterConstraints", ReturnType = typeof(Type[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetGenericParameterAttributes", ReturnType = typeof(GenericParameterAttributes))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021B080")]
	[Token(Token = "0x6000FDA")]
	internal static IntPtr GetGenericParameterInfo(RuntimeType type) { }

	[Address(RVA = "0x14FDC50", Offset = "0x14FCE50", Length = "0x5")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021B110")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FC1")]
	internal static Type GetGenericTypeDefinition(RuntimeType type) { }

	[Address(RVA = "0x14FDC50", Offset = "0x14FCE50", Length = "0x5")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021B110")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FC0")]
	private static Type GetGenericTypeDefinition_impl(RuntimeType type) { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FBC")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x14FDC60", Offset = "0x14FCE60", Length = "0x5")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021B410")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FBE")]
	private static int GetMetadataToken(RuntimeType type) { }

	[Address(RVA = "0x14FDC70", Offset = "0x14FCE70", Length = "0x5")]
	[CalledBy(Type = typeof(RuntimeType), Member = "get_Module", ReturnType = typeof(Module))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetRuntimeModule", ReturnType = typeof(RuntimeModule))]
	[CalledBy(Type = typeof(RuntimeConstructorInfo), Member = "get_Module", ReturnType = typeof(Module))]
	[CalledBy(Type = typeof(RuntimeConstructorInfo), Member = "GetRuntimeModule", ReturnType = typeof(RuntimeModule))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021B6B0")]
	[Token(Token = "0x6000FD4")]
	internal static RuntimeModule GetModule(RuntimeType type) { }

	[Address(RVA = "0x14FDC80", Offset = "0x14FCE80", Length = "0x173")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(RuntimeTypeHandle))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000FBA")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x14FDC60", Offset = "0x14FCE60", Length = "0x5")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021B410")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FBF")]
	internal static int GetToken(RuntimeType type) { }

	[Address(RVA = "0x14FDE00", Offset = "0x14FD000", Length = "0x33D")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(RuntimeType))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180188FF0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(TypeLoadException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(Assembly), Member = "ReflectionOnlyLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Assembly))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021CB60")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000FDE")]
	internal static RuntimeType GetTypeByName(string typeName, bool throwOnError, bool ignoreCase, bool reflectionOnly, ref StackCrawlMark stackMark, bool loadTypeFromPartialName) { }

	[Address(RVA = "0x14FE140", Offset = "0x14FD340", Length = "0x28")]
	[CalledBy(Type = typeof(RuntimeType), Member = "HasElementTypeImpl", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021A930")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000FC7")]
	internal static bool HasElementType(RuntimeType type) { }

	[Address(RVA = "0x14FE170", Offset = "0x14FD370", Length = "0x5")]
	[CalledBy(Type = typeof(RuntimeType), Member = "get_IsGenericType", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021BE00")]
	[Token(Token = "0x6000FC9")]
	internal static bool HasInstantiation(RuntimeType type) { }

	[Address(RVA = "0x14FE180", Offset = "0x14FD380", Length = "0x5")]
	[CalledBy(Type = typeof(RuntimeHelpers), Member = "IsReferenceOrContainsReferences", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021BE60")]
	[Token(Token = "0x6000FCC")]
	internal static bool HasReferences(RuntimeType type) { }

	[Address(RVA = "0x14FE510", Offset = "0x14FD710", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021CB60")]
	[Token(Token = "0x6000FDD")]
	private static RuntimeType internal_from_name(string name, ref StackCrawlMark stackMark, Assembly callerAssembly, bool throwOnError, bool ignoreCase, bool reflectionOnly) { }

	[Address(RVA = "0x14FE530", Offset = "0x14FD730", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021CD70")]
	[Token(Token = "0x6000FDC")]
	internal static bool is_subclass_of(IntPtr childType, IntPtr baseType) { }

	[Address(RVA = "0x14FE190", Offset = "0x14FD390", Length = "0x1E")]
	[CalledBy(Type = typeof(RuntimeType), Member = "IsArrayImpl", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021A930")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000FC5")]
	internal static bool IsArray(RuntimeType type) { }

	[Address(RVA = "0x14FE1B0", Offset = "0x14FD3B0", Length = "0x13")]
	[CalledBy(Type = typeof(RuntimeType), Member = "IsByRefImpl", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021A930")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000FC3")]
	internal static bool IsByRef(RuntimeType type) { }

	[Address(RVA = "0x12F3760", Offset = "0x12F2960", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_gc_has_strict_wbarriers")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FCA")]
	internal static bool IsComObject(RuntimeType type) { }

	[Address(RVA = "0x14FE1D0", Offset = "0x14FD3D0", Length = "0xC")]
	[CalledBy(Type = typeof(RuntimeType), Member = "IsCOMObjectImpl", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_gc_has_strict_wbarriers")]
	[Token(Token = "0x6000FCD")]
	internal static bool IsComObject(RuntimeType type, bool isGenericCOM) { }

	[Address(RVA = "0x14FE1E0", Offset = "0x14FD3E0", Length = "0x7D")]
	[CalledBy(Type = typeof(RuntimeType), Member = "IsContextfulImpl", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FCE")]
	internal static bool IsContextful(RuntimeType type) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FCF")]
	internal static bool IsEquivalentTo(RuntimeType rtType1, RuntimeType rtType2) { }

	[Address(RVA = "0x14FE260", Offset = "0x14FD460", Length = "0x5")]
	[CalledBy(Type = typeof(RuntimeType), Member = "get_IsGenericTypeDefinition", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021BFC0")]
	[Token(Token = "0x6000FD9")]
	internal static bool IsGenericTypeDefinition(RuntimeType type) { }

	[Address(RVA = "0x14FE270", Offset = "0x14FD470", Length = "0x5")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetBaseType", ReturnType = typeof(RuntimeType))]
	[CalledBy(Type = typeof(RuntimeType), Member = "get_IsGenericParameter", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021BFF0")]
	[Token(Token = "0x6000FD5")]
	internal static bool IsGenericVariable(RuntimeType type) { }

	[Address(RVA = "0x14FE280", Offset = "0x14FD480", Length = "0x5")]
	[CalledBy(Type = typeof(RuntimeType), Member = "IsInstanceOfType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021C010")]
	[Token(Token = "0x6000FCB")]
	internal static bool IsInstanceOfType(RuntimeType type, object o) { }

	[Address(RVA = "0x14FE290", Offset = "0x14FD490", Length = "0x1F")]
	[CalledBy(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "get_Attributes", ReturnType = typeof(TypeAttributes))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000FD0")]
	internal static bool IsInterface(RuntimeType type) { }

	[Address(RVA = "0x14FE2B0", Offset = "0x14FD4B0", Length = "0x13")]
	[CalledBy(Type = typeof(RuntimeType), Member = "IsPointerImpl", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021A930")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000FC4")]
	internal static bool IsPointer(RuntimeType type) { }

	[Address(RVA = "0x14FE2D0", Offset = "0x14FD4D0", Length = "0x26")]
	[CalledBy(Type = typeof(RuntimeType), Member = "IsPrimitiveImpl", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021A930")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000FC2")]
	internal static bool IsPrimitive(RuntimeType type) { }

	[Address(RVA = "0x14FE300", Offset = "0x14FD500", Length = "0x24")]
	[CalledBy(Type = typeof(RuntimeType), Member = "IsSubclassOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021CD70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000FDB")]
	internal static bool IsSubclassOf(RuntimeType childType, RuntimeType baseType) { }

	[Address(RVA = "0x14FE330", Offset = "0x14FD530", Length = "0x13")]
	[CalledBy(Type = typeof(RuntimeType), Member = "get_IsSzArray", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021A930")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000FC6")]
	internal static bool IsSzArray(RuntimeType type) { }

	[Address(RVA = "0x14FE540", Offset = "0x14FD740", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D1E0")]
	[Token(Token = "0x6000FD8")]
	private static bool type_is_assignable_from(Type a, Type b) { }

}

