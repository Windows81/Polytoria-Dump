namespace UnityEngine;

[NativeHeader("UnityAnalyticsScriptingClasses.h")]
[NativeHeader("Modules/UnityAnalytics/RemoteSettings/RemoteSettings.h")]
[Token(Token = "0x2000002")]
public static class RemoteSettings
{
	[Token(Token = "0x2000003")]
	internal sealed class UpdatedEventHandler : MulticastDelegate
	{

		[Address(RVA = "0x2D8810", Offset = "0x2D7A10", Length = "0xA5")]
		[CallerCount(Count = 285)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000004")]
		public UpdatedEventHandler(object object, IntPtr method) { }

		[Address(RVA = "0x2BC000", Offset = "0x2BB200", Length = "0x16A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180288CC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000005")]
		public override void Invoke() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000001")]
	private static UpdatedEventHandler Updated; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000002")]
	private static Action BeforeFetchFromServer; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000003")]
	private static Action<Boolean, Boolean, Int32> Completed; //Field offset: 0x10

	[Address(RVA = "0x1CF6E10", Offset = "0x1CF6010", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000002")]
	internal static void RemoteSettingsBeforeFetchFromServer() { }

	[Address(RVA = "0x1CF6E60", Offset = "0x1CF6060", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000003")]
	internal static void RemoteSettingsUpdateCompleted(bool wasLastUpdatedFromServer, bool settingsChanged, int response) { }

	[Address(RVA = "0x1CF6EE0", Offset = "0x1CF60E0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000001")]
	internal static void RemoteSettingsUpdated(bool wasLastUpdatedFromServer) { }

}

