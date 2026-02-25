namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x2000012")]
public class ProjectSettingsInformationAnalytic : AnalyticsEventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000036")]
	private int agent_types_count; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000037")]
	private int areas_count; //Field offset: 0x34

	[Address(RVA = "0x1CF60E0", Offset = "0x1CF52E0", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600001F")]
	public ProjectSettingsInformationAnalytic() { }

	[Address(RVA = "0x1CF6050", Offset = "0x1CF5250", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	[RequiredByNativeCode]
	[Token(Token = "0x6000020")]
	internal static ProjectSettingsInformationAnalytic CreateProjectSettingsInformationAnalytic() { }

}

