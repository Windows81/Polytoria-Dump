namespace UnityEngine.UnityConsent;

[NativeHeader("Modules/UnityConsent/EndUserConsent.h")]
[Token(Token = "0x2000004")]
public static class EndUserConsent
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000007")]
	private static Action<ConsentState> consentStateChanged; //Field offset: 0x0

	[Address(RVA = "0x1CF7230", Offset = "0x1CF6430", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("GetConsentStateStatic")]
	[Token(Token = "0x6000003")]
	public static ConsentState GetConsentState() { }

	[Address(RVA = "0x1CF71F0", Offset = "0x1CF63F0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000005")]
	private static void GetConsentState_Injected(out ConsentState ret) { }

	[Address(RVA = "0x1CF7270", Offset = "0x1CF6470", Length = "0x92")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 2)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000004")]
	private static void OnConsentStateChanged() { }

}

