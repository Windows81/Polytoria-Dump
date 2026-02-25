namespace UnityEngine;

[NativeHeader("Runtime/GameCode/AsyncInstantiate/AsyncInstantiateOperation.h")]
[RequiredByNativeCode]
[Token(Token = "0x200011D")]
public class AsyncInstantiateOperation : AsyncOperation
{
	[Token(Token = "0x400050A")]
	internal static CancellationTokenSource s_GlobalCancellation; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400050B")]
	internal Object[] m_Result; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400050C")]
	private CancellationToken m_CancellationToken; //Field offset: 0x28

	[Address(RVA = "0x195B1F0", Offset = "0x195A3F0", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CancellationTokenSource), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60008BD")]
	private static AsyncInstantiateOperation() { }

	[Address(RVA = "0x195B140", Offset = "0x195A340", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60008BC")]
	internal override Object[] CreateResultArray(int size) { }

	[Address(RVA = "0x195B1A0", Offset = "0x195A3A0", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[RequiredByNativeCode(GenerateProxy = True)]
	[Token(Token = "0x60008BB")]
	private bool IsCancellationRequested() { }

}

