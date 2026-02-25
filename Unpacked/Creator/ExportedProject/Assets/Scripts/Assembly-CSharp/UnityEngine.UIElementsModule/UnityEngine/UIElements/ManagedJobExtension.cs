namespace UnityEngine.UIElements;

[Extension]
[Token(Token = "0x2000292")]
internal static class ManagedJobExtension
{

	[Address(RVA = "0x6FE080", Offset = "0x6FD280", Length = "0xFD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x60011E5")]
	public static JobHandle ScheduleOrRunJob(T jobData, int arrayLength, int innerloopBatchCount, JobHandle dependsOn = null) { }

}

