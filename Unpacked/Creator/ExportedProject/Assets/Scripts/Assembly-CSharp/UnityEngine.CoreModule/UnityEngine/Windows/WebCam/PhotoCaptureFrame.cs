namespace UnityEngine.Windows.WebCam;

[MovedFrom("UnityEngine.XR.WSA.WebCam")]
[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
[NativeHeader("PlatformDependent/Win/Webcam/PhotoCaptureFrame.h")]
[Token(Token = "0x20001AC")]
public sealed class PhotoCaptureFrame : IDisposable
{
	[Token(Token = "0x20001AD")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x7CE590", Offset = "0x7CD790", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BE2")]
		public static IntPtr ConvertToNative(PhotoCaptureFrame photoCaptureFrame) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400062E")]
	private IntPtr m_NativePtr; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400062F")]
	private int <dataLength>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000630")]
	private bool <hasLocationData>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000631")]
	private CapturePixelFormat <pixelFormat>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x170001F5")]
	public private int dataLength
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BD2")]
		 get { } //Length: 4
		[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BD3")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170001F6")]
	private bool hasLocationData
	{
		[Address(RVA = "0x339460", Offset = "0x338660", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BD4")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170001F7")]
	private CapturePixelFormat pixelFormat
	{
		[Address(RVA = "0x331A20", Offset = "0x330C20", Length = "0x4")]
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BD5")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x1969210", Offset = "0x1968410", Length = "0x111")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "AddMemoryPressure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000BD9")]
	internal PhotoCaptureFrame(IntPtr nativePtr) { }

	[Address(RVA = "0x1968E30", Offset = "0x1968030", Length = "0x9E")]
	[CalledBy(Type = typeof(PhotoCaptureFrame), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PhotoCaptureFrame), Member = "Finalize", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "RemoveMemoryPressure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BDA")]
	private void Cleanup() { }

	[Address(RVA = "0x1968F70", Offset = "0x1968170", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PhotoCaptureFrame), Member = "Cleanup", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000BDC")]
	public override void Dispose() { }

	[Address(RVA = "0x1968F10", Offset = "0x1968110", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
	[NativeName("Dispose")]
	[ThreadAndSerializationSafe]
	[Token(Token = "0x6000BDB")]
	private void Dispose_Internal() { }

	[Address(RVA = "0x1968ED0", Offset = "0x19680D0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BE1")]
	private static void Dispose_Internal_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1968FD0", Offset = "0x19681D0", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PhotoCaptureFrame), Member = "Cleanup", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000BDD")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BD2")]
	public int get_dataLength() { }

	[Address(RVA = "0x1969070", Offset = "0x1968270", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadAndSerializationSafe]
	[Token(Token = "0x6000BD8")]
	private CapturePixelFormat GetCapturePixelFormat() { }

	[Address(RVA = "0x1969030", Offset = "0x1968230", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BE0")]
	private static CapturePixelFormat GetCapturePixelFormat_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1969110", Offset = "0x1968310", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadAndSerializationSafe]
	[Token(Token = "0x6000BD6")]
	private int GetDataLength() { }

	[Address(RVA = "0x19690D0", Offset = "0x19682D0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BDE")]
	private static int GetDataLength_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19691B0", Offset = "0x19683B0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadAndSerializationSafe]
	[Token(Token = "0x6000BD7")]
	private bool GetHasLocationData() { }

	[Address(RVA = "0x1969170", Offset = "0x1968370", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BDF")]
	private static bool GetHasLocationData_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BD3")]
	private void set_dataLength(int value) { }

	[Address(RVA = "0x339460", Offset = "0x338660", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BD4")]
	private void set_hasLocationData(bool value) { }

	[Address(RVA = "0x331A20", Offset = "0x330C20", Length = "0x4")]
	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BD5")]
	private void set_pixelFormat(CapturePixelFormat value) { }

}

