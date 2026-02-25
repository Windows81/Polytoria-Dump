namespace UnityEngine.Windows.WebCam;

[MovedFrom("UnityEngine.XR.WSA.WebCam")]
[NativeHeader("PlatformDependent/Win/Webcam/PhotoCapture.h")]
[StaticAccessor("PhotoCapture", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x20001A3")]
public class PhotoCapture : IDisposable
{
	[Token(Token = "0x20001AB")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x7CE590", Offset = "0x7CD790", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BD1")]
		public static IntPtr ConvertToNative(PhotoCapture photoCapture) { }

	}

	[Token(Token = "0x20001A4")]
	internal enum CaptureResultType
	{
		Success = 0,
		UnknownError = 1,
	}

	[Token(Token = "0x20001A9")]
	internal sealed class OnCapturedToDiskCallback : MulticastDelegate
	{

		[Address(RVA = "0x80C5C0", Offset = "0x80B7C0", Length = "0xA6")]
		[CallerCount(Count = 24)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BCD")]
		public OnCapturedToDiskCallback(object object, IntPtr method) { }

		[Address(RVA = "0x80BFC0", Offset = "0x80B1C0", Length = "0x24")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BCE")]
		public override void Invoke(PhotoCaptureResult result) { }

	}

	[Token(Token = "0x20001AA")]
	internal sealed class OnCapturedToMemoryCallback : MulticastDelegate
	{

		[Address(RVA = "0xA32510", Offset = "0xA31710", Length = "0xA6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BCF")]
		public OnCapturedToMemoryCallback(object object, IntPtr method) { }

		[Address(RVA = "0xA30A70", Offset = "0xA2FC70", Length = "0x24")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BD0")]
		public override void Invoke(PhotoCaptureResult result, PhotoCaptureFrame photoCaptureFrame) { }

	}

	[Token(Token = "0x20001A6")]
	internal sealed class OnCaptureResourceCreatedCallback : MulticastDelegate
	{

		[Address(RVA = "0x3351D0", Offset = "0x3343D0", Length = "0x124")]
		[CallerCount(Count = 654)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BC7")]
		public OnCaptureResourceCreatedCallback(object object, IntPtr method) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BC8")]
		public override void Invoke(PhotoCapture captureObject) { }

	}

	[Token(Token = "0x20001A7")]
	internal sealed class OnPhotoModeStartedCallback : MulticastDelegate
	{

		[Address(RVA = "0x80C5C0", Offset = "0x80B7C0", Length = "0xA6")]
		[CallerCount(Count = 24)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BC9")]
		public OnPhotoModeStartedCallback(object object, IntPtr method) { }

		[Address(RVA = "0x80BFC0", Offset = "0x80B1C0", Length = "0x24")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BCA")]
		public override void Invoke(PhotoCaptureResult result) { }

	}

	[Token(Token = "0x20001A8")]
	internal sealed class OnPhotoModeStoppedCallback : MulticastDelegate
	{

		[Address(RVA = "0x80C5C0", Offset = "0x80B7C0", Length = "0xA6")]
		[CallerCount(Count = 24)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BCB")]
		public OnPhotoModeStoppedCallback(object object, IntPtr method) { }

		[Address(RVA = "0x80BFC0", Offset = "0x80B1C0", Length = "0x24")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BCC")]
		public override void Invoke(PhotoCaptureResult result) { }

	}

	[Token(Token = "0x20001A5")]
	internal struct PhotoCaptureResult
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400062C")]
		public CaptureResultType resultType; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400062D")]
		public long hResult; //Field offset: 0x8

	}

	[Token(Token = "0x4000628")]
	private static readonly long HR_SUCCESS; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000627")]
	internal IntPtr m_NativePtr; //Field offset: 0x10

	[Address(RVA = "0x19275D0", Offset = "0x19267D0", Length = "0x26")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BBC")]
	private PhotoCapture(IntPtr nativeCaptureObject) { }

	[Address(RVA = "0x1969470", Offset = "0x1968670", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BC1")]
	public override void Dispose() { }

	[Address(RVA = "0x1969410", Offset = "0x1968610", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
	[NativeName("Dispose")]
	[Token(Token = "0x6000BC2")]
	private void Dispose_Internal() { }

	[Address(RVA = "0x19693D0", Offset = "0x19685D0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BC5")]
	private static void Dispose_Internal_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1969370", Offset = "0x1968570", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
	[NativeName("DisposeThreaded")]
	[ThreadAndSerializationSafe]
	[Token(Token = "0x6000BC4")]
	private void DisposeThreaded_Internal() { }

	[Address(RVA = "0x1969330", Offset = "0x1968530", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BC6")]
	private static void DisposeThreaded_Internal_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1969500", Offset = "0x1968700", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BC3")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x1969590", Offset = "0x1968790", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	[Token(Token = "0x6000BBF")]
	private static void InvokeOnCapturedPhotoToDiskDelegate(OnCapturedToDiskCallback callback, long hResult) { }

	[Address(RVA = "0x1969630", Offset = "0x1968830", Length = "0x1E1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "AddMemoryPressure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[RequiredByNativeCode]
	[Token(Token = "0x6000BC0")]
	private static void InvokeOnCapturedPhotoToMemoryDelegate(OnCapturedToMemoryCallback callback, long hResult, IntPtr photoCaptureFramePtr) { }

	[Address(RVA = "0x1969820", Offset = "0x1968A20", Length = "0xA4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000BBB")]
	private static void InvokeOnCreatedResourceDelegate(OnCaptureResourceCreatedCallback callback, IntPtr nativePtr) { }

	[Address(RVA = "0x1969590", Offset = "0x1968790", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	[Token(Token = "0x6000BBD")]
	private static void InvokeOnPhotoModeStartedDelegate(OnPhotoModeStartedCallback callback, long hResult) { }

	[Address(RVA = "0x1969590", Offset = "0x1968790", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	[Token(Token = "0x6000BBE")]
	private static void InvokeOnPhotoModeStoppedDelegate(OnPhotoModeStoppedCallback callback, long hResult) { }

	[Address(RVA = "0x19698D0", Offset = "0x1968AD0", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000BBA")]
	private static PhotoCaptureResult MakeCaptureResult(long hResult) { }

}

