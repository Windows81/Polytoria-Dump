namespace UnityEngine;

[NativeHeader("Runtime/Mono/Coroutine.h")]
[RequiredByNativeCode]
[Token(Token = "0x200013D")]
public sealed class Coroutine : YieldInstruction
{
	[Token(Token = "0x200013E")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x7CE590", Offset = "0x7CD790", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600093C")]
		public static IntPtr ConvertToNative(Coroutine coroutine) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000549")]
	internal IntPtr m_Ptr; //Field offset: 0x10

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000939")]
	private Coroutine() { }

	[Address(RVA = "0x195EFF0", Offset = "0x195E1F0", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600093A")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x195F070", Offset = "0x195E270", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("Coroutine::CleanupCoroutineGC", True)]
	[Token(Token = "0x600093B")]
	private static void ReleaseCoroutine(IntPtr ptr) { }

}

