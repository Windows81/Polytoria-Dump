namespace System.Runtime.ConstrainedExecution;

[Token(Token = "0x200045F")]
public abstract class CriticalFinalizerObject
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002002")]
	protected CriticalFinalizerObject() { }

	[Address(RVA = "0x13B6EE0", Offset = "0x13B60E0", Length = "0x32")]
	[CalledBy(Type = typeof(Gen2GcCallback), Member = "Finalize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Thread), Member = "Finalize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InternalThread), Member = "Finalize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SafeHandle), Member = "Finalize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "Finalize", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002003")]
	protected virtual void Finalize() { }

}

