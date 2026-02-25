namespace UnityEngine;

[NativeHeader("Runtime/Camera/Camera.h")]
[Token(Token = "0x2000009")]
internal class CameraRaycastHelper
{

	[Address(RVA = "0x19D90C0", Offset = "0x19D82C0", Length = "0xB5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801BC7B0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("CameraScripting::RaycastTry")]
	[Token(Token = "0x6000012")]
	internal static GameObject RaycastTry(Camera cam, Ray ray, float distance, int layerMask) { }

	[Address(RVA = "0x19D9050", Offset = "0x19D8250", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000014")]
	private static IntPtr RaycastTry_Injected(IntPtr cam, in Ray ray, float distance, int layerMask) { }

	[Address(RVA = "0x19D8F90", Offset = "0x19D8190", Length = "0xB5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801BC7B0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("CameraScripting::RaycastTry2D")]
	[Token(Token = "0x6000013")]
	internal static GameObject RaycastTry2D(Camera cam, Ray ray, float distance, int layerMask) { }

	[Address(RVA = "0x19D8F20", Offset = "0x19D8120", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000015")]
	private static IntPtr RaycastTry2D_Injected(IntPtr cam, in Ray ray, float distance, int layerMask) { }

}

