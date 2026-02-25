namespace GLTFast.Logging;

[Token(Token = "0x20000E0")]
public class ConsoleLogger : ICodeLogger
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002A2")]
	public ConsoleLogger() { }

	[Address(RVA = "0x108A190", Offset = "0x1089390", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LogMessages), Member = "GetFullMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogCode), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x600029E")]
	public override void Error(LogCode code, String[] messages) { }

	[Address(RVA = "0x108A200", Offset = "0x1089400", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LogMessages), Member = "GetFullMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogCode), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x60002A0")]
	public override void Info(LogCode code, String[] messages) { }

	[Address(RVA = "0x108A270", Offset = "0x1089470", Length = "0x14F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LogMessages), Member = "GetFullMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogCode), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002A1")]
	public override void Log(LogType logType, LogCode code, String[] messages) { }

	[Address(RVA = "0x108A3C0", Offset = "0x10895C0", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LogMessages), Member = "GetFullMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogCode), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x600029F")]
	public override void Warning(LogCode code, String[] messages) { }

}

