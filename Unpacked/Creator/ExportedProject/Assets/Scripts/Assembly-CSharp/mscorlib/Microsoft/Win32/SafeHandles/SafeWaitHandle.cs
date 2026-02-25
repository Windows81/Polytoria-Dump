namespace Microsoft.Win32.SafeHandles;

[Token(Token = "0x2000087")]
public sealed class SafeWaitHandle : SafeHandleZeroOrMinusOneIsInvalid
{

	[Address(RVA = "0x12FCD90", Offset = "0x12FBF90", Length = "0x29")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x600024D")]
	public SafeWaitHandle(IntPtr existingHandle, bool ownsHandle) { }

	[Address(RVA = "0x12FD1B0", Offset = "0x12FC3B0", Length = "0x16")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeEventCalls), Member = "CloseEvent_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Token(Token = "0x600024E")]
	protected virtual bool ReleaseHandle() { }

}

