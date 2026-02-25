namespace UnityEngine.UIElements.Layout;

[NativeHeader("Modules/UIElements/Core/Layout/Native/LayoutNative.h")]
[Token(Token = "0x20005ED")]
internal static class LayoutNative
{
	[Token(Token = "0x20005EF")]
	public class LayoutLogData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40015A6")]
		public LayoutNode node; //Field offset: 0x10
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40015A7")]
		public LayoutLogEventType eventType; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40015A8")]
		public string message; //Field offset: 0x48

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60029A2")]
		public LayoutLogData() { }

	}

	[Token(Token = "0x20005EE")]
	public enum LayoutLogEventType
	{
		None = 0,
		Error = 1,
		Measure = 2,
		Layout = 3,
		CacheUsage = 4,
		BeginLayout = 5,
		EndLayout = 6,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x400159D")]
	private static Action<LayoutLogData> onLayoutLog; //Field offset: 0x0

	[Address(RVA = "0x1BAC0E0", Offset = "0x1BAB2E0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(IsThreadSafe = False)]
	[Token(Token = "0x60029A0")]
	internal static void CalculateLayout(IntPtr node, float parentWidth, float parentHeight, int parentDirection, IntPtr state, IntPtr exceptionGCHandle) { }

	[Address(RVA = "0x1BAC150", Offset = "0x1BAB350", Length = "0xD7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x60029A1")]
	private static void LayoutLog_Internal(IntPtr nodePtr, LayoutLogEventType type, string message) { }

}

