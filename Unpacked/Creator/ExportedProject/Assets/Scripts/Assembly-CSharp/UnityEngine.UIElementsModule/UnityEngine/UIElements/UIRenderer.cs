namespace UnityEngine.UIElements;

[NativeType(Header = "Modules/UIElements/Core/Native/Renderer/UIRenderer.h")]
[Token(Token = "0x200029B")]
public sealed class UIRenderer : Renderer
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A3F")]
	internal List<CommandList>[] commandLists; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A40")]
	internal bool skipRendering; //Field offset: 0x20

	[Address(RVA = "0x3B01C0", Offset = "0x3AF3C0", Length = "0x7")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001205")]
	public UIRenderer() { }

	[Address(RVA = "0x1C93CC0", Offset = "0x1C92EC0", Length = "0xD2")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "SerializeRootTreeCommands", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001202")]
	internal void AddDrawCallData(int safeFrameIndex, int cmdListIndex, Material mat) { }

	[Address(RVA = "0x1C93C60", Offset = "0x1C92E60", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001206")]
	private static void AddDrawCallData_Injected(IntPtr _unity_self, int safeFrameIndex, int cmdListIndex, IntPtr mat) { }

	[Address(RVA = "0x1C93DA0", Offset = "0x1C92FA0", Length = "0xB6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CommandList), Member = "Execute", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6001204")]
	private static void OnRenderNodeExecute(UIRenderer renderer, int safeFrameIndex, int cmdListIndex) { }

	[Address(RVA = "0x1C93EA0", Offset = "0x1C930A0", Length = "0x76")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "SerializeRootTreeCommands", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001203")]
	internal void ResetDrawCallData() { }

	[Address(RVA = "0x1C93E60", Offset = "0x1C93060", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001207")]
	private static void ResetDrawCallData_Injected(IntPtr _unity_self) { }

}

