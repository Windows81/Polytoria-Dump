namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x2000396")]
internal class ArgInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E8F")]
	private Int32[] _paramMap; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E90")]
	private int _inoutArgCount; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000E91")]
	private MethodBase _method; //Field offset: 0x20

	[Address(RVA = "0x1378570", Offset = "0x1377770", Length = "0x1E4")]
	[CalledBy(Type = typeof(MethodResponse), Member = "get_OutArgs", ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(ReturnMessage), Member = "get_OutArgs", ReturnType = typeof(Object[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParameterInfo), Member = "get_IsOut", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6001BAF")]
	public ArgInfo(MethodBase method, ArgInfoType type) { }

	[Address(RVA = "0x1378440", Offset = "0x1377640", Length = "0x122")]
	[CalledBy(Type = typeof(MethodResponse), Member = "get_OutArgs", ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(ReturnMessage), Member = "get_OutArgs", ReturnType = typeof(Object[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001BB0")]
	public Object[] GetInOutArgs(Object[] args) { }

}

