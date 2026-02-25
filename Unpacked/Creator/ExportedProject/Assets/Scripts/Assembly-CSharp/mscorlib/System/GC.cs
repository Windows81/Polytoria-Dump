namespace System;

[Token(Token = "0x200018B")]
public static class GC
{
	[Token(Token = "0x40005D7")]
	internal static readonly object EPHEMERON_TOMBSTONE; //Field offset: 0x0

	[Address(RVA = "0x14DED70", Offset = "0x14DDF70", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021C260")]
	[Token(Token = "0x6000DEF")]
	private static void _ReRegisterForFinalize(object o) { }

	[Address(RVA = "0x14DED80", Offset = "0x14DDF80", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021C290")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6000DED")]
	private static void _SuppressFinalize(object o) { }

	[Address(RVA = "0x14DED90", Offset = "0x14DDF90", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021CA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000DF1")]
	private static GC() { }

	[Address(RVA = "0x14DE490", Offset = "0x14DD690", Length = "0x138")]
	[CalledBy(Type = "UnityEngine.Windows.WebCam.PhotoCapture", Member = "InvokeOnCapturedPhotoToMemoryDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Windows.WebCam.PhotoCapture+OnCapturedToMemoryCallback", typeof(long), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Windows.WebCam.PhotoCaptureFrame", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_set_default_thread_affinity")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000DE6")]
	public static void AddMemoryPressure(long bytesAllocated) { }

	[Address(RVA = "0x14DE8C0", Offset = "0x14DDAC0", Length = "0x126")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_gc_collect")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000DEA")]
	public static void Collect(int generation, GCCollectionMode mode, bool blocking, bool compacting) { }

	[Address(RVA = "0x14DE5D0", Offset = "0x14DD7D0", Length = "0x157")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_gc_collect")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000DE9")]
	public static void Collect(int generation, GCCollectionMode mode, bool blocking) { }

	[Address(RVA = "0x14DE730", Offset = "0x14DD930", Length = "0x188")]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.BasicModule", Member = "collectgarbage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_gc_collect")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000DE8")]
	public static void Collect(int generation, GCCollectionMode mode) { }

	[Address(RVA = "0x14DE9F0", Offset = "0x14DDBF0", Length = "0xB7")]
	[CalledBy(Type = "System.Diagnostics.Switch", Member = "_pruneCachedSwitches", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021A700")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6000DEB")]
	public static int CollectionCount(int generation) { }

	[Address(RVA = "0x14DEDE0", Offset = "0x14DDFE0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021CA50")]
	[Token(Token = "0x6000DE4")]
	private static object get_ephemeron_tombstone() { }

	[Address(RVA = "0x14DEAB0", Offset = "0x14DDCB0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021A700")]
	[Token(Token = "0x6000DE0")]
	private static int GetCollectionCount(int generation) { }

	[Address(RVA = "0x14DEAC0", Offset = "0x14DDCC0", Length = "0x1C")]
	[CalledBy(Type = typeof(TlsOverPerCoreLockedStacksArrayPool`1), Member = "Trim", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TlsOverPerCoreLockedStacksArrayPool`1), Member = "GetMemoryPressure", ReturnType = "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1<T>+MemoryPressure<T>")]
	[CallerCount(Count = 2)]
	[Token(Token = "0x6000DE5")]
	internal static void GetMemoryInfo(out uint highMemLoadThreshold, out ulong totalPhysicalMem, out uint lastRecordedMemLoad, out UIntPtr lastRecordedHeapSize, out UIntPtr lastRecordedFragmentation) { }

	[Address(RVA = "0x14DEAE0", Offset = "0x14DDCE0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_gc_collect")]
	[Token(Token = "0x6000DE1")]
	private static void InternalCollect(int generation) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6000DEC")]
	public static void KeepAlive(object obj) { }

	[Address(RVA = "0x134D440", Offset = "0x134C640", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_set_default_thread_affinity")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DE2")]
	private static void RecordPressure(long bytesAllocated) { }

	[Address(RVA = "0x14DEDF0", Offset = "0x14DDFF0", Length = "0x5")]
	[CalledBy(Type = typeof(ConditionalWeakTable`2), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConditionalWeakTable`2), Member = "Rehash", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021CEF0")]
	[Token(Token = "0x6000DE3")]
	internal static void register_ephemeron_array(Ephemeron[] array) { }

	[Address(RVA = "0x14DEB90", Offset = "0x14DDD90", Length = "0x13B")]
	[CalledBy(Type = "UnityEngine.Windows.WebCam.PhotoCaptureFrame", Member = "Cleanup", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_set_default_thread_affinity")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000DE7")]
	public static void RemoveMemoryPressure(long bytesAllocated) { }

	[Address(RVA = "0x14DEAF0", Offset = "0x14DDCF0", Length = "0x94")]
	[CalledBy(Type = typeof(Gen2GcCallback), Member = "Finalize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskExceptionHolder), Member = "AddFaultException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskExceptionHolder), Member = "MarkAsUnhandled", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021C260")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000DF0")]
	public static void ReRegisterForFinalize(object obj) { }

	[Address(RVA = "0x14DECD0", Offset = "0x14DDED0", Length = "0x94")]
	[CallerCount(Count = 134)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021C290")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6000DEE")]
	public static void SuppressFinalize(object obj) { }

}

