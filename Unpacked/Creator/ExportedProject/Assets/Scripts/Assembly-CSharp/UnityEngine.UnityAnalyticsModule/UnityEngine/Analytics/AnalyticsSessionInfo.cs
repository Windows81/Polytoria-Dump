namespace UnityEngine.Analytics;

[NativeHeader("UnityAnalyticsScriptingClasses.h")]
[NativeHeader("Modules/UnityAnalytics/Public/UnityAnalytics.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000009")]
public static class AnalyticsSessionInfo
{
	[Token(Token = "0x200000B")]
	internal sealed class IdentityTokenChanged : MulticastDelegate
	{

		[Address(RVA = "0x38E330", Offset = "0x38D530", Length = "0xB4")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x600000B")]
		public IdentityTokenChanged(object object, IntPtr method) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600000C")]
		public override void Invoke(string token) { }

	}

	[Token(Token = "0x200000A")]
	internal sealed class SessionStateChanged : MulticastDelegate
	{

		[Address(RVA = "0x1CF6F30", Offset = "0x1CF6130", Length = "0xA6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000009")]
		public SessionStateChanged(object object, IntPtr method) { }

		[Address(RVA = "0x39FEF0", Offset = "0x39F0F0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600000A")]
		public override void Invoke(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000017")]
	private static SessionStateChanged sessionStateChanged; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000018")]
	private static IdentityTokenChanged identityTokenChanged; //Field offset: 0x8

	[Address(RVA = "0x1CF6CF0", Offset = "0x1CF5EF0", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000008")]
	internal static void CallIdentityTokenChanged(string token) { }

	[Address(RVA = "0x1CF6D50", Offset = "0x1CF5F50", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000007")]
	internal static void CallSessionStateChanged(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged) { }

}

