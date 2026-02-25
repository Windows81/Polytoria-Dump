namespace System.IO;

[Token(Token = "0x20001E1")]
public struct WaitForChangedResult
{
	[Token(Token = "0x400071E")]
	internal static readonly WaitForChangedResult TimedOutResult; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400071F")]
	private WatcherChangeTypes <ChangeType>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000720")]
	private string <Name>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000721")]
	private string <OldName>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000722")]
	private bool <TimedOut>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000258")]
	public WatcherChangeTypes ChangeType
	{
		[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C17")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000259")]
	public string Name
	{
		[Address(RVA = "0x344920", Offset = "0x343B20", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C18")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700025A")]
	public string OldName
	{
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C19")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700025B")]
	public bool TimedOut
	{
		[Address(RVA = "0x2FE4F0", Offset = "0x2FD6F0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C1A")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x17CC980", Offset = "0x17CBB80", Length = "0xC9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000C1B")]
	private static WaitForChangedResult() { }

	[Address(RVA = "0x17CCA50", Offset = "0x17CBC50", Length = "0x908")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(NetEventSource), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(FormattableString), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FormattableStringFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(FormattableString))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FtpWebRequest), Member = "FinishRequestStage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.FtpWebRequest+RequestStage"}, ReturnType = "System.Net.FtpWebRequest+RequestStage")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(LazyAsyncResult), Member = "ProtectedInvokeCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LazyAsyncResult), Member = "WaitForCompletion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(NetEventSource), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(FormattableString), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_RequestAbortedException", ReturnType = typeof(WebException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CommandStream), Member = "CheckContinuePipeline", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000C16")]
	internal WaitForChangedResult(WatcherChangeTypes changeType, string name, string oldName, bool timedOut) { }

	[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C17")]
	public void set_ChangeType(WatcherChangeTypes value) { }

	[Address(RVA = "0x344920", Offset = "0x343B20", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C18")]
	public void set_Name(string value) { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C19")]
	public void set_OldName(string value) { }

	[Address(RVA = "0x2FE4F0", Offset = "0x2FD6F0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C1A")]
	public void set_TimedOut(bool value) { }

}

