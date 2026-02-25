namespace Unity.Burst;

[Token(Token = "0x200000D")]
public static class BurstRuntime
{
	[Token(Token = "0x200000E")]
	private struct HashCode64
	{
		[Token(Token = "0x400001F")]
		public static readonly long Value; //Field offset: 0x0

		[Address(RVA = "0xC5BC80", Offset = "0xC5AE80", Length = "0xBF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600002F")]
		private static HashCode64`1() { }

	}

	[Token(Token = "0x200000F")]
	public class PreserveAttribute : Attribute
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000030")]
		public PreserveAttribute() { }

	}


	[Address(RVA = "0x6854B0", Offset = "0x6846B0", Length = "0x75")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x600002A")]
	public static long GetHashCode64() { }

	[Address(RVA = "0x181A070", Offset = "0x1819270", Length = "0x81")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600002B")]
	internal static long HashStringWithFNV1A64(string text) { }

	[Address(RVA = "0x181A100", Offset = "0x1819300", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = "Unity.Burst.LowLevel.BurstCompilerService", Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), "Unity.Burst.LowLevel.BurstCompilerService+BurstLogType", typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[Preserve]
	[Token(Token = "0x600002E")]
	internal static void Log(Byte* message, int logType, Byte* fileName, int lineNumber) { }

	[Address(RVA = "0x181A130", Offset = "0x1819330", Length = "0xCE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Preserve]
	[Token(Token = "0x600002D")]
	internal static void PreventRequiredAttributeStrip() { }

	[Address(RVA = "0x181A200", Offset = "0x1819400", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = "Unity.Burst.LowLevel.BurstCompilerService", Member = "RuntimeLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), "Unity.Burst.LowLevel.BurstCompilerService+BurstLogType", typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[Preserve]
	[Token(Token = "0x600002C")]
	internal static void RuntimeLog(Byte* message, int logType, Byte* fileName, int lineNumber) { }

}

