namespace Unity.Profiling.LowLevel.Unsafe;

[IgnoredByDeepProfiler]
[NativeHeader("Runtime/Profiler/ScriptBindings/ProfilerUnsafeUtility.bindings.h")]
[Token(Token = "0x2000026")]
[UsedByNativeCode]
public static class ProfilerUnsafeUtility
{

	[Address(RVA = "0x19398B0", Offset = "0x1938AB0", Length = "0x33")]
	[CallerCount(Count = 29)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x600006A")]
	public static void BeginSample(IntPtr markerPtr) { }

	[Address(RVA = "0x19398F0", Offset = "0x1938AF0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6000065")]
	internal static ushort CreateCategory__Unmanaged(Byte* name, int nameLen, ProfilerCategoryColor colorIndex) { }

	[Address(RVA = "0x1939950", Offset = "0x1938B50", Length = "0xA4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x600006C")]
	internal static Void* CreateCounterValue__Unmanaged(out IntPtr counterPtr, Byte* name, int nameLen, ushort categoryId, MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions) { }

	[Address(RVA = "0x1939AE0", Offset = "0x1938CE0", Length = "0x19E")]
	[CallerCount(Count = 150)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6000067")]
	public static IntPtr CreateMarker(string name, ushort categoryId, MarkerFlags flags, int metadataCount) { }

	[Address(RVA = "0x1939A70", Offset = "0x1938C70", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6000068")]
	internal static IntPtr CreateMarker__Unmanaged(Byte* name, int nameLen, ushort categoryId, MarkerFlags flags, int metadataCount) { }

	[Address(RVA = "0x1939A00", Offset = "0x1938C00", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600006F")]
	private static IntPtr CreateMarker_Injected(ref ManagedSpanWrapper name, ushort categoryId, MarkerFlags flags, int metadataCount) { }

	[Address(RVA = "0x1939C80", Offset = "0x1938E80", Length = "0x33")]
	[CallerCount(Count = 79)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x600006B")]
	public static void EndSample(IntPtr markerPtr) { }

	[Address(RVA = "0x1939D10", Offset = "0x1938F10", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6000066")]
	public static ProfilerCategoryDescription GetCategoryDescription(ushort categoryId) { }

	[Address(RVA = "0x1939CC0", Offset = "0x1938EC0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600006E")]
	private static void GetCategoryDescription_Injected(ushort categoryId, out ProfilerCategoryDescription ret) { }

	[Address(RVA = "0x1939D70", Offset = "0x1938F70", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6000069")]
	internal static void SetMarkerMetadata__Unmanaged(IntPtr markerPtr, int index, Byte* name, int nameLen, byte type, byte unit) { }

	[Address(RVA = "0x1939DF0", Offset = "0x1938FF0", Length = "0xE8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600006D")]
	internal static string Utf8ToString(Byte* chars, int charsLen) { }

}

