namespace UnityEngine.Windows.WebCam;

[MovedFrom("UnityEngine.XR.WSA.WebCam")]
[NativeHeader("PlatformDependent/Win/Webcam/VideoCaptureBindings.h")]
[StaticAccessor("VideoCaptureBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x20001AE")]
public class VideoCapture : IDisposable
{
	[Token(Token = "0x20001B6")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x7CE590", Offset = "0x7CD790", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BFA")]
		public static IntPtr ConvertToNative(VideoCapture videoCapture) { }

	}

	[Token(Token = "0x20001AF")]
	internal enum CaptureResultType
	{
		Success = 0,
		UnknownError = 1,
	}

	[Token(Token = "0x20001B4")]
	internal sealed class OnStartedRecordingVideoCallback : MulticastDelegate
	{

		[Address(RVA = "0x80C5C0", Offset = "0x80B7C0", Length = "0xA6")]
		[CallerCount(Count = 24)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BF6")]
		public OnStartedRecordingVideoCallback(object object, IntPtr method) { }

		[Address(RVA = "0x80BFC0", Offset = "0x80B1C0", Length = "0x24")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BF7")]
		public override void Invoke(VideoCaptureResult result) { }

	}

	[Token(Token = "0x20001B5")]
	internal sealed class OnStoppedRecordingVideoCallback : MulticastDelegate
	{

		[Address(RVA = "0x80C5C0", Offset = "0x80B7C0", Length = "0xA6")]
		[CallerCount(Count = 24)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BF8")]
		public OnStoppedRecordingVideoCallback(object object, IntPtr method) { }

		[Address(RVA = "0x80BFC0", Offset = "0x80B1C0", Length = "0x24")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BF9")]
		public override void Invoke(VideoCaptureResult result) { }

	}

	[Token(Token = "0x20001B1")]
	internal sealed class OnVideoCaptureResourceCreatedCallback : MulticastDelegate
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
		[Token(Token = "0x6000BF0")]
		public OnVideoCaptureResourceCreatedCallback(object object, IntPtr method) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BF1")]
		public override void Invoke(VideoCapture captureObject) { }

	}

	[Token(Token = "0x20001B2")]
	internal sealed class OnVideoModeStartedCallback : MulticastDelegate
	{

		[Address(RVA = "0x80C5C0", Offset = "0x80B7C0", Length = "0xA6")]
		[CallerCount(Count = 24)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BF2")]
		public OnVideoModeStartedCallback(object object, IntPtr method) { }

		[Address(RVA = "0x80BFC0", Offset = "0x80B1C0", Length = "0x24")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BF3")]
		public override void Invoke(VideoCaptureResult result) { }

	}

	[Token(Token = "0x20001B3")]
	internal sealed class OnVideoModeStoppedCallback : MulticastDelegate
	{

		[Address(RVA = "0x80C5C0", Offset = "0x80B7C0", Length = "0xA6")]
		[CallerCount(Count = 24)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BF4")]
		public OnVideoModeStoppedCallback(object object, IntPtr method) { }

		[Address(RVA = "0x80BFC0", Offset = "0x80B1C0", Length = "0x24")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BF5")]
		public override void Invoke(VideoCaptureResult result) { }

	}

	[Token(Token = "0x20001B0")]
	internal struct VideoCaptureResult
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000637")]
		public CaptureResultType resultType; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000638")]
		public long hResult; //Field offset: 0x8

	}

	[Token(Token = "0x4000633")]
	private static readonly long HR_SUCCESS; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000632")]
	internal IntPtr m_NativePtr; //Field offset: 0x10

	[Address(RVA = "0x19275D0", Offset = "0x19267D0", Length = "0x26")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BE5")]
	private VideoCapture(IntPtr nativeCaptureObject) { }

	[Address(RVA = "0x1993D50", Offset = "0x1992F50", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BEA")]
	public override void Dispose() { }

	[Address(RVA = "0x1993CF0", Offset = "0x1992EF0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
	[NativeMethod("VideoCaptureBindings::Dispose", HasExplicitThis = True)]
	[Token(Token = "0x6000BEB")]
	private void Dispose_Internal() { }

	[Address(RVA = "0x1993CB0", Offset = "0x1992EB0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BEE")]
	private static void Dispose_Internal_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1993C50", Offset = "0x1992E50", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
	[NativeMethod("VideoCaptureBindings::DisposeThreaded", HasExplicitThis = True)]
	[ThreadAndSerializationSafe]
	[Token(Token = "0x6000BED")]
	private void DisposeThreaded_Internal() { }

	[Address(RVA = "0x1993C10", Offset = "0x1992E10", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BEF")]
	private static void DisposeThreaded_Internal_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1993DE0", Offset = "0x1992FE0", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BEC")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x1993E70", Offset = "0x1993070", Length = "0xA4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000BE4")]
	private static void InvokeOnCreatedVideoCaptureResourceDelegate(OnVideoCaptureResourceCreatedCallback callback, IntPtr nativePtr) { }

	[Address(RVA = "0x1993F20", Offset = "0x1993120", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	[Token(Token = "0x6000BE8")]
	private static void InvokeOnStartedRecordingVideoToDiskDelegate(OnStartedRecordingVideoCallback callback, long hResult) { }

	[Address(RVA = "0x1993F20", Offset = "0x1993120", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	[Token(Token = "0x6000BE9")]
	private static void InvokeOnStoppedRecordingVideoToDiskDelegate(OnStoppedRecordingVideoCallback callback, long hResult) { }

	[Address(RVA = "0x1993F20", Offset = "0x1993120", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	[Token(Token = "0x6000BE6")]
	private static void InvokeOnVideoModeStartedDelegate(OnVideoModeStartedCallback callback, long hResult) { }

	[Address(RVA = "0x1993F20", Offset = "0x1993120", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	[Token(Token = "0x6000BE7")]
	private static void InvokeOnVideoModeStoppedDelegate(OnVideoModeStoppedCallback callback, long hResult) { }

	[Address(RVA = "0x1993FC0", Offset = "0x19931C0", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000BE3")]
	private static VideoCaptureResult MakeCaptureResult(long hResult) { }

}

