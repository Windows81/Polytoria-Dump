namespace Mono;

[Token(Token = "0x2000033")]
internal struct RuntimeGenericParamInfoHandle
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400010F")]
	private GenericParamInfo* value; //Field offset: 0x0

	[Token(Token = "0x17000008")]
	internal GenericParameterAttributes Attributes
	{
		[Address(RVA = "0x12DDBC0", Offset = "0x12DCDC0", Length = "0x1A")]
		[CalledBy(Type = typeof(RuntimeType), Member = "get_GenericParameterAttributes", ReturnType = typeof(GenericParameterAttributes))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetGenericParameterAttributes", ReturnType = typeof(GenericParameterAttributes))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600005E")]
		internal get { } //Length: 26
	}

	[Token(Token = "0x17000007")]
	internal Type[] Constraints
	{
		[Address(RVA = "0x12DDBE0", Offset = "0x12DCDE0", Length = "0x7")]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetGenericParameterConstraints", ReturnType = typeof(Type[]))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(RuntimeGenericParamInfoHandle), Member = "GetConstraints", ReturnType = typeof(Type[]))]
		[Token(Token = "0x600005D")]
		internal get { } //Length: 7
	}

	[Address(RVA = "0x9E2BC0", Offset = "0x9E1DC0", Length = "0x1F")]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600005C")]
	internal RuntimeGenericParamInfoHandle(IntPtr ptr) { }

	[Address(RVA = "0x12DDBC0", Offset = "0x12DCDC0", Length = "0x1A")]
	[CalledBy(Type = typeof(RuntimeType), Member = "get_GenericParameterAttributes", ReturnType = typeof(GenericParameterAttributes))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetGenericParameterAttributes", ReturnType = typeof(GenericParameterAttributes))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600005E")]
	internal GenericParameterAttributes get_Attributes() { }

	[Address(RVA = "0x12DDBE0", Offset = "0x12DCDE0", Length = "0x7")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetGenericParameterConstraints", ReturnType = typeof(Type[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeGenericParamInfoHandle), Member = "GetConstraints", ReturnType = typeof(Type[]))]
	[Token(Token = "0x600005D")]
	internal Type[] get_Constraints() { }

	[Address(RVA = "0x12DDA80", Offset = "0x12DCC80", Length = "0x13D")]
	[CalledBy(Type = typeof(RuntimeGenericParamInfoHandle), Member = "get_Constraints", ReturnType = typeof(Type[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_type")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600005F")]
	private Type[] GetConstraints() { }

	[Address(RVA = "0x12DDA50", Offset = "0x12DCC50", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000060")]
	private int GetConstraintsCount() { }

}

