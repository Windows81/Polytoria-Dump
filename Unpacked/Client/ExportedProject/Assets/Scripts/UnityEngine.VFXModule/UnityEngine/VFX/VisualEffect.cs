namespace UnityEngine.VFX;

[NativeHeader("Modules/VFX/Public/ScriptBindings/VisualEffectBindings.h")]
[NativeHeader("Modules/VFX/Public/VisualEffect.h")]
[RequireComponent(typeof(Transform))]
[Token(Token = "0x200000E")]
public class VisualEffect : Behaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400001B")]
	private VFXEventAttribute m_cachedEventAttribute; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400001C")]
	public Action<VFXOutputEventArgs> outputEventReceived; //Field offset: 0x20

	[Token(Token = "0x17000001")]
	public VisualEffectAsset visualEffectAsset
	{
		[Address(RVA = "0x1D00CC0", Offset = "0x1CFFEC0", Length = "0x135")]
		[CalledBy(Type = typeof(VisualEffect), Member = "CreateVFXEventAttribute", ReturnType = typeof(VFXEventAttribute))]
		[CalledBy(Type = typeof(VisualEffect), Member = "InvokeGetCachedEventAttributeForOutputEvent_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualEffect)}, ReturnType = typeof(VFXEventAttribute))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600001E")]
		 get { } //Length: 309
	}

	[Address(RVA = "0x1D008C0", Offset = "0x1CFFAC0", Length = "0x184")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualEffect), Member = "get_visualEffectAsset", ReturnType = typeof(VisualEffectAsset))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600001F")]
	public VFXEventAttribute CreateVFXEventAttribute() { }

	[Address(RVA = "0x1D00CC0", Offset = "0x1CFFEC0", Length = "0x135")]
	[CalledBy(Type = typeof(VisualEffect), Member = "CreateVFXEventAttribute", ReturnType = typeof(VFXEventAttribute))]
	[CalledBy(Type = typeof(VisualEffect), Member = "InvokeGetCachedEventAttributeForOutputEvent_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualEffect)}, ReturnType = typeof(VFXEventAttribute))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001E")]
	public VisualEffectAsset get_visualEffectAsset() { }

	[Address(RVA = "0x1D00C80", Offset = "0x1CFFE80", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000022")]
	private static IntPtr get_visualEffectAsset_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1D00A50", Offset = "0x1CFFC50", Length = "0x1CE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualEffect), Member = "get_visualEffectAsset", ReturnType = typeof(VisualEffectAsset))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000020")]
	private static VFXEventAttribute InvokeGetCachedEventAttributeForOutputEvent_Internal(VisualEffect source) { }

	[Address(RVA = "0x1D00C20", Offset = "0x1CFFE20", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000021")]
	private static void InvokeOutputEventReceived_Internal(VisualEffect source, int eventNameId) { }

}

