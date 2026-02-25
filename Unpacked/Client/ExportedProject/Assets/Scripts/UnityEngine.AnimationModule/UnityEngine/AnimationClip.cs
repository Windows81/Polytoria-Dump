namespace UnityEngine;

[NativeHeader("Modules/Animation/ScriptBindings/AnimationClip.bindings.h")]
[NativeType("Modules/Animation/AnimationClip.h")]
[Token(Token = "0x200000C")]
public sealed class AnimationClip : Motion
{

	[Token(Token = "0x1700000B")]
	public bool legacy
	{
		[Address(RVA = "0x1911A30", Offset = "0x1910C30", Length = "0x76")]
		[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.AnimationClip[]"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeMethod("IsLegacy")]
		[Token(Token = "0x6000047")]
		 get { } //Length: 118
		[Address(RVA = "0x1911B00", Offset = "0x1910D00", Length = "0x86")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeMethod("SetLegacy")]
		[Token(Token = "0x6000048")]
		 set { } //Length: 134
	}

	[NativeProperty("WrapMode", False, TargetType::Function (0))]
	[Token(Token = "0x1700000A")]
	public WrapMode wrapMode
	{
		[Address(RVA = "0x1911BD0", Offset = "0x1910DD0", Length = "0x83")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000046")]
		 set { } //Length: 131
	}

	[Address(RVA = "0x1911980", Offset = "0x1910B80", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000043")]
	public AnimationClip() { }

	[Address(RVA = "0x1911A30", Offset = "0x1910C30", Length = "0x76")]
	[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.AnimationClip[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("IsLegacy")]
	[Token(Token = "0x6000047")]
	public bool get_legacy() { }

	[Address(RVA = "0x19119F0", Offset = "0x1910BF0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004B")]
	private static bool get_legacy_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1911590", Offset = "0x1910790", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("AnimationClipBindings::Internal_CreateAnimationClip")]
	[Token(Token = "0x6000044")]
	private static void Internal_CreateAnimationClip(AnimationClip self) { }

	[Address(RVA = "0x1911B00", Offset = "0x1910D00", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("SetLegacy")]
	[Token(Token = "0x6000048")]
	public void set_legacy(bool value) { }

	[Address(RVA = "0x1911AB0", Offset = "0x1910CB0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004C")]
	private static void set_legacy_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x1911BD0", Offset = "0x1910DD0", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000046")]
	public void set_wrapMode(WrapMode value) { }

	[Address(RVA = "0x1911B90", Offset = "0x1910D90", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004A")]
	private static void set_wrapMode_Injected(IntPtr _unity_self, WrapMode value) { }

	[Address(RVA = "0x1911640", Offset = "0x1910840", Length = "0x33C")]
	[CalledBy(Type = "GLTFast.AnimationUtils", Member = "AddRotationCurves", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationClip), typeof(string), "Unity.Collections.NativeArray`1<Single>", "Unity.Collections.NativeArray`1<Quaternion>", "GLTFast.Schema.InterpolationType"}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.AnimationUtils", Member = "AddVec3Curves", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationClip), typeof(string), typeof(string), "Unity.Collections.NativeArray`1<Single>", "Unity.Collections.NativeArray`1<float3>", "GLTFast.Schema.InterpolationType"}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.AnimationUtils", Member = "AddScalarCurve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationClip), typeof(string), typeof(string), typeof(int), typeof(int), "Unity.Collections.NativeArray`1<Single>", "Unity.Collections.NativeArray`1<Single>", "GLTFast.Schema.InterpolationType"}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("AnimationClipBindings::Internal_SetCurve", HasExplicitThis = True)]
	[Token(Token = "0x6000045")]
	public void SetCurve(string relativePath, Type type, string propertyName, AnimationCurve curve) { }

	[Address(RVA = "0x19115D0", Offset = "0x19107D0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000049")]
	private static void SetCurve_Injected(IntPtr _unity_self, ref ManagedSpanWrapper relativePath, Type type, ref ManagedSpanWrapper propertyName, IntPtr curve) { }

}

