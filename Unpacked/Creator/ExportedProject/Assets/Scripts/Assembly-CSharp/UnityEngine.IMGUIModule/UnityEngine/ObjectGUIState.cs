namespace UnityEngine;

[NativeHeader("Modules/IMGUI/GUIState.h")]
[Token(Token = "0x2000028")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal class ObjectGUIState : IDisposable
{
	[Token(Token = "0x2000029")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x7CE590", Offset = "0x7CD790", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600026E")]
		public static IntPtr ConvertToNative(ObjectGUIState objectGUIState) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000103")]
	internal IntPtr m_Ptr; //Field offset: 0x10

	[Address(RVA = "0x19C2B80", Offset = "0x19C1D80", Length = "0x3B")]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "get_guiState", ReturnType = typeof(ObjectGUIState))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000268")]
	public ObjectGUIState() { }

	[Address(RVA = "0x19C2990", Offset = "0x19C1B90", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600026B")]
	private void Destroy() { }

	[Address(RVA = "0x19C29E0", Offset = "0x19C1BE0", Length = "0x8A")]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000269")]
	public override void Dispose() { }

	[Address(RVA = "0x19C2A70", Offset = "0x19C1C70", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600026A")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x19C2B10", Offset = "0x19C1D10", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600026C")]
	private static IntPtr Internal_Create() { }

	[Address(RVA = "0x19C2B40", Offset = "0x19C1D40", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(IsThreadSafe = True)]
	[Token(Token = "0x600026D")]
	private static void Internal_Destroy(IntPtr ptr) { }

}

