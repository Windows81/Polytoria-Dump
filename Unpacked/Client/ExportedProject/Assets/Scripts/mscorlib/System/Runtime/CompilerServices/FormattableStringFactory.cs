namespace System.Runtime.CompilerServices;

[Token(Token = "0x200046F")]
public static class FormattableStringFactory
{
	[Token(Token = "0x2000470")]
	private sealed class ConcreteFormattableString : FormattableString
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001252")]
		private readonly string _format; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001253")]
		private readonly Object[] _arguments; //Field offset: 0x18

		[Token(Token = "0x170003FB")]
		public virtual int ArgumentCount
		{
			[Address(RVA = "0x3B6AD0", Offset = "0x3B5CD0", Length = "0x1A")]
			[CallerCount(Count = 55)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6002028")]
			 get { } //Length: 26
		}

		[Token(Token = "0x170003FA")]
		public virtual string Format
		{
			[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
			[CallerCount(Count = 50)]
			[DeduplicatedMethod]
			[Token(Token = "0x6002026")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x2FEC80", Offset = "0x2FDE80", Length = "0x4E")]
		[CallerCount(Count = 19)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002025")]
		internal ConcreteFormattableString(string format, Object[] arguments) { }

		[Address(RVA = "0x3B6AD0", Offset = "0x3B5CD0", Length = "0x1A")]
		[CallerCount(Count = 55)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002028")]
		public virtual int get_ArgumentCount() { }

		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002026")]
		public virtual string get_Format() { }

		[Address(RVA = "0x1391480", Offset = "0x1390680", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002029")]
		public virtual object GetArgument(int index) { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002027")]
		public virtual Object[] GetArguments() { }

		[Address(RVA = "0x13B66A0", Offset = "0x13B58A0", Length = "0x16")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
		[Token(Token = "0x600202A")]
		public virtual string ToString(IFormatProvider formatProvider) { }

	}


	[Address(RVA = "0x13B9B30", Offset = "0x13B8D30", Length = "0x11C")]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "BeginGetRequestStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "EnsureFtpWebResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "FinishRequestStage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.FtpWebRequest+RequestStage"}, ReturnType = "System.Net.FtpWebRequest+RequestStage")]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "AsyncRequestCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "SyncRequestCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "AttemptedRecovery", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "GetResponse", ReturnType = "System.Net.WebResponse")]
	[CalledBy(Type = "System.Net.FtpDataStream", Member = "System.Net.ICloseEx.CloseEx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.CloseExState"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "BeginGetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = "System.Net.FtpControlStream", Member = "PipelineCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.CommandStream+PipelineEntry", "System.Net.ResponseDescription", typeof(bool), typeof(Stream&)}, ReturnType = "System.Net.CommandStream+PipelineInstruction")]
	[CalledBy(Type = "System.Net.CommandStream", Member = "ReceiveCommandResponseCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.ReceiveState", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.CommandStream", Member = "ContinueCommandPipeline", ReturnType = typeof(Stream))]
	[CalledBy(Type = "System.Net.ContextAwareResult", Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ContextAwareResult", Member = "CaptureOrComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.IO.WaitForChangedResult", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.WatcherChangeTypes", typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.FtpControlStream", Member = "CheckValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.ResponseDescription", typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002024")]
	public static FormattableString Create(string format, Object[] arguments) { }

}

