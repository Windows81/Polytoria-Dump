namespace GLTFast.Logging;

[Token(Token = "0x20000E3")]
public static class LogMessages
{

	[Address(RVA = "0x1091180", Offset = "0x1090380", Length = "0x1C1")]
	[CalledBy(Type = typeof(ConsoleLogger), Member = "Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogCode), typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConsoleLogger), Member = "Warning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogCode), typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConsoleLogger), Member = "Info", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogCode), typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConsoleLogger), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogType), typeof(LogCode), typeof(String[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002A7")]
	public static string GetFullMessage(LogCode code, String[] messages) { }

}

