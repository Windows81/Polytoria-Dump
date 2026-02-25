namespace System;

[Token(Token = "0x200015A")]
internal static class NotImplemented
{

	[Token(Token = "0x17000104")]
	internal static Exception ByDesign
	{
		[Address(RVA = "0x14BABF0", Offset = "0x14B9DF0", Length = "0x44")]
		[CalledBy(Type = typeof(Module), Member = "get_ModuleVersionId", ReturnType = typeof(Guid))]
		[CalledBy(Type = typeof(Module), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Module), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
		[CalledBy(Type = typeof(Module), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Module), Member = "IsResource", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Module), Member = "get_ScopeName", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Module), Member = "get_Assembly", ReturnType = typeof(Assembly))]
		[CalledBy(Type = typeof(MethodInfo), Member = "get_ReturnType", ReturnType = typeof(Type))]
		[CalledBy(Type = typeof(MethodInfo), Member = "get_ReturnParameter", ReturnType = typeof(ParameterInfo))]
		[CalledBy(Type = typeof(MethodBase), Member = "get_IsSecurityCritical", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(MemberInfo), Member = "get_Module", ReturnType = typeof(Module))]
		[CalledBy(Type = typeof(Type), Member = "GetEnumValues", ReturnType = typeof(Array))]
		[CalledBy(Type = typeof(Type), Member = "get_IsSZArray", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Type), Member = "get_IsConstructedGenericType", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ParameterInfo), Member = "get_DefaultValue", ReturnType = typeof(object))]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Token(Token = "0x6000BF3")]
		internal get { } //Length: 68
	}

	[Address(RVA = "0x14BABF0", Offset = "0x14B9DF0", Length = "0x44")]
	[CalledBy(Type = typeof(ParameterInfo), Member = "get_DefaultValue", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Type), Member = "get_IsConstructedGenericType", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Type), Member = "get_IsSZArray", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Type), Member = "GetEnumValues", ReturnType = typeof(Array))]
	[CalledBy(Type = typeof(MemberInfo), Member = "get_Module", ReturnType = typeof(Module))]
	[CalledBy(Type = typeof(MethodInfo), Member = "get_ReturnParameter", ReturnType = typeof(ParameterInfo))]
	[CalledBy(Type = typeof(MethodInfo), Member = "get_ReturnType", ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(MethodBase), Member = "get_IsSecurityCritical", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Module), Member = "get_ScopeName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Module), Member = "IsResource", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Module), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Module), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(Module), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Module), Member = "get_ModuleVersionId", ReturnType = typeof(Guid))]
	[CalledBy(Type = typeof(Module), Member = "get_Assembly", ReturnType = typeof(Assembly))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000BF3")]
	internal static Exception get_ByDesign() { }

}

