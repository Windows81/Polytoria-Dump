namespace UnityEngine.UIElements;

[NativeHeader("Modules/UIElements/Core/Native/Renderer/UIPainter2D.bindings.h")]
[Token(Token = "0x200029A")]
internal static class UIPainter2D
{

	[Address(RVA = "0x1C8F6C0", Offset = "0x1C8E8C0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60011FF")]
	public static void ClearSnapshots(IntPtr handle) { }

	[Address(RVA = "0x1C8F700", Offset = "0x1C8E900", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60011FC")]
	public static IntPtr Create(bool computeBBox = false) { }

	[Address(RVA = "0x1C8F740", Offset = "0x1C8E940", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60011FD")]
	public static void Destroy(IntPtr handle) { }

	[Address(RVA = "0x1C8F7D0", Offset = "0x1C8E9D0", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6001200")]
	public static MeshWriteDataInterface ExecuteSnapshotFromJob(IntPtr painterHandle, int i) { }

	[Address(RVA = "0x1C8F780", Offset = "0x1C8E980", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001201")]
	private static void ExecuteSnapshotFromJob_Injected(IntPtr painterHandle, int i, out MeshWriteDataInterface ret) { }

	[Address(RVA = "0x1C8F830", Offset = "0x1C8EA30", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60011FE")]
	public static void Reset(IntPtr handle) { }

}

