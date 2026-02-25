namespace UnityEngine.Windows.Speech;

[Token(Token = "0x2000193")]
public static class PhraseRecognitionSystem
{
	[Token(Token = "0x2000194")]
	internal sealed class ErrorDelegate : MulticastDelegate
	{

		[Address(RVA = "0x38DDA0", Offset = "0x38CFA0", Length = "0xA6")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BA5")]
		public ErrorDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BA6")]
		public override void Invoke(SpeechError errorCode) { }

	}

	[Token(Token = "0x2000195")]
	internal sealed class StatusDelegate : MulticastDelegate
	{

		[Address(RVA = "0x38DDA0", Offset = "0x38CFA0", Length = "0xA6")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BA7")]
		public StatusDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BA8")]
		public override void Invoke(SpeechSystemStatus status) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x40005FA")]
	private static ErrorDelegate OnError; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x40005FB")]
	private static StatusDelegate OnStatusChanged; //Field offset: 0x8

	[Address(RVA = "0x1969940", Offset = "0x1968B40", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000BA3")]
	private static void PhraseRecognitionSystem_InvokeErrorEvent(SpeechError errorCode) { }

	[Address(RVA = "0x19699A0", Offset = "0x1968BA0", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000BA4")]
	private static void PhraseRecognitionSystem_InvokeStatusChangedEvent(SpeechSystemStatus status) { }

}

