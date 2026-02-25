namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x20005C6")]
internal static class LayoutDelegates
{
	[Token(Token = "0x40014E7")]
	private static readonly ProfilerMarker s_InvokeMeasureFunctionMarker; //Field offset: 0x0
	[Token(Token = "0x40014E8")]
	private static readonly ProfilerMarker s_InvokeBaselineFunctionMarker; //Field offset: 0x8
	[Token(Token = "0x40014E9")]
	private static readonly InvokeMeasureFunctionDelegate s_InvokeMeasureDelegate; //Field offset: 0x10
	[Token(Token = "0x40014EA")]
	private static readonly InvokeBaselineFunctionDelegate s_InvokeBaselineDelegate; //Field offset: 0x18
	[Token(Token = "0x40014EB")]
	internal static readonly IntPtr s_InvokeMeasureFunction; //Field offset: 0x20
	[Token(Token = "0x40014EC")]
	internal static readonly IntPtr s_InvokeBaselineFunction; //Field offset: 0x28

	[Address(RVA = "0x1BA9E70", Offset = "0x1BA9070", Length = "0x318")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "GetFunctionPointerForDelegate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6002958")]
	private static LayoutDelegates() { }

	[Address(RVA = "0x1BA99E0", Offset = "0x1BA8BE0", Length = "0x213")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3500")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LayoutManager), Member = "GetManager", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(LayoutManager))]
	[Calls(Type = typeof(LayoutManager), Member = "GetBaselineFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(LayoutBaselineFunction))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback(typeof(InvokeBaselineFunctionDelegate))]
	[Token(Token = "0x6002957")]
	private static float InvokeBaselineFunction(ref LayoutNode node, float width, float height) { }

	[Address(RVA = "0x1BA9C00", Offset = "0x1BA8E00", Length = "0x268")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutManager), Member = "GetMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(LayoutMeasureFunction))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181BA3500")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LayoutManager), Member = "GetManager", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(LayoutManager))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "GetOwner", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback(typeof(InvokeMeasureFunctionDelegate))]
	[Token(Token = "0x6002956")]
	private static void InvokeMeasureFunction(ref LayoutNode node, float width, LayoutMeasureMode widthMode, float height, LayoutMeasureMode heightMode, ref IntPtr exception, out LayoutSize result) { }

}

