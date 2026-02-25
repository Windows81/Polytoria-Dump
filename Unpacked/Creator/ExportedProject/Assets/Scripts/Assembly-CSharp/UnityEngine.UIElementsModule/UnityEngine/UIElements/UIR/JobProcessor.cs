namespace UnityEngine.UIElements.UIR;

[NativeHeader("Modules/UIElements/Core/Native/Renderer/UIRendererJobProcessor.h")]
[Token(Token = "0x200053E")]
internal static class JobProcessor
{

	[Address(RVA = "0x1B665F0", Offset = "0x1B657F0", Length = "0x5A")]
	[CalledBy(Type = typeof(JobManager), Member = "CompleteConvertMeshJobs", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60025F4")]
	internal static JobHandle ScheduleConvertMeshJobs(IntPtr buffer, int jobCount) { }

	[Address(RVA = "0x1B665A0", Offset = "0x1B657A0", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60025F7")]
	private static void ScheduleConvertMeshJobs_Injected(IntPtr buffer, int jobCount, out JobHandle ret) { }

	[Address(RVA = "0x1B666A0", Offset = "0x1B658A0", Length = "0x5A")]
	[CalledBy(Type = typeof(JobManager), Member = "CompleteCopyMeshJobs", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60025F5")]
	internal static JobHandle ScheduleCopyMeshJobs(IntPtr buffer, int jobCount) { }

	[Address(RVA = "0x1B66650", Offset = "0x1B65850", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60025F8")]
	private static void ScheduleCopyMeshJobs_Injected(IntPtr buffer, int jobCount, out JobHandle ret) { }

	[Address(RVA = "0x1B66750", Offset = "0x1B65950", Length = "0x5A")]
	[CalledBy(Type = typeof(JobManager), Member = "CompleteNudgeJobs", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60025F3")]
	internal static JobHandle ScheduleNudgeJobs(IntPtr buffer, int jobCount) { }

	[Address(RVA = "0x1B66700", Offset = "0x1B65900", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60025F6")]
	private static void ScheduleNudgeJobs_Injected(IntPtr buffer, int jobCount, out JobHandle ret) { }

}

