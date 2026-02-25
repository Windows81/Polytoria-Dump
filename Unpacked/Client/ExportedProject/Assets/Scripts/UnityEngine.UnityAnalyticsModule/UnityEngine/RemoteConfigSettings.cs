namespace UnityEngine;

[ExcludeFromDocs]
[NativeHeader("Modules/UnityAnalytics/RemoteSettings/RemoteSettings.h")]
[NativeHeader("UnityAnalyticsScriptingClasses.h")]
[NativeHeader("Modules/UnityAnalyticsCommon/Public/UnityAnalyticsCommon.h")]
[Token(Token = "0x2000004")]
public class RemoteConfigSettings
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000004")]
	internal IntPtr m_Ptr; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000005")]
	private Action<Boolean> Updated; //Field offset: 0x18

	[Address(RVA = "0x1CF6DE0", Offset = "0x1CF5FE0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000006")]
	internal static void RemoteConfigSettingsUpdated(RemoteConfigSettings rcs, bool wasLastUpdatedFromServer) { }

}

