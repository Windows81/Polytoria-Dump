namespace UnityEngine;

[Token(Token = "0x2000004")]
internal class GlobalJavaObjectRef
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000002")]
	private bool m_disposed; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000003")]
	protected IntPtr m_jobject; //Field offset: 0x18

	[Address(RVA = "0x190C710", Offset = "0x190B910", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000005")]
	public GlobalJavaObjectRef(IntPtr jobject) { }

	[Address(RVA = "0x190C630", Offset = "0x190B830", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000008")]
	public void Dispose() { }

	[Address(RVA = "0x190C680", Offset = "0x190B880", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000006")]
	protected virtual void Finalize() { }

	[Address(RVA = "0xE66C30", Offset = "0xE65E30", Length = "0x17")]
	[CallerCount(Count = 30)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000007")]
	public static IntPtr op_Implicit(GlobalJavaObjectRef obj) { }

}

