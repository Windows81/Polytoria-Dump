namespace UnityEngine;

[NativeHeader("Modules/ScreenCapture/Public/CaptureScreenshot.h")]
[Token(Token = "0x2000002")]
public static class ScreenCapture
{
	[Token(Token = "0x2000003")]
	internal enum StereoScreenCaptureMode
	{
		LeftEye = 1,
		RightEye = 2,
		BothEyes = 3,
		MotionVectors = 4,
	}


	[Address(RVA = "0x1A19350", Offset = "0x1A18550", Length = "0x10")]
	[CalledBy(Type = "Polytoria.Controllers.ScreenshotController+<DoScreenshot>d__24", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScreenCapture), Member = "CaptureScreenshot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(StereoScreenCaptureMode)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000001")]
	public static void CaptureScreenshot(string filename) { }

	[Address(RVA = "0x1A191C0", Offset = "0x1A183C0", Length = "0x18D")]
	[CalledBy(Type = typeof(ScreenCapture), Member = "CaptureScreenshot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000002")]
	private static void CaptureScreenshot(string filename, int superSize, StereoScreenCaptureMode CaptureMode) { }

	[Address(RVA = "0x1A19170", Offset = "0x1A18370", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000003")]
	private static void CaptureScreenshot_Injected(ref ManagedSpanWrapper filename, int superSize, StereoScreenCaptureMode CaptureMode) { }

}

